using System;

namespace AstronomicalProcessingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Winform initialise
            InitializeComponent();
            // Neutrino Data Initialise
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

        private void buttonMode_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            int maxCount = 0;
            List<int> modes = new List<int>();
            foreach (int i in neutInteractions)
            {
                int count = 0;
                foreach (int j in neutInteractions)
                {
                    if ((i == j))
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    modes.Clear();
                    modes.Add(i);
                }
                else if (count == maxCount && !modes.Contains(i))
                {
                    modes.Add(i);
                }
            }
            int length = modes.Count;
            for (int i = 0; i < length; i++)
            {
                textBoxResult.AppendText(modes[i].ToString());
                if (i != length - 1)
                {
                    textBoxResult.AppendText(", ");
                }
            }

        }

        private void buttonMidExtreme_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            int max = 0;
            int min = 100;
            double mid;
            foreach (int i in neutInteractions)
            {
                if (i <= min)
                {
                    min = i;
                }
                else if (i >= max)
                {
                    max = i;
                }
            }
            mid = (max + min) / 2;
            textBoxResult.Text = mid.ToString();
        }

        private void buttonLinearSearch_Click(object sender, EventArgs e)
        {
            bool itemFound = false;
            if (!String.IsNullOrWhiteSpace(textBoxInput.Text) && Int32.TryParse(textBoxInput.Text, out int key))
            {
                foreach (int i in neutInteractions)
                {
                    if (key == i)
                    {
                        itemFound = true;
                        break;
                    }
                }
            }
            if (itemFound)
            {
                MessageBox.Show("Search Successful - Number Found in Array", "Search Result", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Search Unsuccessful - Number Not Found in Array", "Search Result", MessageBoxButtons.OK);
            }

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            int max = arraySize;
            int temp;

            for (int pass = 0; pass < max - 1; pass++)
            {
                for (int index = 0; index < (max - pass - 1); index++)
                {
                    if (neutInteractions[index] > neutInteractions[index + 1])
                    {
                        temp = neutInteractions[index];
                        neutInteractions[index] = neutInteractions[index + 1];
                        neutInteractions[index + 1] = temp;
                    }
                }
            }
            UpdateDisplay();
        }
    }
}