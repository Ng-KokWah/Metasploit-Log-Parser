namespace Temp
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
            file1 = new TextBox();
            btnFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            output = new TextBox();
            label1 = new Label();
            tbText = new TextBox();
            label2 = new Label();
            btnOutput = new Button();
            checkOnFilter = new CheckBox();
            btnFilter = new Button();
            tbAdded = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // file1
            // 
            file1.Location = new Point(53, 12);
            file1.Name = "file1";
            file1.Size = new Size(624, 27);
            file1.TabIndex = 0;
            // 
            // btnFile
            // 
            btnFile.Location = new Point(683, 10);
            btnFile.Name = "btnFile";
            btnFile.Size = new Size(94, 29);
            btnFile.TabIndex = 1;
            btnFile.Text = "Select File";
            btnFile.UseVisualStyleBackColor = true;
            btnFile.Click += btnFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // output
            // 
            output.Location = new Point(12, 314);
            output.Multiline = true;
            output.Name = "output";
            output.ScrollBars = ScrollBars.Both;
            output.Size = new Size(776, 233);
            output.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 3;
            label1.Text = "File:";
            // 
            // tbText
            // 
            tbText.Enabled = false;
            tbText.Location = new Point(94, 61);
            tbText.Name = "tbText";
            tbText.Size = new Size(583, 27);
            tbText.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Filter Text:";
            // 
            // btnOutput
            // 
            btnOutput.Location = new Point(318, 553);
            btnOutput.Name = "btnOutput";
            btnOutput.Size = new Size(125, 47);
            btnOutput.TabIndex = 8;
            btnOutput.Text = "Output To File";
            btnOutput.UseVisualStyleBackColor = true;
            btnOutput.Click += btnOutput_Click;
            // 
            // checkOnFilter
            // 
            checkOnFilter.AutoSize = true;
            checkOnFilter.Location = new Point(683, 64);
            checkOnFilter.Name = "checkOnFilter";
            checkOnFilter.Size = new Size(57, 24);
            checkOnFilter.TabIndex = 9;
            checkOnFilter.Text = "On?";
            checkOnFilter.UseVisualStyleBackColor = true;
            checkOnFilter.CheckedChanged += checkOnFilter_CheckedChanged;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(318, 94);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 10;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // tbAdded
            // 
            tbAdded.Location = new Point(12, 146);
            tbAdded.Multiline = true;
            tbAdded.Name = "tbAdded";
            tbAdded.ScrollBars = ScrollBars.Both;
            tbAdded.Size = new Size(776, 142);
            tbAdded.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 12;
            label3.Text = "Files Added:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 291);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 13;
            label4.Text = "Output:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 612);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbAdded);
            Controls.Add(btnFilter);
            Controls.Add(checkOnFilter);
            Controls.Add(btnOutput);
            Controls.Add(label2);
            Controls.Add(tbText);
            Controls.Add(label1);
            Controls.Add(output);
            Controls.Add(btnFile);
            Controls.Add(file1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox file1;
        private Button btnFile;
        private OpenFileDialog openFileDialog1;
        private TextBox output;
        private Label label1;
        private TextBox tbText;
        private Label label2;
        private Button btnOutput;
        private CheckBox checkOnFilter;
        private Button btnFilter;
        private TextBox tbAdded;
        private Label label3;
        private Label label4;
    }
}
