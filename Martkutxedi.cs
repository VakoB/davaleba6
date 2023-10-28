namespace დავალება6
{
    class Martkutxedi
    {
        static int side_1, side_2;
        public int perimeter;
        public Martkutxedi(int par_1, int par_2)
        {
            side_1 = par_1;
            side_2 = par_2;
        }
        private void Chveulebrivi()
        {
            perimeter = 2 * (side_1 + side_2);
        }
        public static void Statikuri(Martkutxedi obj_1)
        {
            obj_1.Chveulebrivi();
        }
    }
}