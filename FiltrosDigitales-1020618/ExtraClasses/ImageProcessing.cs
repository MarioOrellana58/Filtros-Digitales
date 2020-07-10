﻿using System;
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
            for (int i = 0; i <= grayscaleImage.Width+2; i++)
            {
                for (int j = 0; j <= grayscaleImage.Height+2; j++)
                {                    
                    var imageRegion = new double[,] {
                            { Convert.ToDouble(grayscaleImage.GetPixel(i,j)), Convert.ToDouble(grayscaleImage.GetPixel(i,j+1)), Convert.ToDouble(grayscaleImage.GetPixel(i,j+2))},
                            { Convert.ToDouble(grayscaleImage.GetPixel(i+1,j)), Convert.ToDouble(grayscaleImage.GetPixel(i+1,j+1)), Convert.ToDouble(grayscaleImage.GetPixel(i+1,j+2))},
                            { Convert.ToDouble(grayscaleImage.GetPixel(i+2,j)), Convert.ToDouble(grayscaleImage.GetPixel(i+2,j+1)), Convert.ToDouble(grayscaleImage.GetPixel(i+2,j+2))}
                        };

                    var newPixel = calculate.StandardizeResult(calculate.SumAll(calculate.MatrixMultiplication(imageRegion, filter)));                   

                    
                    outputImage.SetPixel(i+1, j+1, Color.FromArgb(newPixel) );
                }
            }

            return outputImage;
        }
    }
}