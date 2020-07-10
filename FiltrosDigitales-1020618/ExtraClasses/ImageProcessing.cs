using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace FiltrosDigitales_1020618
{
    public class ImageProcessing
    {
        public Bitmap ConvertToGrayScale(Stream ColorImage)
        {
            //Code source: https://web.archive.org/web/20130111215043/http://www.switchonthecode.com/tutorials/csharp-tutorial-convert-a-color-image-to-grayscale

            var original = new Bitmap(ColorImage);
            //create a blank bitmap the same size as original
            var newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            using (Graphics g = Graphics.FromImage(newBitmap))
            {

                //create the grayscale ColorMatrix
                var colorMatrix = new ColorMatrix(
                   new float[][]
                   {
                         new float[] {.3f, .3f, .3f, 0, 0},
                         new float[] {.59f, .59f, .59f, 0, 0},
                         new float[] {.11f, .11f, .11f, 0, 0},
                         new float[] {0, 0, 0, 1, 0},
                         new float[] {0, 0, 0, 0, 1}
                   });

                //create some image attributes
                using (ImageAttributes attributes = new ImageAttributes())
                {

                    //set the color matrix attribute
                    attributes.SetColorMatrix(colorMatrix);

                    //draw the original image on the new image
                    //using the grayscale color matrix
                    g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                                0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
                }
            }
            return newBitmap;
        }

        public Bitmap ApplyImageFilter(Bitmap grayscaleImage, double[,] filter)
        {
            var outputImage = new Bitmap(grayscaleImage.Width,grayscaleImage.Height);
            var calculate = new Calculator();
            for (int i = 0; i+2 < grayscaleImage.Width; i++)
            {
                for (int j = 0; j+2 < grayscaleImage.Height; j++)
                {
                    var imageRegionRed = new double[,] {
                            { Convert.ToDouble(grayscaleImage.GetPixel(i,j).R), Convert.ToDouble(grayscaleImage.GetPixel(i,j+1).R), Convert.ToDouble(grayscaleImage.GetPixel(i,j+2).R)},
                            { Convert.ToDouble(grayscaleImage.GetPixel(i+1,j).R), Convert.ToDouble(grayscaleImage.GetPixel(i+1,j+1).R), Convert.ToDouble(grayscaleImage.GetPixel(i+1,j+2).R)},
                            { Convert.ToDouble(grayscaleImage.GetPixel(i+2,j).R), Convert.ToDouble(grayscaleImage.GetPixel(i+2,j+1).R), Convert.ToDouble(grayscaleImage.GetPixel(i+2,j+2).R)}
                        };

                    
                    var newRedPixel = calculate.StandardizeResult(calculate.SumAll(calculate.MatrixMultiplication(imageRegionRed, filter)));

                    var imageRegionGreen = new double[,] {
                            { Convert.ToDouble(grayscaleImage.GetPixel(i,j).G), Convert.ToDouble(grayscaleImage.GetPixel(i,j+1).G), Convert.ToDouble(grayscaleImage.GetPixel(i,j+2).G)},
                            { Convert.ToDouble(grayscaleImage.GetPixel(i+1,j).G), Convert.ToDouble(grayscaleImage.GetPixel(i+1,j+1).G), Convert.ToDouble(grayscaleImage.GetPixel(i+1,j+2).G)},
                            { Convert.ToDouble(grayscaleImage.GetPixel(i+2,j).G), Convert.ToDouble(grayscaleImage.GetPixel(i+2,j+1).G), Convert.ToDouble(grayscaleImage.GetPixel(i+2,j+2).G)}
                        };

                    var newGreenPixel = calculate.StandardizeResult(calculate.SumAll(calculate.MatrixMultiplication(imageRegionGreen, filter)));

                    var imageRegionBlue = new double[,] {
                            { Convert.ToDouble(grayscaleImage.GetPixel(i,j).B), Convert.ToDouble(grayscaleImage.GetPixel(i,j+1).B), Convert.ToDouble(grayscaleImage.GetPixel(i,j+2).B)},
                            { Convert.ToDouble(grayscaleImage.GetPixel(i+1,j).B), Convert.ToDouble(grayscaleImage.GetPixel(i+1,j+1).B), Convert.ToDouble(grayscaleImage.GetPixel(i+1,j+2).B)},
                            { Convert.ToDouble(grayscaleImage.GetPixel(i+2,j).B), Convert.ToDouble(grayscaleImage.GetPixel(i+2,j+1).B), Convert.ToDouble(grayscaleImage.GetPixel(i+2,j+2).B)}
                        };

                    var newBluePixel = calculate.StandardizeResult(calculate.SumAll(calculate.MatrixMultiplication(imageRegionBlue, filter)));

                    outputImage.SetPixel(i+1, j+1, Color.FromArgb(newRedPixel, newGreenPixel, newBluePixel));
                }
            }

            for (int i = 0; i < grayscaleImage.Width; i++)
            {
                bool leftBorder = true;
                for (int j = 0; j < grayscaleImage.Height; j+= grayscaleImage.Height - 1 )
                {
                    if (i != 0 && i != grayscaleImage.Width-1)
                    {
                        if (leftBorder)
                        {
                            outputImage.SetPixel(i, j, Color.FromArgb(grayscaleImage.GetPixel(i, j).R, grayscaleImage.GetPixel(i, j).G, grayscaleImage.GetPixel(i, j).B));
                        }
                        else
                        {
                            outputImage.SetPixel(i, j, Color.FromArgb(grayscaleImage.GetPixel(i, j).R, grayscaleImage.GetPixel(i, j).G, grayscaleImage.GetPixel(i, j).B));
                        }
                    }
                    else
                    {
                        //hacer
                    }
                    leftBorder = false;
                }
            }

            return outputImage;
        }
    }
}
