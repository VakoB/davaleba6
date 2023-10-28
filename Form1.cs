namespace დავალება6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            int chveulebrivi = int.Parse(textBox1.Text);
            int statikuri = int.Parse(textBox2.Text);
            Class1 class1 = new Class1();
            int cvladi = Class1.Statikuri(class1, chveulebrivi, statikuri);
            label7.Text = "ცვლადების ჯამი: " + cvladi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            int side_1 = int.Parse(textBox3.Text);
            int side_2 = int.Parse(textBox4.Text);
            Martkutxedi martkutxedi = new Martkutxedi(side_1, side_2);
            Martkutxedi.Statikuri(martkutxedi);
            label7.Text = "პერიმეტრი: " + martkutxedi.perimeter;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            int[] arr = { 2, 3, 4, 5, 6, 67, 78, 33 };
            Klasi_1 klasi_1 = new Klasi_1(arr);
            int jami = Klasi_1.Statikuri(klasi_1);
            label7.Text = "ჯამი 1D: " + jami;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            int[,] arr = { { 1, 2, 3 }, { 3, 6, 2, }, { 3, 5, 7 } };
            Klasi_2 klasi_2 = new Klasi_2(arr);
            label7.Text = "ჯამი 2D: " + Klasi_2.Statikuri(klasi_2);
        }   
    }
}