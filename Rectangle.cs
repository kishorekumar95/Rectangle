using System;

namespace ProjectRectangle
{
    /// <summary>
    /// For reference example coordinates 
    /// (6,7)(2,3) - Invalid
    /// (2,3)(2,5) - Invalid
    /// (2,3)(5,3) - Invalid
    /// (2,7)(6,3) - Valid 
    /// </summary>
    public class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public int Length => BottomRight.X - TopLeft.X;
        public int Height => TopLeft.Y - BottomRight.Y;

        public Rectangle()
        {
            TopLeft = new Point();
            BottomRight = new Point();
        }

        public bool IsValid()
        {
            if (Length > 0 && Height > 0)
            {
                return true;
            }
            return false;
        }

        public bool InXRange(int xValue)
        {
            return xValue > TopLeft.X && xValue < BottomRight.X;
        }

        public bool InYRange(int yValue)
        {
            return yValue > BottomRight.Y && yValue < TopLeft.Y;
        }

        public static bool IsOverLapping(Rectangle rectangle1, Rectangle rectangle2)
        {
            if ((rectangle1.InXRange(rectangle2.TopLeft.X) || rectangle1.InXRange(rectangle2.BottomRight.X))
                && (rectangle1.InYRange(rectangle2.TopLeft.Y) || rectangle1.InYRange(rectangle2.BottomRight.Y)))
                return true;

            if ((rectangle2.InXRange(rectangle1.TopLeft.X) || rectangle2.InXRange(rectangle1.BottomRight.X))
                && (rectangle2.InYRange(rectangle1.TopLeft.Y) || rectangle2.InYRange(rectangle1.BottomRight.Y)))
                return true;

            return false;
        }

    }
}