namespace AstronomicalProcessingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSearch = new Button();
            buttonSort = new Button();
            buttonEdit = new Button();
            textBoxInput = new TextBox();
            listBoxDisplay = new ListBox();
            textBoxMessage = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxResult = new TextBox();
            label4 = new Label();
            buttonLinearSearch = new Button();
            buttonAverage = new Button();
            buttonMode = new Button();
            buttonMidExtreme = new Button();
            buttonRange = new Button();
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(171, 9);
            buttonSearch.Margin = new Padding(3, 2, 3, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 22);
            buttonSearch.TabIndex = 0;
            buttonSearch.Text = "Binary Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(171, 65);
            buttonSort.Margin = new Padding(3, 2, 3, 2);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(94, 22);
            buttonSort.TabIndex = 1;
            buttonSort.Text = "Sort";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(270, 23);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(82, 22);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(10, 23);
            textBoxInput.Margin = new Padding(3, 2, 3, 2);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(155, 23);
            textBoxInput.TabIndex = 3;
            // 
            // listBoxDisplay
            // 
            listBoxDisplay.FormattingEnabled = true;
            listBoxDisplay.ItemHeight = 15;
            listBoxDisplay.Location = new Point(10, 63);
            listBoxDisplay.Margin = new Padding(3, 2, 3, 2);
            listBoxDisplay.Name = "listBoxDisplay";
            listBoxDisplay.Size = new Size(155, 244);
            listBoxDisplay.TabIndex = 4;
            listBoxDisplay.SelectedIndexChanged += listBoxDisplay_SelectedIndexChanged;
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(169, 286);
            textBoxMessage.Margin = new Padding(3, 2, 3, 2);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.ReadOnly = true;
            textBoxMessage.Size = new Size(155, 23);
            textBoxMessage.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 6);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 6;
            label1.Text = "Input Box";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 46);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 7;
            label2.Text = "Neutrino Interactions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 268);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 8;
            label3.Text = "User Feeback";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(171, 142);
            textBoxResult.Margin = new Padding(3, 2, 3, 2);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(182, 23);
            textBoxResult.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 124);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 10;
            label4.Text = "Data Processing Result";
            // 
            // buttonLinearSearch
            // 
            buttonLinearSearch.Location = new Point(171, 35);
            buttonLinearSearch.Margin = new Padding(3, 2, 3, 2);
            buttonLinearSearch.Name = "buttonLinearSearch";
            buttonLinearSearch.Size = new Size(94, 22);
            buttonLinearSearch.TabIndex = 11;
            buttonLinearSearch.Text = "Linear Search";
            buttonLinearSearch.UseVisualStyleBackColor = true;
            buttonLinearSearch.Click += buttonLinearSearch_Click;
            // 
            // buttonAverage
            // 
            buttonAverage.Location = new Point(171, 166);
            buttonAverage.Margin = new Padding(3, 2, 3, 2);
            buttonAverage.Name = "buttonAverage";
            buttonAverage.Size = new Size(82, 22);
            buttonAverage.TabIndex = 12;
            buttonAverage.Text = "Average";
            buttonAverage.UseVisualStyleBackColor = true;
            // 
            // buttonMode
            // 
            buttonMode.Location = new Point(258, 166);
            buttonMode.Margin = new Padding(3, 2, 3, 2);
            buttonMode.Name = "buttonMode";
            buttonMode.Size = new Size(90, 22);
            buttonMode.TabIndex = 13;
            buttonMode.Text = "Mode";
            buttonMode.UseVisualStyleBackColor = true;
            buttonMode.Click += buttonMode_Click;
            // 
            // buttonMidExtreme
            // 
            buttonMidExtreme.Location = new Point(258, 193);
            buttonMidExtreme.Margin = new Padding(3, 2, 3, 2);
            buttonMidExtreme.Name = "buttonMidExtreme";
            buttonMidExtreme.Size = new Size(90, 22);
            buttonMidExtreme.TabIndex = 14;
            buttonMidExtreme.Text = "Mid-Extreme";
            buttonMidExtreme.UseVisualStyleBackColor = true;
            buttonMidExtreme.Click += buttonMidExtreme_Click;
            // 
            // buttonRange
            // 
            buttonRange.Location = new Point(171, 193);
            buttonRange.Margin = new Padding(3, 2, 3, 2);
            buttonRange.Name = "buttonRange";
            buttonRange.Size = new Size(82, 22);
            buttonRange.TabIndex = 15;
            buttonRange.Text = "Range";
            buttonRange.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 316);
            Controls.Add(buttonRange);
            Controls.Add(buttonMidExtreme);
            Controls.Add(buttonMode);
            Controls.Add(buttonAverage);
            Controls.Add(buttonLinearSearch);
            Controls.Add(label4);
            Controls.Add(textBoxResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxMessage);
            Controls.Add(listBoxDisplay);
            Controls.Add(textBoxInput);
            Controls.Add(buttonEdit);
            Controls.Add(buttonSort);
            Controls.Add(buttonSearch);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Astronomical Processing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSearch;
        private Button buttonSort;
        private Button buttonEdit;
        private TextBox textBoxInput;
        private ListBox listBoxDisplay;
        private TextBox textBoxMessage;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxResult;
        private Label label4;
        private Button buttonLinearSearch;
        private Button buttonAverage;
        private Button buttonMode;
        private Button buttonMidExtreme;
        private Button buttonRange;
    }
}