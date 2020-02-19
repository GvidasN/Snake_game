using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_02
{
    public class Snake
    {
        Directions _direction = Directions.up;
        List<Circle> SnakeBody = new List<Circle>();
        int _step = 1;
        public int Speed { get; }

        public Snake (Circle partOfBody)
        {
            SnakeBody.Add(partOfBody);
            Speed = 10;
        }

        public int GetSnakeBodyCount()
        {
            return SnakeBody.Count;
        }

        public Directions GetDirect()
        {
            return _direction;
        }

        public void SetDirect(Directions direction)
        {
            this._direction = direction;
        }

        // CHECKS FOR NOT PASSING BORDER AND/OR HITTING A BODY PART
        public bool CheckIfHitBodyPart()
        {
            for (int i = 1; i < SnakeBody.Count; i++)
            {
                if (SnakeBody[i].X == SnakeBody[0].X && SnakeBody[i].Y == SnakeBody[0].Y) return true;
            }
            return false;
        }

        public bool CheckIfHitBorder(PictureBox gameArena)
        {
            for (int i = SnakeBody.Count - 1; i >= 0; i--)
            {
                if (SnakeBody[i].X < 0 || SnakeBody[i].Y < 0
                        || SnakeBody[i].X >= (gameArena.Size.Width / SnakeBody[i].Length) || SnakeBody[i].Y >= (gameArena.Size.Height / SnakeBody[i].Length))
                {
                    return true;
                }
            }

            return false;
        }

        public bool CheckIfSameCoordWithFood(IFood food)
        {
            if (SnakeBody[0].X == food.GetX() && SnakeBody[0].Y == food.GetY())
            {
                return true;
            }
            return false;
        }

        // ADDING CIRCLE TO BODY

        void AddBodyPart ()
        {
            int addX = SnakeBody[SnakeBody.Count - 1].X;
            int addY = SnakeBody[SnakeBody.Count - 1].Y;
            SnakeBody.Add(new Circle(addX, addY, Brushes.Green));
        }

        public void Eat(IFood food)
        {
            //Add new part to Snake's body
            if (food is TimerFood) AddBodyPart();
            AddBodyPart();
        }

        private void Movement(PictureBox gameArena)
        {
            for (int i = SnakeBody.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (GetDirect())
                    {
                        case Directions.up:
                            SnakeBody[i].Y -= _step;
                            break;
                        case Directions.right:
                            SnakeBody[i].X += _step;
                            break;
                        case Directions.down:
                            SnakeBody[i].Y += _step;
                            break;
                        case Directions.left:
                            SnakeBody[i].X -= _step;
                            break;
                        default: break;
                    }
                }
                else
                {
                    SnakeBody[i].X = SnakeBody[i - 1].X;
                    SnakeBody[i].Y = SnakeBody[i - 1].Y;
                }
            }
        }

        // DRAW SNAKE
        public void DrawSnake(PaintEventArgs e)
        {
            for (int i = 0; i < SnakeBody.Count; i++)
            {
                SnakeBody[i].Drawing(e);
            }
        }

        public void OrderToMove(PictureBox gameArena)
        {
            if (Input.KeyPressed(Keys.Right) && GetDirect() != Directions.left)
                SetDirect(Directions.right);
            else if (Input.KeyPressed(Keys.Left) && GetDirect() != Directions.right)
                SetDirect(Directions.left);
            else if (Input.KeyPressed(Keys.Up) && GetDirect() != Directions.down)
                SetDirect(Directions.up);
            else if (Input.KeyPressed(Keys.Down) && GetDirect() != Directions.up)
                SetDirect(Directions.down);

            Movement(gameArena);
        }
    }
}

