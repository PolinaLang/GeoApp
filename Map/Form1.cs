using Map.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Windows.Input;
using System.Runtime.InteropServices;
using System.Windows;
using System.Runtime.CompilerServices;

namespace Map
{
    
    public partial class Form1 : Form
    {
        internal readonly GMapOverlay Routes = new GMapOverlay("routes");
        internal readonly GMapOverlay Objects = new GMapOverlay("objects");

        private List<Place> places;
        private List<PointLatLng> points = new List<PointLatLng>();
        private bool isCollapsedA = true;
        private bool isCollapsedR = false;
        private bool isHideMenu;
        private int[] check = {0, 0, 0, 0, 0, 0, 0};
        private int btnTag;
        private object clickedPlace;
        double distance = 0; int duration = 0;
        public Form1()
        {
            InitializeComponent();
            
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Markers_Load();
            gMap.Overlays.Clear();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonResize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                buttonResize.BackgroundImage = Properties.Resources.arrow_right_up;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                buttonResize.BackgroundImage = Properties.Resources.arrow_left_down;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timerSubMenu_Tick(object sender, EventArgs e)
        {
            if (isCollapsedA)
            {
                buttonArea.Image = Resources.angle_up;
                panelSubMenu.Height += 10;
                picRoute.Visible = false;
                if (panelSubMenu.Size == panelSubMenu.MaximumSize)
                {
                    timerSubMenu.Stop();
                    isCollapsedA = false;
                }
                picRoute1.Visible = true;
            }
            else
            {
                buttonArea.Image = Resources.angle_down;
                panelSubMenu.Height -= 10;
                picRoute1.Visible = false;
                if (panelSubMenu.Size == panelSubMenu.MinimumSize)
                {
                    timerSubMenu.Stop();
                    isCollapsedA = true;
                }
                picRoute.Visible = true;
            }
        }

        private void timerSubMenuR_Tick(object sender, EventArgs e)
        {
            if (isCollapsedR)
            {
                buttonRoute.Image = Resources.angle_up;
                panelSubMenu2.Height += 10;
                if (panelSubMenu2.Size == panelSubMenu2.MaximumSize)
                {
                    timerSubMenuR.Stop();
                    isCollapsedR = false;
                }
            }
            else
            {
                buttonRoute.Image = Resources.angle_down;
                panelSubMenu2.Height -= 10;
                if (panelSubMenu2.Size == panelSubMenu2.MinimumSize)
                {
                    timerSubMenuR.Stop();
                    isCollapsedR = true;
                }
            }
        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            timerSubMenu.Start();
        }

        private void buttonRoute_Click(object sender, EventArgs e)
        {
            timerSubMenuR.Start();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            timerHideMenu.Start();
        }

        private void timerHideMenu_Tick(object sender, EventArgs e)
        {
            if (isHideMenu)
            {
                panelMenu.Width += 50;
                if (panelMenu.Width == 200)
                {
                    panelMenu.Width -= 12;
                    timerHideMenu.Stop();
                    isHideMenu = false;
                }
            }
            else
            {
                panelMenu.Width -= 50;
                if (panelMenu.Width == 0)
                {
                    timerHideMenu.Stop();
                    isHideMenu = true;
                }
            }
        }

        private void gMap_Load(object sender, EventArgs e)
        {
            
            // Перетаскивание карты
            gMap.CanDragMap = true;
            // Перетаскивание карты левой кнопкой мыши
            gMap.DragButton = MouseButtons.Left;
            // Все маркеры будут показаны
            gMap.MarkersEnabled = true;
            gMap.NegativeMode = false;
            gMap.Bearing = 0;
            gMap.PolygonsEnabled = true;
            // Разрешение маршрутов
            gMap.RoutesEnabled = true;
            gMap.MaxZoom = 16;
            gMap.MinZoom = 4;
            gMap.Zoom = 7;
            zoomBar.Value = (int)gMap.Zoom;
            // Чья карта используется
            gMap.ShowTileGridLines = false;
            gMap.MapProvider = GMapProviders.OpenStreetMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            //Масштабирование карты при наведении на маркер
            gMap.IgnoreMarkerOnMouseWheel = true;
            // Курсор мыши в центр карты
            gMap.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
            //Загрузка центральной точки на карте
            //gMap.SetPositionByKeywords("Perm");
            gMap.Position = new PointLatLng(56.984663, 57.227759);
            gMap.ShowCenter = false;
            gMap.OnMarkerClick += new MarkerClick(gMap_OnMarkerClick);
            gMap.OnMarkerEnter += GMap_OnMarkerEnter;
            clearMap();
            
        }

        

        private void Markers_Load()
        {
            DateBase db = new DateBase();
            places = new List<Place>();
            db.GetBase(places);
        }

        private void ShowMarkers(int area)
        {
            GMapOverlay Markers = new GMapOverlay("markers");
            gMap.Overlays.Add(Markers);
            foreach (Place item in places)
            {
                double geoLat = item.GeoLat;
                double geoLng = item.GeoLng;
                if (item.AreaID == area)
                {
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(geoLat, geoLng), GMarkerGoogleType.green);
                    marker.Tag = item.ID;
                    marker.ToolTipText = $"{item.Name}";
                    var toolTip = new GMapBaloonToolTip(marker)
                    {
                        Stroke = new Pen(new SolidBrush(Color.FromArgb(68, 68, 68))),
                        Foreground = new SolidBrush(Color.Black),
                        Fill = new SolidBrush(Color.FromArgb(150, 240, 240, 240)),
                        Font = new Font("Verdana", 9, System.Drawing.FontStyle.Bold),
                    };
                    toolTip.Format.Alignment = StringAlignment.Center;
                    toolTip.Format.LineAlignment = StringAlignment.Center;
                    marker.ToolTip = toolTip;
                    Markers.Markers.Add(marker);
                    Markers.Id = item.AreaID.ToString();
                }
            }
            
        }

