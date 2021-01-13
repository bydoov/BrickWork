using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickWork
{
    class InputHandler
    {
        public static int[] Read()
        {
            return Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
        }
    }
}
