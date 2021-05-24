using System;
using System.Drawing;

namespace ComputerGraphics_firstLab.allFilters.PointsFilters
{
    class GlassFilter : Filters
    {
        Random rand_1;
        Random rand_2;
        public GlassFilter()
        {
            rand_1 = new Random(1942352);
            rand_2 = new Random(4352347);
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int r1 = rand_1.Next(5);
            int r2 = rand_2.Next(5);

            int xR = Convert.ToInt32(x + r1);
            int yR = Convert.ToInt32(y + r2);

            if (xR < 0)
                xR = x + 2;
            if (xR >= sourceImage.Width)
                xR = x - 2;
            if (yR < 0)
                yR = y + 2;
            if (yR >= sourceImage.Height)
                yR = y - 2;


            Color sourceColor = sourceImage.GetPixel(xR, yR);
            Color resultColor = Color.FromArgb(sourceColor.R, sourceColor.G, sourceColor.B);
            return resultColor;
        }
    }

}
