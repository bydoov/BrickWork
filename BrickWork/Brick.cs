using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickWork
{
    class Brick
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int[,] Matrix { get; set; }

        public Brick(int row, int col) //Constructor
        {
            this.Row = row;
            this.Col = col;
            this.Matrix = new int[row, col];

            CreateFirstLayer();
        }


        private void CreateFirstLayer() //Read the input from console to create first layer.
        {
            for (int i = 0; i < Row; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < Col; j++)
                {
                    Matrix[i, j] = input[j];
                }
            }
        }
    }
}
