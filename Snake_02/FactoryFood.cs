using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_02
{
    class FactoryFood
    {
        NormalFood _normalFood;
        TimerFood _timerFood;
        ProgressBar _progress;
        ProgressBarChanges progressBarChange;

        public FactoryFood (ProgressBar progress, ProgressBarChanges progressChange)
        {
            _normalFood = new NormalFood(10, 5, Brushes.Red);
            _timerFood = new TimerFood(10, 5, Brushes.DarkBlue);
            this._progress = progress;
            progressBarChange = progressChange;
        }

        public IFood CreateNewFood (int count, PictureBox gameArena, bool checkIfTime)
        {
            IFood _newFood;

            if (count % 8 == 0 && checkIfTime == true)
            {
                _newFood = _timerFood;
                progressBarChange.SetProgressBarOn();
            }
            else
            {
                _newFood = _normalFood;
                progressBarChange.SetProgressBarOff();
            }

            _newFood.SetNewCoordinates(gameArena);
            return _newFood;
        }
    }
}
