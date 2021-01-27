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
    public partial class Form1 : Form
    {
        SolidBrush br = new SolidBrush(Color.Aqua);
        int size;
        circle obs = new circle(100, 100);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void изменитьЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            br.Color = colorDialog1.Color;
            Refresh();
        }

        private void изменитьРазмерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.ShowDialog();
            size = fr.value*20;
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            obs.DrawFigure(g, br, size);
            
        }
    }
}
