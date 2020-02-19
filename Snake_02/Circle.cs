using System.Drawing;
using System.Windows.Forms;

namespace Snake_02
{
    public class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        Brush _color;
        const int _length = 16;

        public Brush Color;

        public int Length
        {
            get
            {
               return _length;
            }
        }

        public Circle(int x, int y, Brush color)
        {
            this.X = x;
            this.Y = y;
            this._color = color;
            Color = color;
        }

        virtual public void SetColor (Brush color)
        {
            _color = color;
        }

        virtual public void Drawing (PaintEventArgs e)
        {
            Graphics draw = e.Graphics;

            draw.FillEllipse(_color, new Rectangle(X * Length, Y * Length, Length, Length));
        }
    }
}
