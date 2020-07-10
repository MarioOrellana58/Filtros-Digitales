using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrosDigitales_1020618
{
    public class Filters
    {
        public double[,] GetDefinedMatrix(int comboBoxIndex)
        {
            switch (comboBoxIndex)
            {
                case 0:
                    //blurred
                    return new double[,]
                                {
                                     { 0.0625, 0.125, 0.0625 } ,
                                     { 0.125 , 0.25 , 0.125  } ,
                                     { 0.0625, 0.125, 0.0625 } 
                                };
                case 1:
                    //enhance
                    return new double[,]
                                {
                                     { -2, -1, 0 } ,
                                     { -1,  1, 1 } ,
                                     {  0,  1, 2 } 
                                };
                case 2:
                    //lower sobel
                    return new double[,]
                                {
                                     { -1, -2, -1 } ,
                                     {  0,  0,  0 } ,
                                     {  1,  2,  1 }
                                };
                case 3:
                    //upper sobel
                    return new double[,]
                                {
                                     {  1,  2,  1 } ,
                                     {  0,  0,  0 } ,
                                     { -1, -2, -1 }
                                };
                case 4:
                    //left sobel
                    return new double[,]
                                {
                                     { 1, 0, -1 } ,
                                     { 2, 0, -2 } ,
                                     { 1, 0, -1 }
                                };
                case 5:
                    //right sobel
                    return new double[,]
                                {
                                     { -1, 0, 1 } ,
                                     { -2, 0, 2 } ,
                                     { -1, 0, 1 }
                                };
                case 6:
                    //outline
                    return new double[,]
                                {
                                     { -1, -1, -1 } ,
                                     { -1,  8, -1 } ,
                                     { -1, -1, -1 }
                                };
                case 7:
                    //sharpen
                    return new double[,]
                                {
                                     {  0, -1,  0 } ,
                                     { -1,  5, -1 } ,
                                     {  0, -1,  0 }
                                };
                case 8:
                    //original
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
