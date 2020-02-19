using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Snake_02;

namespace UnitTestSnake
{
    [TestClass]
    public class Snake_02_Tests
    {
        [TestMethod]
        public void CheckIfHitBodyPart_ReturnsFalse()
        {
            //arrange

            Snake snake = new Snake(new Circle(2, 10, Brushes.Black));

            //act 
            var result = snake.CheckIfHitBodyPart();

            //result
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfHitBorder_ReturnsTrue()
        {
            //arrange
            Snake snake = new Snake(new Circle(18,100, Brushes.Black));

            PictureBox arena = new PictureBox();
            Size size = new Size(800, 318);
            arena.Size = size;

            //act
            var result = snake.CheckIfHitBorder(arena);

            //result
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfSameCoordWithFood_ReturnsTrue()
        {
            Snake snake = new Snake(new Circle(9, 8, Brushes.Black));
            IFood food = new NormalFood(8, 8, Brushes.Red);

            var result = snake.CheckIfSameCoordWithFood(food);

            Assert.IsTrue(result);
        }
    }
}