        private void RemoveMarkers(int area)
        {

            foreach (GMapOverlay item in gMap.Overlays)
            {
                if (item.Id == area.ToString())
                {
                    item.Clear();
                }
            }
        }

        private void gMap_OnMarkerClick(GMapMarker item, System.Windows.Forms.MouseEventArgs e)
        {
            
        }

        private void GMap_OnMarkerEnter(GMapMarker item)
        {
            clickedPlace = item.Tag;
        }

        private void placeInfoShow(Place place)
        {
            
            Form p = new PlaceInfo(place);
            p.ShowDialog();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            currentBtn(Convert.ToInt32(btn.Tag));
            
            timerCheck.Start();
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            if (check[btnTag] == 0)
            {
                check[btnTag] = 1;
                changeImage(btnTag, 1);
                ShowMarkers(btnTag);
                timerCheck.Stop();
            }
            else
            {
                check[btnTag] = 0;
                changeImage(btnTag, 0);
                RemoveMarkers(btnTag);
                timerCheck.Stop();
            }
        }

        public void currentBtn(int tag)
        {
            btnTag = tag;
        }
        
        public void changeImage(int tag, int code)
        {
            switch (tag)
            {
                case 1:
                    if (code == 1)
                        button1.BackgroundImage = Resources.checked_circle_fill;
                    else
                        button1.BackgroundImage = Resources.delete_circle_fill;
                    break;
                case 2:
                    if (code == 1)
                        button2.BackgroundImage = Resources.checked_circle_fill;
                    else
                        button2.BackgroundImage = Resources.delete_circle_fill;
                    break;
                case 3:
                    if (code == 1)
                        button3.BackgroundImage = Resources.checked_circle_fill;
                    else
                        button3.BackgroundImage = Resources.delete_circle_fill;
                    break;
                case 4:
                    if (code == 1)
                        button4.BackgroundImage = Resources.checked_circle_fill;
                    else
                        button4.BackgroundImage = Resources.delete_circle_fill;
                    break;
                case 5:
                    if (code == 1)
                        button5.BackgroundImage = Resources.checked_circle_fill;
                    else
                        button5.BackgroundImage = Resources.delete_circle_fill;
                    break;
                case 6:
                    if (code == 1)
                        button6.BackgroundImage = Resources.checked_circle_fill;
                    else
                        button6.BackgroundImage = Resources.delete_circle_fill;
                    break;
            }
        }

        private void topPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void gMap_OnMapZoomChanged()
        {
            zoomBar.Value = (int)gMap.Zoom;
        }

        private void zoomBar_Scroll(object sender, EventArgs e)
        {
            gMap.Zoom = zoomBar.Value;
        }

        private void gMap_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var point = gMap.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;

                textLatA.Text = lat + "";
                textLngA.Text = lng + "";
            }
            if (((GMapControl)sender).IsMouseOverMarker)
            {
                if (clickedPlace != null)
                {
                    foreach (Place place in places)
                    {
                        if (place.ID == (int)clickedPlace)
                            placeInfoShow(place);

                    }
                }
                    
            }

        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            PointLatLng p = new PointLatLng(Convert.ToDouble(textLatA.Text), Convert.ToDouble(textLngA.Text));
            gMap.Overlays.Add(Objects);
            points.Add(p);
            GMapMarker m = new GMarkerGoogle(p, GMarkerGoogleType.orange_dot);
            Objects.Markers.Add(m);
        }

        private void btnClearRoute_Click(object sender, EventArgs e)
        {
            clearMap();
        }

        private void clearMap()
        {
            points.Clear();
            Routes.Clear();
            Objects.Clear();
            clearFields();
        }

        private void clearFields()
        {
            distance = 0;
            duration = 0;
            textLatA.Text = "";
            textLngA.Text = "";
            textDist.Text = "";
            textTime.Text = "";
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            RoutingProvider rp = gMap.MapProvider as RoutingProvider;
            if (rp == null)
            {
                rp = GMapProviders.OpenStreetMap;
            }

            try
            {
                gMap.Overlays.Add(Routes);
                for (int i = 1; i < points.Count(); i++)
                {

                    MapRoute r = rp.GetRoute(points[i - 1], points[i], false, false, (int)gMap.Zoom);
                    GMapRoute route = new GMapRoute(r.Points, r.Name);
                    route.Stroke = new Pen(Color.Red, 2);
                    route.IsVisible = true;
                    Routes.Routes.Add(route);
                    distance += r.Distance;
                    duration += Convert.ToInt32(r.Duration.Substring(0, r.Duration.Length - 4));
                }

                var start = points[0];
                var end = points[points.Count() - 1];
                GMapMarker m1 = new GMarkerGoogle(start, GMarkerGoogleType.green_dot);
                GMapMarker m2 = new GMarkerGoogle(end, GMarkerGoogleType.red_dot);
                gMap.Overlays.Add(Objects);
                Objects.Markers.Add(m1);
                Objects.Markers.Add(m2);

                gMap.ZoomAndCenterRoutes("routes");
                gMap.Refresh();

                textDist.Text = Math.Round(distance, 2) + " км.";
                textTime.Text = getTime(duration);

            } catch
            {
                MessageBox.Show("Не удалось построить маршрут!\nПопробуйте еще раз.");
            }


        }

        private string getTime(int min)
        {
            int h = min / 60;
            int m = min % 60;
            return $"{h} ч. {m} мин.";
        }

        private void gMap_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            gMap.Zoom++;

        }

        
    }
}
