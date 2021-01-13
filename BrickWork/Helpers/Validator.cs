using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickWork
{
    class Validator
    {
         static string NO_SOLUTION = "-1; There is no solution to your problem.";

        public static bool isValid(int[] dimensions) //Make sure input numbers are EVEN or less than 100.
        {
            return dimensions[0] % 2 == 0 && dimensions[1] % 2 == 0
                    && dimensions[0] < 100 && dimensions[1] < 100;
        }


        public static void CheckForThreeColAndRow(int[,] matrix) //Validate there are no bricks spanning 3 rows/ columns.
        {
            for (int row = 0; row <= matrix.GetLength(0) - 2; row += 3)
            {
                for (int col = 0; col <= matrix.GetLength(1) - 3; col += 3)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row, col + 1] == matrix[row, col + 2])
                    {
                        throw new Exception(NO_SOLUTION);
                    }
                    if (matrix.GetLength(0) > 2)
                    {
                        if (matrix[row, col] == matrix[row + 1, col] &&
                          matrix[row + 1, col] == matrix[row + 2, col])
                        {
                            throw new Exception(NO_SOLUTION);
                        }
                    }
                }
            }
        }
    }
}
