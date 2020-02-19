using System.Windows.Forms;

namespace Snake_02
{
    public interface IFood
    {
        int GetValue();
        int GetX();
        int GetY();
        void SetNewCoordinates(PictureBox arena);
        void Draw(PaintEventArgs e);
    }
}
