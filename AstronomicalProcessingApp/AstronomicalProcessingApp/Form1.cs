namespace AstronomicalProcessingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RdmFill();
            UpdateDisplay();
        }
        // Global Variables
        static int arraySize = 24;
        int[] neutInteractions = new int[arraySize];

        // Method fills array with 24 random numbers using random object

        void RdmFill()
        {
            Random random = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                neutInteractions[i] = random.Next(10, 99);
            }

        }

        // Clears listBoxDisplay and then writes neutInteractions array to listBoxDisplay

        void UpdateDisplay()
        {
            listBoxDisplay.Items.Clear();
            for (int i = 0; i < arraySize; i++)
            {

                listBoxDisplay.Items.Add(neutInteractions[i]);
            }
        }
        // test
        // Binary Search Method on button click
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int mid;
            int max = arraySize - 1;
            int min = 0;
            if (Int32.TryParse(textBoxInput.Text, out int key))
            {
                while (min <= max)
                {
                    mid = (min + max) / 2;
                    if (neutInteractions[mid] == key)
                    {
                        MessageBox.Show("Search result found", "Search Result");
                        break;
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
                MessageBox.Show("Search Value Not Found", "Search Result");
            }
            else
            {
                // ERROR MESSAGE HERE
            }
        }
        // Parses user input from textBoxInput to integer. Check if is integer and checks if it is not white space.
        // Using listBox index value, replaces corresponding value in the array with parsed input from user then updates the array.
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string text = textBoxInput.Text;

            if (listBoxDisplay.SelectedIndex != -1)
            {
                if (Int32.TryParse(text, out int input) && !(String.IsNullOrWhiteSpace(text)))
                {
                    int k = listBoxDisplay.SelectedIndex;

                    neutInteractions[k] = input;
                    UpdateDisplay();
                }
                else
                {
                    listBoxDisplay.ClearSelected();
                    textBoxInput.Clear();
                }


            }
        }

        private void listBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDisplay.SelectedIndex != -1)
            {
                textBoxInput.Text = neutInteractions[listBoxDisplay.SelectedIndex].ToString();
            }
            else
            {
                listBoxDisplay.ClearSelected();
                textBoxInput.Clear();
            }
        }
    }
}