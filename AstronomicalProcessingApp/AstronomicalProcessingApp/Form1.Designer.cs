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
            button1 = new Button();
            buttonAverage = new Button();
            buttonMode = new Button();
            buttonMidExtreme = new Button();
            buttonRange = new Button();
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(195, 12);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(107, 29);
            buttonSearch.TabIndex = 0;
            buttonSearch.Text = "Binary Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(195, 87);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(107, 29);
            buttonSort.TabIndex = 1;
            buttonSort.Text = "Sort";
            buttonSort.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(308, 31);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 31);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(177, 27);
            textBoxInput.TabIndex = 3;
            // 
            // listBoxDisplay
            // 
            listBoxDisplay.FormattingEnabled = true;
            listBoxDisplay.ItemHeight = 20;
            listBoxDisplay.Location = new Point(12, 84);
            listBoxDisplay.Name = "listBoxDisplay";
            listBoxDisplay.Size = new Size(177, 324);
            listBoxDisplay.TabIndex = 4;
            listBoxDisplay.SelectedIndexChanged += listBoxDisplay_SelectedIndexChanged;
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(193, 381);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.ReadOnly = true;
            textBoxMessage.Size = new Size(177, 27);
            textBoxMessage.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 6;
            label1.Text = "Input Box";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 7;
            label2.Text = "Neutrino Interactions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 358);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 8;
            label3.Text = "User Feeback";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(195, 189);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(207, 27);
            textBoxResult.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 166);
            label4.Name = "label4";
            label4.Size = new Size(159, 20);
            label4.TabIndex = 10;
            label4.Text = "Data Processing Result";
            // 
            // button1
            // 
            button1.Location = new Point(195, 47);
            button1.Name = "button1";
            button1.Size = new Size(107, 29);
            button1.TabIndex = 11;
            button1.Text = "Linear Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonAverage
            // 
            buttonAverage.Location = new Point(195, 222);
            buttonAverage.Name = "buttonAverage";
            buttonAverage.Size = new Size(94, 29);
            buttonAverage.TabIndex = 12;
            buttonAverage.Text = "Average";
            buttonAverage.UseVisualStyleBackColor = true;
            // 
            // buttonMode
            // 
            buttonMode.Location = new Point(295, 222);
            buttonMode.Name = "buttonMode";
            buttonMode.Size = new Size(103, 29);
            buttonMode.TabIndex = 13;
            buttonMode.Text = "Mode";
            buttonMode.UseVisualStyleBackColor = true;
            // 
            // buttonMidExtreme
            // 
            buttonMidExtreme.Location = new Point(295, 257);
            buttonMidExtreme.Name = "buttonMidExtreme";
            buttonMidExtreme.Size = new Size(103, 29);
            buttonMidExtreme.TabIndex = 14;
            buttonMidExtreme.Text = "Mid-Extreme";
            buttonMidExtreme.UseVisualStyleBackColor = true;
            // 
            // buttonRange
            // 
            buttonRange.Location = new Point(195, 257);
            buttonRange.Name = "buttonRange";
            buttonRange.Size = new Size(94, 29);
            buttonRange.TabIndex = 15;
            buttonRange.Text = "Range";
            buttonRange.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 422);
            Controls.Add(buttonRange);
            Controls.Add(buttonMidExtreme);
            Controls.Add(buttonMode);
            Controls.Add(buttonAverage);
            Controls.Add(button1);
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
        private Button button1;
        private Button buttonAverage;
        private Button buttonMode;
        private Button buttonMidExtreme;
        private Button buttonRange;
    }
}