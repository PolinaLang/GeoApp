namespace Map
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topPanel = new System.Windows.Forms.Panel();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonResize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.timerSubMenu = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.picRoute1 = new System.Windows.Forms.Button();
            this.picRoute = new System.Windows.Forms.Button();
            this.picArea = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.timerHideMenu = new System.Windows.Forms.Timer(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.zoomBar = new System.Windows.Forms.TrackBar();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.panelSubMenu2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRoute = new System.Windows.Forms.Button();
            this.startPanel = new System.Windows.Forms.Panel();
            this.labelLng = new System.Windows.Forms.Label();
            this.labelLat = new System.Windows.Forms.Label();
            this.textLngA = new System.Windows.Forms.TextBox();
            this.textLatA = new System.Windows.Forms.TextBox();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnRoute = new System.Windows.Forms.Button();
            this.btnClearRoute = new System.Windows.Forms.Button();
            this.endPanel = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDir = new System.Windows.Forms.Label();
            this.textTime = new System.Windows.Forms.TextBox();
            this.textDist = new System.Windows.Forms.TextBox();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonArea2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonArea1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonArea3 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonArea4 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonArea5 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonArea6 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonArea = new System.Windows.Forms.Button();
            this.timerSubMenuR = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            this.panelSubMenu2.SuspendLayout();
            this.startPanel.SuspendLayout();
            this.endPanel.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(178)))), ((int)(((byte)(65)))));
            this.topPanel.Controls.Add(this.buttonMinus);
            this.topPanel.Controls.Add(this.buttonResize);
            this.topPanel.Controls.Add(this.buttonClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(226, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(974, 32);
            this.topPanel.TabIndex = 5;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackgroundImage = global::Map.Properties.Resources.minus;
            this.buttonMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinus.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(178)))), ((int)(((byte)(65)))));
            this.buttonMinus.Location = new System.Drawing.Point(884, 0);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(30, 32);
            this.buttonMinus.TabIndex = 1;
            this.buttonMinus.Text = " ";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonResize
            // 
            this.buttonResize.BackgroundImage = global::Map.Properties.Resources.arrow_left_down;
            this.buttonResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonResize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(178)))), ((int)(((byte)(65)))));
            this.buttonResize.Location = new System.Drawing.Point(914, 0);
            this.buttonResize.Margin = new System.Windows.Forms.Padding(0);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(30, 32);
            this.buttonResize.TabIndex = 1;
            this.buttonResize.Text = " ";
            this.buttonResize.UseVisualStyleBackColor = true;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = global::Map.Properties.Resources.close;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(178)))), ((int)(((byte)(65)))));
            this.buttonClose.Location = new System.Drawing.Point(944, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 32);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = " ";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // timerSubMenu
            // 
            this.timerSubMenu.Interval = 15;
            this.timerSubMenu.Tick += new System.EventHandler(this.timerSubMenu_Tick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(146)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.picRoute1);
            this.panel7.Controls.Add(this.picRoute);
            this.panel7.Controls.Add(this.picArea);
            this.panel7.Controls.Add(this.buttonMenu);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(38, 650);
            this.panel7.TabIndex = 6;
            // 
            // picRoute1
            // 
            this.picRoute1.BackgroundImage = global::Map.Properties.Resources.compass_direction_new;
            this.picRoute1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picRoute1.FlatAppearance.BorderSize = 0;
            this.picRoute1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.picRoute1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(146)))), ((int)(((byte)(64)))));
            this.picRoute1.Location = new System.Drawing.Point(0, 380);
            this.picRoute1.Margin = new System.Windows.Forms.Padding(0);
            this.picRoute1.Name = "picRoute1";
            this.picRoute1.Size = new System.Drawing.Size(38, 41);
            this.picRoute1.TabIndex = 4;
            this.picRoute1.Text = " ";
            this.picRoute1.UseVisualStyleBackColor = true;
            this.picRoute1.Visible = false;
            this.picRoute1.Click += new System.EventHandler(this.picRoute1_Click);
            // 
            // picRoute
            // 
            this.picRoute.BackgroundImage = global::Map.Properties.Resources.compass_direction_new;
            this.picRoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picRoute.FlatAppearance.BorderSize = 0;
            this.picRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.picRoute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(146)))), ((int)(((byte)(64)))));
            this.picRoute.Location = new System.Drawing.Point(0, 88);
            this.picRoute.Margin = new System.Windows.Forms.Padding(0);
            this.picRoute.Name = "picRoute";
            this.picRoute.Size = new System.Drawing.Size(38, 41);
            this.picRoute.TabIndex = 3;
            this.picRoute.Text = " ";
            this.picRoute.UseVisualStyleBackColor = true;
            this.picRoute.Click += new System.EventHandler(this.picRoute_Click);
            // 
            // picArea
            // 
            this.picArea.BackgroundImage = global::Map.Properties.Resources.markers_new;
            this.picArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picArea.FlatAppearance.BorderSize = 0;
            this.picArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.picArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(146)))), ((int)(((byte)(64)))));
            this.picArea.Location = new System.Drawing.Point(0, 37);
            this.picArea.Margin = new System.Windows.Forms.Padding(0);
            this.picArea.Name = "picArea";
            this.picArea.Size = new System.Drawing.Size(38, 41);
            this.picArea.TabIndex = 2;
            this.picArea.Text = " ";
            this.picArea.UseVisualStyleBackColor = true;
            this.picArea.Click += new System.EventHandler(this.picArea_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackgroundImage = global::Map.Properties.Resources.menu;
            this.buttonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(146)))), ((int)(((byte)(64)))));
            this.buttonMenu.Location = new System.Drawing.Point(0, 0);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(38, 32);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = " ";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // timerHideMenu
            // 
            this.timerHideMenu.Interval = 15;
            this.timerHideMenu.Tick += new System.EventHandler(this.timerHideMenu_Tick);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.zoomBar);
            this.panel8.Controls.Add(this.gMap);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(226, 32);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(974, 618);
            this.panel8.TabIndex = 7;
            // 
            // zoomBar
            // 
            this.zoomBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomBar.BackColor = System.Drawing.SystemColors.Control;
            this.zoomBar.LargeChange = 2;
            this.zoomBar.Location = new System.Drawing.Point(916, 487);
            this.zoomBar.Maximum = 16;
            this.zoomBar.Minimum = 4;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.zoomBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.zoomBar.Size = new System.Drawing.Size(45, 119);
            this.zoomBar.TabIndex = 2;
            this.zoomBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.zoomBar.Value = 4;
            this.zoomBar.Scroll += new System.EventHandler(this.zoomBar_Scroll);
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMap.EmptyTileColor = System.Drawing.Color.DimGray;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(0, 0);
            this.gMap.Margin = new System.Windows.Forms.Padding(2);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(974, 618);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 0D;
            this.gMap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gMap_OnMapZoomChanged);
            this.gMap.Load += new System.EventHandler(this.gMap_Load);
            this.gMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseClick);
            this.gMap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseDoubleClick);
            // 
            // panelSubMenu2
            // 
            this.panelSubMenu2.Controls.Add(this.buttonRoute);
            this.panelSubMenu2.Controls.Add(this.startPanel);
            this.panelSubMenu2.Controls.Add(this.btnAddPoint);
            this.panelSubMenu2.Controls.Add(this.btnRoute);
            this.panelSubMenu2.Controls.Add(this.btnClearRoute);
            this.panelSubMenu2.Controls.Add(this.endPanel);
            this.panelSubMenu2.Location = new System.Drawing.Point(0, 81);
            this.panelSubMenu2.Margin = new System.Windows.Forms.Padding(0);
            this.panelSubMenu2.MaximumSize = new System.Drawing.Size(188, 341);
            this.panelSubMenu2.MinimumSize = new System.Drawing.Size(188, 49);
            this.panelSubMenu2.Name = "panelSubMenu2";
            this.panelSubMenu2.Size = new System.Drawing.Size(188, 341);
            this.panelSubMenu2.TabIndex = 1;
            // 
            // buttonRoute
            // 
            this.buttonRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRoute.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonRoute.FlatAppearance.BorderSize = 0;
            this.buttonRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoute.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRoute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.buttonRoute.Image = global::Map.Properties.Resources.angle_up;
            this.buttonRoute.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRoute.Location = new System.Drawing.Point(0, 0);
            this.buttonRoute.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRoute.MinimumSize = new System.Drawing.Size(188, 49);
            this.buttonRoute.Name = "buttonRoute";
            this.buttonRoute.Size = new System.Drawing.Size(188, 49);
            this.buttonRoute.TabIndex = 3;
            this.buttonRoute.Text = "Маршрут";
            this.buttonRoute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoute.UseVisualStyleBackColor = true;
            this.buttonRoute.Click += new System.EventHandler(this.buttonRoute_Click);
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.labelLng);
            this.startPanel.Controls.Add(this.labelLat);
            this.startPanel.Controls.Add(this.textLngA);
            this.startPanel.Controls.Add(this.textLatA);
            this.startPanel.Location = new System.Drawing.Point(0, 49);
            this.startPanel.Margin = new System.Windows.Forms.Padding(0);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(188, 80);
            this.startPanel.TabIndex = 4;
            // 
            // labelLng
            // 
            this.labelLng.AutoSize = true;
            this.labelLng.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.labelLng.Location = new System.Drawing.Point(3, 51);
            this.labelLng.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLng.Name = "labelLng";
            this.labelLng.Size = new System.Drawing.Size(36, 16);
            this.labelLng.TabIndex = 3;
            this.labelLng.Text = "В.Д.";
            // 
            // labelLat
            // 
            this.labelLat.AutoSize = true;
            this.labelLat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.labelLat.Location = new System.Drawing.Point(3, 17);
            this.labelLat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(40, 16);
            this.labelLat.TabIndex = 2;
            this.labelLat.Text = "С.Ш.";
            // 
            // textLngA
            // 
            this.textLngA.Enabled = false;
            this.textLngA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.textLngA.Location = new System.Drawing.Point(50, 49);
            this.textLngA.Name = "textLngA";
            this.textLngA.Size = new System.Drawing.Size(102, 20);
            this.textLngA.TabIndex = 1;
            // 
            // textLatA
            // 
            this.textLatA.Enabled = false;
            this.textLatA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.textLatA.Location = new System.Drawing.Point(50, 15);
            this.textLatA.Name = "textLatA";
            this.textLatA.Size = new System.Drawing.Size(102, 20);
            this.textLatA.TabIndex = 0;
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPoint.FlatAppearance.BorderSize = 0;
            this.btnAddPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPoint.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPoint.Image = global::Map.Properties.Resources.add_geotag_1;
            this.btnAddPoint.Location = new System.Drawing.Point(0, 129);
            this.btnAddPoint.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(60, 65);
            this.btnAddPoint.TabIndex = 6;
            this.btnAddPoint.Text = " ";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // btnRoute
            // 
            this.btnRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoute.FlatAppearance.BorderSize = 0;
            this.btnRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoute.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRoute.Image = global::Map.Properties.Resources.direction;
            this.btnRoute.Location = new System.Drawing.Point(60, 129);
            this.btnRoute.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Size = new System.Drawing.Size(65, 65);
            this.btnRoute.TabIndex = 7;
            this.btnRoute.Text = " ";
            this.btnRoute.UseVisualStyleBackColor = true;
            this.btnRoute.Click += new System.EventHandler(this.btnRoute_Click);
            // 
            // btnClearRoute
            // 
            this.btnClearRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearRoute.FlatAppearance.BorderSize = 0;
            this.btnClearRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRoute.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearRoute.Image = global::Map.Properties.Resources.delete_geotag_1;
            this.btnClearRoute.Location = new System.Drawing.Point(125, 129);
            this.btnClearRoute.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearRoute.Name = "btnClearRoute";
            this.btnClearRoute.Size = new System.Drawing.Size(60, 65);
            this.btnClearRoute.TabIndex = 8;
            this.btnClearRoute.Text = " ";
            this.btnClearRoute.UseVisualStyleBackColor = true;
            this.btnClearRoute.Click += new System.EventHandler(this.btnClearRoute_Click);
            // 
            // endPanel
            // 
            this.endPanel.Controls.Add(this.labelTime);
            this.endPanel.Controls.Add(this.labelDir);
            this.endPanel.Controls.Add(this.textTime);
            this.endPanel.Controls.Add(this.textDist);
            this.endPanel.Location = new System.Drawing.Point(0, 194);
            this.endPanel.Margin = new System.Windows.Forms.Padding(0);
            this.endPanel.Name = "endPanel";
            this.endPanel.Size = new System.Drawing.Size(188, 100);
            this.endPanel.TabIndex = 5;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.labelTime.Location = new System.Drawing.Point(3, 41);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(104, 16);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Время в пути:";
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.labelDir.Location = new System.Drawing.Point(3, 14);
            this.labelDir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(93, 16);
            this.labelDir.TabIndex = 4;
            this.labelDir.Text = "Расстояние:";
            // 
            // textTime
            // 
            this.textTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTime.Enabled = false;
            this.textTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.textTime.Location = new System.Drawing.Point(116, 42);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(60, 13);
            this.textTime.TabIndex = 5;
            // 
            // textDist
            // 
            this.textDist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDist.Enabled = false;
            this.textDist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.textDist.Location = new System.Drawing.Point(103, 15);
            this.textDist.Name = "textDist";
            this.textDist.Size = new System.Drawing.Size(60, 13);
            this.textDist.TabIndex = 4;
            // 
            // timerCheck
            // 
            this.timerCheck.Interval = 15;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.panelSubMenu);
            this.panelMenu.Controls.Add(this.panelSubMenu2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(38, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 650);
            this.panelMenu.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(146)))), ((int)(((byte)(64)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(146)))), ((int)(((byte)(64)))));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(188, 32);
            this.panelLogo.TabIndex = 0;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.Controls.Add(this.panel2);
            this.panelSubMenu.Controls.Add(this.panel1);
            this.panelSubMenu.Controls.Add(this.panel3);
            this.panelSubMenu.Controls.Add(this.panel4);
            this.panelSubMenu.Controls.Add(this.panel5);
            this.panelSubMenu.Controls.Add(this.panel6);
            this.panelSubMenu.Controls.Add(this.buttonArea);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 32);
            this.panelSubMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelSubMenu.MaximumSize = new System.Drawing.Size(188, 341);
            this.panelSubMenu.MinimumSize = new System.Drawing.Size(188, 49);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(188, 49);
            this.panelSubMenu.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonArea2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 294);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 49);
            this.panel2.TabIndex = 7;
            // 
            // buttonArea2
            // 
            this.buttonArea2.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonArea2.Enabled = false;
            this.buttonArea2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonArea2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArea2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArea2.Location = new System.Drawing.Point(45, 0);
            this.buttonArea2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonArea2.Name = "buttonArea2";
            this.buttonArea2.Size = new System.Drawing.Size(142, 49);
            this.buttonArea2.TabIndex = 3;
            this.buttonArea2.Text = "Пермский край";
            this.buttonArea2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonArea2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Map.Properties.Resources.delete_circle_fill;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 49);
            this.button2.TabIndex = 6;
            this.button2.Tag = "2";
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonArea1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 49);
            this.panel1.TabIndex = 4;
            // 
            // buttonArea1
            // 
            this.buttonArea1.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonArea1.Enabled = false;
            this.buttonArea1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonArea1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArea1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArea1.Location = new System.Drawing.Point(45, 0);
            this.buttonArea1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonArea1.Name = "buttonArea1";
            this.buttonArea1.Size = new System.Drawing.Size(142, 49);
            this.buttonArea1.TabIndex = 10;
            this.buttonArea1.Text = "Республика Коми";
            this.buttonArea1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonArea1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Map.Properties.Resources.delete_circle_fill;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 49);
            this.button1.TabIndex = 6;
            this.button1.Tag = "1";
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonArea3);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 196);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 49);
            this.panel3.TabIndex = 8;
            // 
            // buttonArea3
            // 
            this.buttonArea3.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonArea3.Enabled = false;
            this.buttonArea3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonArea3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArea3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArea3.Location = new System.Drawing.Point(45, 0);
            this.buttonArea3.Margin = new System.Windows.Forms.Padding(0);
            this.buttonArea3.Name = "buttonArea3";
            this.buttonArea3.Size = new System.Drawing.Size(142, 49);
            this.buttonArea3.TabIndex = 10;
            this.buttonArea3.Text = "Свердловская область";
            this.buttonArea3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonArea3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Map.Properties.Resources.delete_circle_fill;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 49);
            this.button3.TabIndex = 6;
            this.button3.Tag = "3";
            this.button3.Text = " ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonArea4);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 147);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 49);
            this.panel4.TabIndex = 8;
            // 
            // buttonArea4
            // 
            this.buttonArea4.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonArea4.Enabled = false;
            this.buttonArea4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonArea4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArea4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArea4.Location = new System.Drawing.Point(45, 0);
            this.buttonArea4.Margin = new System.Windows.Forms.Padding(0);
            this.buttonArea4.Name = "buttonArea4";
            this.buttonArea4.Size = new System.Drawing.Size(142, 49);
            this.buttonArea4.TabIndex = 10;
            this.buttonArea4.Text = "Челябинская область";
            this.buttonArea4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonArea4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Map.Properties.Resources.delete_circle_fill;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 49);
            this.button4.TabIndex = 6;
            this.button4.Tag = "4";
            this.button4.Text = " ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonArea5);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 98);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(188, 49);
            this.panel5.TabIndex = 8;
            // 
            // buttonArea5
            // 
            this.buttonArea5.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonArea5.Enabled = false;
            this.buttonArea5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonArea5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArea5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArea5.Location = new System.Drawing.Point(45, 0);
            this.buttonArea5.Margin = new System.Windows.Forms.Padding(0);
            this.buttonArea5.Name = "buttonArea5";
            this.buttonArea5.Size = new System.Drawing.Size(142, 49);
            this.buttonArea5.TabIndex = 10;
            this.buttonArea5.Text = "Респ. Башкортостан";
            this.buttonArea5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonArea5.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Map.Properties.Resources.delete_circle_fill;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 49);
            this.button5.TabIndex = 6;
            this.button5.Tag = "5";
            this.button5.Text = " ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonArea6);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 49);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(188, 49);
            this.panel6.TabIndex = 9;
            // 
            // buttonArea6
            // 
            this.buttonArea6.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonArea6.Enabled = false;
            this.buttonArea6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonArea6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArea6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArea6.Location = new System.Drawing.Point(45, 0);
            this.buttonArea6.Margin = new System.Windows.Forms.Padding(0);
            this.buttonArea6.Name = "buttonArea6";
            this.buttonArea6.Size = new System.Drawing.Size(142, 49);
            this.buttonArea6.TabIndex = 10;
            this.buttonArea6.Text = "Оренбургская область";
            this.buttonArea6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonArea6.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Map.Properties.Resources.delete_circle_fill;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Left;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 49);
            this.button6.TabIndex = 6;
            this.button6.Tag = "6";
            this.button6.Text = " ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonArea
            // 
            this.buttonArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonArea.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonArea.FlatAppearance.BorderSize = 0;
            this.buttonArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArea.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.buttonArea.Image = global::Map.Properties.Resources.angle_down;
            this.buttonArea.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonArea.Location = new System.Drawing.Point(0, 0);
            this.buttonArea.Margin = new System.Windows.Forms.Padding(0);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(188, 49);
            this.buttonArea.TabIndex = 2;
            this.buttonArea.Text = "Области";
            this.buttonArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // timerSubMenuR
            // 
            this.timerSubMenuR.Interval = 15;
            this.timerSubMenuR.Tick += new System.EventHandler(this.timerSubMenuR_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(600, 488);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            this.panelSubMenu2.ResumeLayout(false);
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.endPanel.ResumeLayout(false);
            this.endPanel.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button buttonRoute;
        private System.Windows.Forms.Button buttonArea2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonArea1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonArea3;
        private System.Windows.Forms.Button buttonArea4;
        private System.Windows.Forms.Button buttonArea5;
        private System.Windows.Forms.Button buttonArea6;
        private System.Windows.Forms.Timer timerSubMenu;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button picArea;
        private System.Windows.Forms.Button picRoute;
        private System.Windows.Forms.Timer timerHideMenu;
        private System.Windows.Forms.Panel panel8;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.Timer timerCheck;
        private System.Windows.Forms.Button picRoute1;
        private System.Windows.Forms.FlowLayoutPanel panelSubMenu2;
        private System.Windows.Forms.TrackBar zoomBar;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.TextBox textLngA;
        private System.Windows.Forms.TextBox textLatA;
        private System.Windows.Forms.Panel endPanel;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnRoute;
        private System.Windows.Forms.Button btnClearRoute;
        private System.Windows.Forms.Label labelLng;
        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDir;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.TextBox textDist;
        private System.Windows.Forms.Timer timerSubMenuR;
    }
}

