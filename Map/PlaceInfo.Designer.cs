using System.Drawing;

namespace Map
{
    partial class PlaceInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.placeName = new System.Windows.Forms.TextBox();
            this.areaName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(178)))), ((int)(((byte)(65)))));
            this.panelTop.Controls.Add(this.buttonClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(506, 32);
            this.panelTop.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = global::Map.Properties.Resources.close;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(476, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 32);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = " ";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textDescription
            // 
            this.textDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textDescription.BackColor = System.Drawing.SystemColors.Control;
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescription.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textDescription.Location = new System.Drawing.Point(24, 423);
            this.textDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.ReadOnly = true;
            this.textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDescription.Size = new System.Drawing.Size(482, 182);
            this.textDescription.TabIndex = 4;
            // 
            // placeName
            // 
            this.placeName.BackColor = System.Drawing.SystemColors.Control;
            this.placeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.placeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.placeName.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.placeName.Location = new System.Drawing.Point(0, 32);
            this.placeName.Margin = new System.Windows.Forms.Padding(2);
            this.placeName.Multiline = true;
            this.placeName.Name = "placeName";
            this.placeName.ReadOnly = true;
            this.placeName.Size = new System.Drawing.Size(506, 64);
            this.placeName.TabIndex = 5;
            this.placeName.Text = "Place";
            // 
            // areaName
            // 
            this.areaName.BackColor = System.Drawing.SystemColors.Control;
            this.areaName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.areaName.Dock = System.Windows.Forms.DockStyle.Top;
            this.areaName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.areaName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.areaName.Location = new System.Drawing.Point(0, 96);
            this.areaName.Margin = new System.Windows.Forms.Padding(2);
            this.areaName.Multiline = true;
            this.areaName.Name = "areaName";
            this.areaName.ReadOnly = true;
            this.areaName.Size = new System.Drawing.Size(506, 18);
            this.areaName.TabIndex = 6;
            this.areaName.Text = "Area";
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Image = global::Map.Properties.Resources.angle_left_dark_b;
            this.label5.Location = new System.Drawing.Point(13, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 32);
            this.label5.TabIndex = 14;
            this.label5.Tag = "5";
            this.label5.Click += new System.EventHandler(this.label_arrow_Click);
            this.label5.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Image = global::Map.Properties.Resources.angle_right_dark_b;
            this.label4.Location = new System.Drawing.Point(438, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 32);
            this.label4.TabIndex = 13;
            this.label4.Tag = "4";
            this.label4.Click += new System.EventHandler(this.label_arrow_Click);
            this.label4.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Image = global::Map.Properties.Resources.circle_dark;
            this.label3.Location = new System.Drawing.Point(254, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Tag = "3";
            this.label3.Text = "     ";
            this.label3.Click += new System.EventHandler(this.label_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Image = global::Map.Properties.Resources.circle_dark;
            this.label2.Location = new System.Drawing.Point(229, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 14);
            this.label2.TabIndex = 11;
            this.label2.Tag = "2";
            this.label2.Text = "     ";
            this.label2.Click += new System.EventHandler(this.label_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::Map.Properties.Resources.circle_light;
            this.label1.Location = new System.Drawing.Point(191, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Tag = "1";
            this.label1.Text = "     ";
            this.label1.Click += new System.EventHandler(this.label_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(11, 119);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(484, 290);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // PlaceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 616);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.areaName);
            this.Controls.Add(this.placeName);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlaceInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PlaceInfo";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox placeName;
        private System.Windows.Forms.TextBox areaName;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}