namespace OCRDemo
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
            btnBrowse = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btnOCR = new Button();
            txtResult = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(650, 44);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // button1
            // 
            button1.Location = new Point(658, 140);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(632, 396);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnOCR
            // 
            btnOCR.Location = new Point(650, 73);
            btnOCR.Name = "btnOCR";
            btnOCR.Size = new Size(75, 23);
            btnOCR.TabIndex = 3;
            btnOCR.Text = "Show text";
            btnOCR.UseVisualStyleBackColor = true;
            btnOCR.Click += btnOCR_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(744, 24);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(647, 389);
            txtResult.TabIndex = 4;
            txtResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 450);
            Controls.Add(txtResult);
            Controls.Add(btnOCR);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(btnBrowse);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBrowse;
        private Button button1;
        private PictureBox pictureBox1;
        private Button btnOCR;
        private RichTextBox txtResult;
    }
}
