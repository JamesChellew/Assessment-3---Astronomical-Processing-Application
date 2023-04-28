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
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(214, 84);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 0;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(214, 124);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(94, 29);
            buttonSort.TabIndex = 1;
            buttonSort.Text = "Sort";
            buttonSort.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(214, 159);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
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
            listBoxDisplay.Size = new Size(177, 104);
            listBoxDisplay.TabIndex = 4;
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(12, 215);
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
            label3.Location = new Point(12, 191);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 8;
            label3.Text = "User Feeback";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 261);
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
    }
}
