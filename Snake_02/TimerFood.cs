using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_02
{
    class TimerFood : Circle, IFood
    {
        int _value;

        public TimerFood(int x, int y, Brush color) : base(x, y, color)
        {
            _value = 500;
        }

        public int GetValue()
        {
            return _value;
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }

        public void SetNewCoordinates(PictureBox gameArena)
        {
            //check arena's measures to generate new item
            int maxXPos = gameArena.Width / Length;
            int maxYPos = gameArena.Height / Length;

            Random random = new Random();
            this.X = random.Next(0, maxXPos);
            this.Y = random.Next(0, maxYPos);       
        }

        public void Draw(PaintEventArgs e)
        {
            Graphics draw = e.Graphics;

            draw.FillEllipse(Color, new Rectangle(X * Length, Y * Length, Length, Length));
        }
    }
}
