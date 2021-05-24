using System;
using System.Drawing;

namespace ComputerGraphics_firstLab.allFilters.PointsFilters
{
    class RotateFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            // Пиксели которые мы получим
            int x_r;
            int y_r;         

            // Центр
            int x0 = sourceImage.Width / 2;
            int y0 = sourceImage.Height / 2;
            // Угол поворота
            double u = Math.PI / 6;

            // Формула

            x_r = Clamp((int)((x - x0) * Math.Cos(u) - (y - y0) * Math.Sin(u) + x0), 0, sourceImage.Width - 1);
            y_r = Clamp((int)((x - x0) * Math.Sin(u) + (y - y0) * Math.Cos(u) + y0), 0, sourceImage.Height - 1);

            Color sourceColor = sourceImage.GetPixel(x_r, y_r);

            return sourceColor;
        }
    }
}
