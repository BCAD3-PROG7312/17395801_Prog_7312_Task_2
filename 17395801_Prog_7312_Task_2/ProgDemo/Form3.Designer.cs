namespace Prog7312_Task1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstCallNumbers = new System.Windows.Forms.ListBox();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.lstTemp1 = new System.Windows.Forms.ListBox();
            this.lstTemp2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCallNumbers
            // 
            this.lstCallNumbers.FormattingEnabled = true;
            this.lstCallNumbers.ItemHeight = 16;
            this.lstCallNumbers.Location = new System.Drawing.Point(26, 106);
            this.lstCallNumbers.Name = "lstCallNumbers";
            this.lstCallNumbers.Size = new System.Drawing.Size(184, 260);
            this.lstCallNumbers.TabIndex = 0;
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 16;
            this.lstResult.Location = new System.Drawing.Point(487, 106);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(190, 260);
            this.lstResult.TabIndex = 1;
            // 
            // lstTemp1
            // 
            this.lstTemp1.FormattingEnabled = true;
            this.lstTemp1.ItemHeight = 16;
            this.lstTemp1.Location = new System.Drawing.Point(258, 106);
            this.lstTemp1.Name = "lstTemp1";
            this.lstTemp1.Size = new System.Drawing.Size(184, 132);
            this.lstTemp1.TabIndex = 2;
            // 
            // lstTemp2
            // 
            this.lstTemp2.FormattingEnabled = true;
            this.lstTemp2.ItemHeight = 16;
            this.lstTemp2.Location = new System.Drawing.Point(258, 250);
            this.lstTemp2.Name = "lstTemp2";
            this.lstTemp2.Size = new System.Drawing.Size(184, 116);
            this.lstTemp2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(461, 34);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(243, 31);
            this.progressBar1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prog7312_Task1.Properties.Resources.book_library;
            this.ClientSize = new System.Drawing.Size(725, 414);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstTemp2);
            this.Controls.Add(this.lstTemp1);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.lstCallNumbers);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCallNumbers;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.ListBox lstTemp1;
        private System.Windows.Forms.ListBox lstTemp2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}