using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace დავალება6
{
    internal class Class1
    {
        private int chveulebrivi;
        private static int statikuri;
        public int Chveulebrivi(int par_1, int par_2)
        {
            chveulebrivi = par_1;
            statikuri = par_2;
            return chveulebrivi + statikuri;
        }
        public static int Statikuri(Class1 obj_1, int ricvi_1, int ricxvi_2)
        {
            return obj_1.Chveulebrivi(ricvi_1, ricxvi_2);
        }
    }
}
