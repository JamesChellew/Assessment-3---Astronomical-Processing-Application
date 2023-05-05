namespace AstronomicalProcessingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RdmFill();
        }
        static int arraySize = 24;
        int[] neutInteractions = new int[arraySize];

        void RdmFill()
        {
            Random random = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                neutInteractions[i] = random.Next(10, 99);
            }
            for (int i = 0; i < arraySize; i++)
            {
                listBoxDisplay.Items.Add(neutInteractions[i]);
            }
        }

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
        // Test
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxDisplay.SelectedIndex != -1)
            {
                textBoxInput.Text = neutInteractions[listBoxDisplay.SelectedIndex].ToString();
            }
        }

        private void listBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxInput.Text = neutInteractions[listBoxDisplay.SelectedIndex].ToString();
        }
    }
}