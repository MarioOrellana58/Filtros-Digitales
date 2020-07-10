using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrosDigitales_1020618
{
    public class Arrays
    {
        public double[,] GetDefinedMatrix(string filterName)
        {
            switch (filterName)
            {
                case "blurred":
                    return new double[,]
                                {
                                     { 0.0625, 0.125, 0.0625 } ,
                                     { 0.125 , 0.25 , 0.125  } ,
                                     { 0.0625, 0.125, 0.0625 } 
                                };
                case "enhance":
                    return new double[,]
                                {
                                     { -2, -1, 0 } ,
                                     { -1,  1, 1 } ,
                                     {  0,  1, 2 } 
                                };
                case "lower sobel":
                    return new double[,]
                                {
                                     { -1, -2, -1 } ,
                                     {  0,  0,  0 } ,
                                     {  1,  2,  1 }
                                };
                case "upper sobel":
                    return new double[,]
                                {
                                     {  1,  2,  1 } ,
                                     {  0,  0,  0 } ,
                                     { -1, -2, -1 }
                                };
                case "left sobel":
                    return new double[,]
                                {
                                     { 1, 0, -1 } ,
                                     { 2, 0, -2 } ,
                                     { 1, 0, -1 }
                                };
                case "right sobel":
                    return new double[,]
                                {
                                     { -1, 0, 1 } ,
                                     { -2, 0, 2 } ,
                                     { -1, 0, 1 }
                                };
                case "outline":
                    return new double[,]
                                {
                                     { -1, -1, -1 } ,
                                     { -1,  8, -1 } ,
                                     { -1, -1, -1 }
                                };
                case "sharpen":
                    return new double[,]
                                {
                                     {  0, -1,  0 } ,
                                     { -1,  5, -1 } ,
                                     {  0, -1,  0 }
                                };
                case "original":
                    return new double[,]
                                {
                                     { 0, 0, 0 } ,
                                     { 0, 1, 0 } ,
                                     { 0, 0, 0 }
                                };
                default:
                    break;
            }
            return null;
        }
    }
}
