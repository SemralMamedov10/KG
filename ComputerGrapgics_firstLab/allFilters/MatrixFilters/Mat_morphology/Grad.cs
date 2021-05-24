using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics_firstLab.allFilters.MatrixFilters.Mat_morphology
{
    class Grad : MathMorphology
    {
        int size;
        public Grad(int size_)
        {
            size = size_;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = sourceImage;
            Bitmap tmpDilation = sourceImage;
            Bitmap tmpErosion = sourceImage;

            Filters filter = new Dilation(size);
            tmpDilation = filter.processImage(tmpDilation, worker);

            filter = new Erosion(size);
            tmpErosion = filter.processImage(tmpErosion, worker);

            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    int r = Clamp(tmpDilation.GetPixel(i, j).R - tmpErosion.GetPixel(i, j).R, 0, 255);
                    int g = Clamp(tmpDilation.GetPixel(i, j).G - tmpErosion.GetPixel(i, j).G, 0, 255);
                    int b = Clamp(tmpDilation.GetPixel(i, j).B - tmpErosion.GetPixel(i, j).B, 0, 255);

                    resultImage.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            return resultImage;
        }
    }
}
