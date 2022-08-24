using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ArrayTest();
        }

        private void ArrayTest()
        {
            //int iDay1 = 0;
            //int iDay2 = 0;
            //int iDay3 = 0;

            //string strT1 = "가,나,다,라";
            //string[] strTEST = strT1.Split(',');
            //string[] strTESTArray = { "가", "나", "다", "라" };

            int[] iArrayTest1 = { 1, 2, 3, 4, 5 };

            int[] iArrayTest2 = new int[5] { 1, 2, 3, 4, 5 };

            int[] iArrayTest3 = new int[5];
            iArrayTest3[2] = 3;
            iArrayTest3[4] = 5;

            int[,] ArrayTest4 = new int[2, 4] { { 1, 2, 3, 4 }, { 10, 20, 30, 40 } };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgDay.Rows.Clear();

            int[] iTest = { 10, 5, 30, 4, 15, 22, 18 };

            dgDay["colDay1", 0].Value = iTest[0];
            dgDay["colDay2", 0].Value = iTest[1];
            dgDay["colDay3", 0].Value = iTest[2];
            dgDay["colDay4", 0].Value = iTest[3];
            dgDay["colDay5", 0].Value = iTest[4];
            dgDay["colDay6", 0].Value = iTest[5];
            dgDay["colDay7", 0].Value = iTest[6];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgDay.Rows.Clear();

            int[,] iTest = { { 10, 5, 30, 4, 15, 22, 18 }, { 11, 15, 25, 14, 7, 5, 25 } };

            dgDay.Rows.Add();

            dgDay["colDay1", 0].Value = iTest[0, 0];
            dgDay["colDay2", 0].Value = iTest[0, 1];
            dgDay["colDay3", 0].Value = iTest[0, 2];
            dgDay["colDay4", 0].Value = iTest[0, 3];
            dgDay["colDay5", 0].Value = iTest[0, 4];
            dgDay["colDay6", 0].Value = iTest[0, 5];
            dgDay["colDay7", 0].Value = iTest[0, 6];

            dgDay["colDay1", 0].Value = iTest[1, 0];
            dgDay["colDay2", 0].Value = iTest[1, 1];
            dgDay["colDay3", 0].Value = iTest[1, 2];
            dgDay["colDay4", 0].Value = iTest[1, 3];
            dgDay["colDay5", 0].Value = iTest[1, 4];
            dgDay["colDay6", 0].Value = iTest[1, 5];
            dgDay["colDay7", 0].Value = iTest[1, 6];
        }
    }
}