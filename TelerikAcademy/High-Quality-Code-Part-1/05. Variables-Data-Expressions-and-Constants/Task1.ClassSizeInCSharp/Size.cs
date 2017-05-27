using System;

namespace Task1.ClassSizeInCSharp
{
    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

                public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be positive number");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be positive number");
                }

                this.height = value;
            }
        }

        public static Size GetRotatedSize(Size size, double rotateAngle)
        {
            var cos = Math.Cos(rotateAngle);
            var sin = Math.Sin(rotateAngle);

            var newWidth = (Math.Abs(cos) * size.Width) + (Math.Abs(sin) * size.Height);
            var newHeight = (Math.Abs(sin) * size.Width) + (Math.Abs(cos) * size.Height);

            return new Size(newWidth, newHeight);
        }
    }
}
