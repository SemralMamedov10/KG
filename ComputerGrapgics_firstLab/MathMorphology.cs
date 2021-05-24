using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics_firstLab
{
    class MathMorphology : Filters
    {
        protected int[,] kernel; 

        protected MathMorphology() { }
        public MathMorphology(int[,] kernel)
        {
            this.kernel = kernel;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            throw new NotImplementedException();
        }
    }
}
