namespace AstronomicalProcessingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int arraySize = 24;
        int[] neutInteractions = new int[arraySize];

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int mid;
            int max = arraySize - 1;
            int min = 0; 
            int key = 0;

            while (min <= max)
            {
                mid = (min + max) / 2;
                if (neutInteractions[mid] == key)
                {
                    return;
                }
                else if (neutInteractions[mid] < key)
                {
                    min = mid++;
                }
                else
                {
                    max = mid--;
                }
            }
        }
    }
}