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
            this.buttonBinarySearch = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLinearSearch = new System.Windows.Forms.Button();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.buttonMode = new System.Windows.Forms.Button();
            this.buttonMidExtreme = new System.Windows.Forms.Button();
            this.buttonRange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBinarySearch
            // 
            this.buttonBinarySearch.Location = new System.Drawing.Point(317, 19);
            this.buttonBinarySearch.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBinarySearch.Name = "buttonBinarySearch";
            this.buttonBinarySearch.Size = new System.Drawing.Size(174, 46);
            this.buttonBinarySearch.TabIndex = 0;
            this.buttonBinarySearch.Text = "Binary Search";
            this.buttonBinarySearch.UseVisualStyleBackColor = true;
            this.buttonBinarySearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(317, 139);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(174, 46);
            this.buttonSort.TabIndex = 1;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(500, 50);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(153, 46);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(20, 50);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(285, 39);
            this.textBoxInput.TabIndex = 3;
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.ItemHeight = 32;
            this.listBoxDisplay.Location = new System.Drawing.Point(20, 134);
            this.listBoxDisplay.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(285, 516);
            this.listBoxDisplay.TabIndex = 4;
            this.listBoxDisplay.SelectedIndexChanged += new System.EventHandler(this.listBoxDisplay_SelectedIndexChanged);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(314, 610);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.textBoxMessage.Size = new System.Drawing.Size(285, 39);
            this.textBoxMessage.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input Box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Neutrino Interactions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 573);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "User Feeback";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(317, 302);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(334, 39);
            this.textBoxResult.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data Processing Result";
            // 
            // buttonLinearSearch
            // 
            this.buttonLinearSearch.Location = new System.Drawing.Point(317, 75);
            this.buttonLinearSearch.Margin = new System.Windows.Forms.Padding(5);
            this.buttonLinearSearch.Name = "buttonLinearSearch";
            this.buttonLinearSearch.Size = new System.Drawing.Size(174, 46);
            this.buttonLinearSearch.TabIndex = 11;
            this.buttonLinearSearch.Text = "Linear Search";
            this.buttonLinearSearch.UseVisualStyleBackColor = true;
            this.buttonLinearSearch.Click += new System.EventHandler(this.buttonLinearSearch_Click);
            // 
            // buttonAverage
            // 
            this.buttonAverage.Location = new System.Drawing.Point(317, 355);
            this.buttonAverage.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(153, 46);
            this.buttonAverage.TabIndex = 12;
            this.buttonAverage.Text = "Average";
            this.buttonAverage.UseVisualStyleBackColor = true;
            // 
            // buttonMode
            // 
            this.buttonMode.Location = new System.Drawing.Point(479, 355);
            this.buttonMode.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(167, 46);
            this.buttonMode.TabIndex = 13;
            this.buttonMode.Text = "Mode";
            this.buttonMode.UseVisualStyleBackColor = true;
            this.buttonMode.Click += new System.EventHandler(this.buttonMode_Click);
            // 
            // buttonMidExtreme
            // 
            this.buttonMidExtreme.Location = new System.Drawing.Point(479, 411);
            this.buttonMidExtreme.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMidExtreme.Name = "buttonMidExtreme";
            this.buttonMidExtreme.Size = new System.Drawing.Size(167, 46);
            this.buttonMidExtreme.TabIndex = 14;
            this.buttonMidExtreme.Text = "Mid-Extreme";
            this.buttonMidExtreme.UseVisualStyleBackColor = true;
            this.buttonMidExtreme.Click += new System.EventHandler(this.buttonMidExtreme_Click);
            // 
            // buttonRange
            // 
            this.buttonRange.Location = new System.Drawing.Point(317, 411);
            this.buttonRange.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRange.Name = "buttonRange";
            this.buttonRange.Size = new System.Drawing.Size(153, 46);
            this.buttonRange.TabIndex = 15;
            this.buttonRange.Text = "Range";
            this.buttonRange.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 675);
            this.Controls.Add(this.buttonRange);
            this.Controls.Add(this.buttonMidExtreme);
            this.Controls.Add(this.buttonMode);
            this.Controls.Add(this.buttonAverage);
            this.Controls.Add(this.buttonLinearSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonBinarySearch);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Astronomical Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBinarySearch;
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