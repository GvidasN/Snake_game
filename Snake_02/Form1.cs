using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_02
{
    public partial class Form1 : Form
    {      
        Snake snake;
        ProgressBarChanges progress;
        IFood newFood;
        FactoryFood factoryFood;
        int Score = 0;

        void ActionEat()
        {
            snake.Eat(newFood);

            Score += newFood.GetValue();
            labScore.Text = Score.ToString();

            if (newFood is TimerFood) GameTimer.Interval -= GameTimer.Interval / snake.Speed;

            newFood = factoryFood.CreateNewFood(snake.GetSnakeBodyCount(), gameZone, true);
        }

        void CheckFoodTimer()
        {
            if (progressTime.Value < 100) progressTime.Value += progressTime.Step;
            else newFood = factoryFood.CreateNewFood(snake.GetSnakeBodyCount(), gameZone, false);
        }

        void UpdateScreen(object sender, EventArgs e)
        {
            snake.OrderToMove(gameZone);

            if (!snake.CheckIfHitBodyPart() && !snake.CheckIfHitBorder(gameZone))
            {
                if (snake.CheckIfSameCoordWithFood(newFood)) ActionEat();
                
                if (newFood is TimerFood) CheckFoodTimer();              
            }
            else
            {
                GameTimer.Stop();
                labGameOver.Visible = true;
            }

            if (progressTime.Enabled == true) CheckFoodTimer();

            gameZone.Invalidate();
        }

        void InitializeObjects()
        {
            labGameOver.Visible = false;
            labScore.Text = Score.ToString();

            MessageBox.Show("Game will begin after you close this window", "Good luck!");

            snake = new Snake(new Circle(2, 10, Brushes.Black));
            progress = new ProgressBarChanges(progressTime,labProgress);
            factoryFood = new FactoryFood(progressTime, progress);
            newFood = new NormalFood(10, 5, Brushes.Red);

            progress.SetProgressBarOff();

            // START OF THE TIMER
            GameTimer.Tick += UpdateScreen;
            GameTimer.Interval = 100;
            GameTimer.Start();          
        }

        public Form1()
        {
            InitializeComponent();
            InitializeObjects();
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void gameZone_Paint(object sender, PaintEventArgs e)
        {
            snake.DrawSnake(e);
            newFood.Draw(e);
        }
    }
}


