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
                        textBoxMessage.Text = (key + " Found!");
                        break;
                    }
                    else if (neutInteractions[mid] < key)
                    {
                        min = mid + 1;
                    }
                    else if (neutInteractions[mid] > key)
                    {
                        max = mid - 1;
                    }
                    textBoxMessage.Text = (key + " Not Found!");
                }
            }
            else
            {
                textBoxMessage.Text = ("Invalid Input");
            }
        }
        // Edit Button
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
                    textBoxInput.Clear();
                    textBoxInput.Clear();
                }
                else
                {
                    textBoxMessage.Text = ("Invalid Change!");
                    listBoxDisplay.ClearSelected();
                    textBoxInput.Clear();
                }
            }
        }
        // Upon selecting value from list box, display it in the input box
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

        //
        // Mode Button
        // Double Foreach loop:
        // The first one gives the target value
        // The second gives the comparing value
        // For each Target value, we will iterate through the array for comparing values
        // Each time the comparing number matches the target, increase the count by 1
        // After comparing each of the numbers once, if the count exceeds the maxcount, we will clear a list add that value to the list
        // if that value had the same count as the max count, we will just add the value to the list instead.
        // Lastly, we will use a for loop to display the results in a readable format.
        //
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
        // Mid-Extreme Buton
        // Iterates through each value of array,
        // Sets a new min or max if the number compared to it is lower/higher for that loop,
        // Calculates average of max and min (the mid extreme),
        // Displays result in textBoxResult
        private void buttonMidExtreme_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            int max = neutInteractions[0];
            int min = neutInteractions[0];
            double mid;
            foreach (int i in neutInteractions)
            {
                if (i < min)
                {
                    min = i;
                }
                else if (i > max)
                {
                    max = i;
                }
            }
            mid = (max + min) / 2.0; // Must have a double in calculation to get double result.
            textBoxResult.Text = mid.ToString();
        }
        // Linear search
        // Checks if the key is a valid integer,
        // loops through each value of the array,
        // compares each value to the key,
        // returns message if key matches result, and if it doesnt.
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
                textBoxMessage.Text = (textBoxInput.Text + " Found in Array!");
            }
            else
            {
                textBoxMessage.Text = (textBoxInput.Text + " Not Found in Array!");
            }

        }
        // Sort Button
        // Sorts neutrino interactions in assending order on button press.
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

        private void buttonAverage_Click(object sender, EventArgs e)
        {

        }

        private void buttonRange_Click(object sender, EventArgs e)
        {

        }
        //
        // Below here is all the tool tips for each GUI element. Move your code above it for the sake of readability.
        // The @ symbol just makes the string a literal, it reads each character as it is (i.e. each new line is a new line for the tooltip)
        //
        private void textBoxInput_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(
                @"Input a number you would like to search for here.
or
Select an entry and edit it here to chage the number.", textBoxInput);
        }

        private void buttonBinarySearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(
                @"Binary searches the array of numbers using the number in the input box as the key.
The search will tell you if number exists in array.", buttonBinarySearch);
        }

        private void buttonLinearSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(
                @"Sequentially searches the array of numbers using the number in the input box as the key.
The search will tell you if number exists in array.", buttonLinearSearch);
        }

        private void buttonEdit_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(
                @"Select a piece of data you would like to change from the list of neutrino interactions,
change the data in to the desired value in the input text box,
press the edit button to submit the changes to the array.", buttonEdit);
        }

        private void buttonSort_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Sorts the data in assending order upon button press.", buttonSort);
        }

        private void listBoxDisplay_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(
                @"Displays neutrino information data.
Click on a value to select it.", listBoxDisplay);
        }

        private void textBoxResult_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Result of mathematical opperations will appear here", textBoxResult);
        }

        private void buttonAverage_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(
                @"Calculates average neutrino interaction pre hour
Equation:
Sum of interactions/24", buttonAverage);
        }

        private void buttonMode_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(@"Calculates the mode number of neutrino interactions from the day", buttonMode);
        }

        private void buttonRange_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(
                @"Calculates the range of neutrino interactions
Equation:
Max interactions - Min interactions", buttonRange);
        }

        private void buttonMidExtreme_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(
                @"Calculates the midpoint of the two most extreme numbers
Equation:
(Max interactions + Min interactions)/2", buttonMidExtreme);
        }

        private void textBoxMessage_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Each action/error will display a message here", textBoxMessage);
        }


    }
}