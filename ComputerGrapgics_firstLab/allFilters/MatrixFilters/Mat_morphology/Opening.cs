using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics_firstLab.allFilters.MatrixFilters.Mat_morphology
{
    class Opening : MathMorphology 
    {
        int size;
        public Opening(int size_)
        {
            size = size_;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = sourceImage;
            Filters filter = new Erosion(size);
            resultImage = filter.processImage(resultImage, worker);
            filter = new Dilation(size);
            resultImage = filter.processImage(resultImage, worker);
            return resultImage;
        }
    }
}
