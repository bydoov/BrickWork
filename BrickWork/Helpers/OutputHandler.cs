using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickWork
{
    class OutputHandler
    {
        // Validate matrix first.
        // Check if 2 vertical bricks are same.If is true then put 2 bricks horiznotaly representing brickNumber.
        // If the bricks are not vertical then they are horizonatal.If is true then put 2 bricks vertically representing brickNumber.
        
        private static int[,] CreateSecondLayout(int[,]matrix,int row,int col )
        {
            Validator.CheckForThreeColAndRow(matrix);

            int brickNumber = 1;

            for (int i = 0; i < row - 1; i += 2)
            {
                for (int j = 0; j < col - 1; j += 2)
                {
                    if (matrix[i, j] == matrix[i + 1, j] || matrix[i, j + 1] == matrix[i + 1, j + 1])
                    {
                        matrix[i, j] = brickNumber;
                        matrix[i, j + 1] = brickNumber;
                        brickNumber++;
                        matrix[i + 1, j] = brickNumber;
                        matrix[i + 1, j + 1] = brickNumber;
                        brickNumber++;
                    }
                    else
                    {
                        matrix[i, j] = brickNumber;
                        matrix[i + 1, j] = brickNumber;
                        brickNumber++;
                        matrix[i, j + 1] = brickNumber;
                        matrix[i + 1, j + 1] = brickNumber;
                        brickNumber++;
                    }
                }

            }

            return matrix;

        }


        public static void Print(int[,] matrix, int row, int col) //Create second layer and then print it with StringBuilder.
        {
            CreateSecondLayout(matrix,row,col);

            Console.WriteLine(string.Join("", Enumerable.Repeat('*', col * 4 + 1)));

            for (var i = 0; i < row; i++)
            {
                var rowSb = new StringBuilder();
                rowSb.Append('*');

                var spaceSb = new StringBuilder();
                spaceSb.Append('*');

                for (var j = 0; j < col; j++)
                {
                    rowSb.AppendFormat("{0,2}", matrix[i, j]);
                    rowSb.Append(" ");

                    if (j + 1 < col)
                    {
                        rowSb.Append(
                            matrix[i, j] == matrix[i, j + 1]
                                ? ' '
                                : '*');

                    }

                    if (i + 1 < row)
                    {
                        if (matrix[i, j] == matrix[i + 1, j])
                        {
                            spaceSb.Append("   *");
                        }
                        else
                        {
                            spaceSb.Append("****");
                        }
                    }
                }

                rowSb.Append('*');

                Console.WriteLine(rowSb.ToString());

                if (i + 1 < row)
                {
                    Console.WriteLine(spaceSb.ToString());
                }
            }

            Console.WriteLine(string.Join("", Enumerable.Repeat('*', col * 4 + 1)));
        }
    }
}
