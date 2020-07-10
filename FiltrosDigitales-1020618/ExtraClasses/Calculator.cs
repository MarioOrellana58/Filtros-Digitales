using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrosDigitales_1020618
{
    public class Calculator
    {
        /*
         * Methods are not generic.
         * I did it this way because it's way more efficient to work
         * with a defined matrix dimension instead of making generic
         * methods, this would rise code complexity.
         */

        public double[,] MatrixMultiplication(double[,] imagePortion, double[,] filter)
        {
            return new double[,]
                            {
                                { imagePortion[0,0]*filter[0,0], imagePortion[0,1]*filter[0,1], imagePortion[0,2]*filter[0,2] },
                                { imagePortion[1,0]*filter[1,0], imagePortion[1,1]*filter[1,1], imagePortion[1,2]*filter[1,2] },
                                { imagePortion[2,0]*filter[2,0], imagePortion[2,1]*filter[2,1], imagePortion[2,2]*filter[2,2] }
                            };            
        }

        public double SumAll(double[,] matrix)
        {
            return matrix[0, 0] + matrix[0, 1] + matrix[0, 2] +
                   matrix[0, 0] + matrix[0, 1] + matrix[0, 2] +
                   matrix[0, 0] + matrix[0, 1] + matrix[0, 2];
        }

        public double StandardizeResult(double notStandardizedResult)
        {
            if (notStandardizedResult < 0)
            {
                return 0;
            }
            else if (notStandardizedResult > 200)
            {
                return 200;
            }
            else
            {
                if (notStandardizedResult % 1 != 0)
                {
                    return Math.Round(notStandardizedResult);
                }
                else
                {
                    //it's already standardized
                    return notStandardizedResult;
                }
            }
        }
    }
}
