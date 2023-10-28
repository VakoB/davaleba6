using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace დავალება6
{
    internal class Klasi_2
    {
        int[,] arr;
        public Klasi_2(int[,] arr)
        {
            this.arr = arr;
        }
        private int Chveulebrivi()
        {
            int jami = 0;
            for (int row = 0; row < arr.GetLength(0); row++)
                for (int col = 0; col < arr.GetLength(1); col++)
                    if (arr[row, col] % 2 == 1)
                    {
                        jami = jami + arr[row, col];
                    }
            return jami;
        }
        public static int Statikuri(Klasi_2 obj_1)
        {
            return obj_1.Chveulebrivi();
        }
        
    }
}
