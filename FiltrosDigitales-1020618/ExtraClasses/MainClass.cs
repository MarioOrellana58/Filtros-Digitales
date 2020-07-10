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
        public Image ImageOperations(Image originalPicture, double[,] filterMatrix)
        {

            //get image format
            var imgguid = originalPicture.RawFormat.Guid;
            var rawformat = string.Empty;
            foreach (ImageCodecInfo codec in ImageCodecInfo.GetImageDecoders())
            {
                if (codec.FormatID == imgguid)
                    rawformat = codec.MimeType;
            }
            var format = rawformat.Contains("jpeg") ? ImageFormat.Jpeg : ImageFormat.Png;

            //open an stream for image
            var stream = new MemoryStream();
            originalPicture.Save(stream, format);
            stream.Position = 0;

            var process = new ImageProcessing();
            var greyscaleImage = process.ConvertToGrayScale(stream);

            var output = (Image)process.ApplyImageFilter(greyscaleImage, filterMatrix);

            return output;
        }
    }
}
