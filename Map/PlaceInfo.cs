using Map.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map
{
    public partial class PlaceInfo : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        int currentPic = 1;
        string path; string path1; string path2;

        public PlaceInfo(object place)
        {
            InitializeComponent();
            setLabelStyle();

            Place p = (Place)place;

            path = getPath(p, 1);
            path1 = getPath(p, 2);
            path2 = getPath(p, 3);

            placeName.Text = p.Name;
            areaName.Text = p.AreaName;
            textDescription.Text = p.Description;
            pictureBox.Image = new Bitmap(path);
        }

        private string getPath(Place p, int count)
        {
            string str = $"..\\..\\pic\\{p.ID}-{count}.jpg";
            return @"" + str;
        }

        private void setLabelStyle()
        {
            label1.Parent = pictureBox;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox;
            label5.BackColor = Color.Transparent;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            int picNum = Convert.ToInt32(label.Tag.ToString());
            changePic(picNum);
            
        }

        private void changePic(int number)
        {
            if (number == 1)
            {
                pictureBox.Image = new Bitmap(path);
                label1.Image = Resources.circle_light;
                label2.Image = Resources.circle_dark;
                label3.Image = Resources.circle_dark;
                currentPic = 1;
            }
            else if (number == 2)
            {
                pictureBox.Image = new Bitmap(path1);
                label1.Image = Resources.circle_dark;
                label2.Image = Resources.circle_light;
                label3.Image = Resources.circle_dark;
                currentPic = 2;
            }
            else if (number == 3)
            {
                pictureBox.Image = new Bitmap(path2);
                label1.Image = Resources.circle_dark;
                label2.Image = Resources.circle_dark;
                label3.Image = Resources.circle_light;
                currentPic = 3;
            }
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Tag.ToString() == "4")
            {
                label.Image = Resources.angle_right_light_b;
            } else if (label.Tag.ToString() == "5")
            {
                label.Image = Resources.angle_left_light_b;
            }
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Tag.ToString() == "4")
            {
                label.Image = Resources.angle_right_dark_b;
            }
            else if (label.Tag.ToString() == "5")
            {
                label.Image = Resources.angle_left_dark_b;
            }
        }

        private void label_arrow_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (currentPic == 1)
            {
                if (Convert.ToInt32(label.Tag.ToString()) == 4)
                {
                    changePic(2);
                } else if (Convert.ToInt32(label.Tag.ToString()) == 5)
                {
                    changePic(3);
                }
            } else if (currentPic == 2)
            {
                if (Convert.ToInt32(label.Tag.ToString()) == 4)
                {
                    changePic(3);
                }
                else if (Convert.ToInt32(label.Tag.ToString()) == 5)
                {
                    changePic(1);
                }
            } else if (currentPic == 3)
            {
                if (Convert.ToInt32(label.Tag.ToString()) == 4)
                {
                    changePic(1);
                }
                else if (Convert.ToInt32(label.Tag.ToString()) == 5)
                {
                    changePic(2);
                }
            }
        }
    }
}
