using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = InputHandler.Read(); //Width and Height of the Matrix.

            if (Validator.isValid(dimensions))
            {
                var row = dimensions[0];
                var col = dimensions[1];

                Brick brick = new Brick(row,col); //Make matrix object wiht input valuse.
                Console.WriteLine();

                OutputHandler.Print(brick.Matrix, brick.Row, brick.Col); //Print second layer.
            }
            else
            {
                throw new Exception("-1; N and M should define a valid area of less than 100 lines/ columns.");
            }
        }
    }
}
