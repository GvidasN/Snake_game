using System.Windows.Forms;

namespace Snake_02
{
    class ProgressBarChanges
    {
        ProgressBar _progressBar;
        Label _progressLabel;

        public ProgressBarChanges (ProgressBar progressBar, Label hurry)
        {
            this._progressBar = progressBar;
            _progressLabel = hurry;
        }

        public void SetProgressBarOn()
        {
            _progressBar.Enabled = true;
            _progressBar.Visible = true;
            _progressLabel.Visible = true;
        }

        public void SetProgressBarOff()
        {
            _progressBar.Value = 0;
            _progressBar.Enabled = false;
            _progressBar.Visible = false;
            _progressLabel.Visible = false;
        }
    }
}
