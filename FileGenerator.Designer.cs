namespace WindowsFormsApp1
{
    partial class FileGenerator
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
            this.savelbl = new System.Windows.Forms.Label();
            this.radTxt = new System.Windows.Forms.RadioButton();
            this.rafPdf = new System.Windows.Forms.RadioButton();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // savelbl
            // 
            this.savelbl.AutoSize = true;
            this.savelbl.Location = new System.Drawing.Point(44, 31);
            this.savelbl.Name = "savelbl";
            this.savelbl.Size = new System.Drawing.Size(65, 13);
            this.savelbl.TabIndex = 1;
            this.savelbl.Text = "Save file as:";
            // 
            // radTxt
            // 
            this.radTxt.AutoSize = true;
            this.radTxt.Location = new System.Drawing.Point(47, 50);
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
            this.rafPdf.Location = new System.Drawing.Point(47, 73);
            this.rafPdf.Name = "rafPdf";
            this.rafPdf.Size = new System.Drawing.Size(40, 17);
            this.rafPdf.TabIndex = 3;
            this.rafPdf.TabStop = true;
            this.rafPdf.Text = "pdf";
            this.rafPdf.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(47, 166);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "number";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(356, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "details";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(181, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(356, 20);
            this.textBox3.TabIndex = 9;
            // 
            // FileGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 225);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.rafPdf);
            this.Controls.Add(this.radTxt);
            this.Controls.Add(this.savelbl);
            this.Name = "FileGenerator";
            this.Text = "Generate file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label savelbl;
        private System.Windows.Forms.RadioButton radTxt;
        private System.Windows.Forms.RadioButton rafPdf;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}

