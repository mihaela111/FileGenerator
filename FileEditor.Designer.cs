namespace WindowsFormsApp1
{
    partial class FileEditor
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.savelbl = new System.Windows.Forms.Label();
            this.radTxt = new System.Windows.Forms.RadioButton();
            this.rafPdf = new System.Windows.Forms.RadioButton();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(331, 18);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(450, 358);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // savelbl
            // 
            this.savelbl.AutoSize = true;
            this.savelbl.Location = new System.Drawing.Point(44, 47);
            this.savelbl.Name = "savelbl";
            this.savelbl.Size = new System.Drawing.Size(94, 13);
            this.savelbl.TabIndex = 1;
            this.savelbl.Text = "Save contenta as:";
            // 
            // radTxt
            // 
            this.radTxt.AutoSize = true;
            this.radTxt.Location = new System.Drawing.Point(47, 84);
            this.radTxt.Name = "radTxt";
            this.radTxt.Size = new System.Drawing.Size(36, 17);
            this.radTxt.TabIndex = 2;
            this.radTxt.TabStop = true;
            this.radTxt.Text = "txt";
            this.radTxt.UseVisualStyleBackColor = true;
            // 
            // rafPdf
            // 
            this.rafPdf.AutoSize = true;
            this.rafPdf.Location = new System.Drawing.Point(47, 118);
            this.rafPdf.Name = "rafPdf";
            this.rafPdf.Size = new System.Drawing.Size(40, 17);
            this.rafPdf.TabIndex = 3;
            this.rafPdf.TabStop = true;
            this.rafPdf.Text = "pdf";
            this.rafPdf.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(47, 159);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 5;
            // 
            // FileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.rafPdf);
            this.Controls.Add(this.radTxt);
            this.Controls.Add(this.savelbl);
            this.Controls.Add(this.richTextBox);
            this.Name = "FileEditor";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label savelbl;
        private System.Windows.Forms.RadioButton radTxt;
        private System.Windows.Forms.RadioButton rafPdf;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

