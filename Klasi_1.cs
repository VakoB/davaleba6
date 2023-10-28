using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace დავალება6
{
    internal class Klasi_1
    {
        int[] arr;
        public Klasi_1(int[] arr)
        {
            this.arr = arr;
        }
        private int Chveulebrivi()
        {
            int jami = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    jami = jami + arr[i];
                }
                else
                {
                    jami = jami;
                }  
            }
            return jami;
        }
        public static int Statikuri(Klasi_1 obj_1)
        {
            return obj_1.Chveulebrivi();
        }
    }
}
