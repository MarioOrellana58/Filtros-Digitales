using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrosDigitales_1020618.ExtraClasses
{
    public class MainClass
    {
        public Image ImageOperations(Image originalPicture, double[,] filterMatrix, string imageFormat)
        {
            var process = new ImageProcessing();

            var stream = new MemoryStream();
            var format = imageFormat == "jpg" ? ImageFormat.Jpeg : ImageFormat.Png;
            originalPicture.Save(stream, format);
            stream.Position = 0;


            var greyscaleImage = process.ConvertToGrayScale(stream);
            var output = process.ApplyImageFilter(greyscaleImage, filterMatrix);
            return null;
        }
    }
}
