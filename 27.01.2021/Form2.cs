using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27._01._2021
{
    public partial class Form2 : Form
    {
        int val;
        public Form2()
        {
            InitializeComponent();
        }
        public int value
        {
            get
            {
                return val;
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            val = trackBar1.Value;
            label1.Text = val.ToString();
        }
    }
}
