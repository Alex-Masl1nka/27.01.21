using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _27._01._2021
{
    public abstract class Draw
    {
        protected int x, y, del_x, del_y;
        protected int r=50;
        protected bool grab, inside;
        public Draw(int x, int y)
        {
            this.x = x;
            this.del_x = 0;
            this.del_y = 0;
            grab = false;
            this.y = y;
            inside = false;
        }
        //static Draw()
        //{ r = 75; }
        public int SetX { get { return x; } set { x = value; } }
        public int SetY { get { return y; } set { y = value; } }
        public int Del_x { get => del_x; set { del_x = value; } }
        public int Del_y { get => del_y; set { del_y = value; } }
        public bool drag { get => grab; set { grab = value; } }
        public bool isInside { get => inside; set { inside = value; } }
        public abstract void DrawFigure(Graphics graf, SolidBrush br, int rad);
        abstract public bool check(int x, int y);
    }
    public class circle : Draw
    {
        SolidBrush br = new SolidBrush(Color.Green);
        public circle(int x, int y) : base(x, y)
        {
        }
        public override void DrawFigure(Graphics graf, SolidBrush br1, int r)
        {
            graf.FillEllipse(br1, x - (r / 2), y - (r / 2), r, r);
        }
        public override bool check(int x, int y)
        {
            if (Math.Sqrt(Math.Pow(x - this.x - (r / 2), 2) + Math.Pow(y - this.y - (r / 2), 2)) < r) return true;
            else return false;
        }
    }
}
