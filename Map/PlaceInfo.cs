using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map
{
    public partial class PlaceInfo : Form
    {
        bool show = true;
        public PlaceInfo(Object tag)
        {
            InitializeComponent();
            string text = tag.ToString();
            textBox1.Text = text;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            showInfo();
        }

        public bool showInfo()
        {
            return show = false;
        }
    }
}
