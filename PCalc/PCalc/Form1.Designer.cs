namespace PCalc
{
    partial class Form1
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
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(439, 50);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(102, 43);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "Limpar";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(439, 120);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(102, 43);
            this.Btn2.TabIndex = 1;
            this.Btn2.Text = "Fechar";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(307, 302);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(102, 36);
            this.Btn5.TabIndex = 2;
            this.Btn5.Text = "*";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(199, 302);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(102, 36);
            this.Btn4.TabIndex = 3;
            this.Btn4.Text = "-";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(91, 302);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(102, 36);
            this.Btn3.TabIndex = 4;
            this.Btn3.Text = "+";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(40, 53);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(53, 13);
            this.Lbl1.TabIndex = 5;
            this.Lbl1.Text = "Número 1";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(39, 92);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(53, 13);
            this.Lbl2.TabIndex = 6;
            this.Lbl2.Text = "Número 2";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Location = new System.Drawing.Point(40, 147);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(55, 13);
            this.Lbl3.TabIndex = 7;
            this.Lbl3.Text = "Resultado";
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(415, 302);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(102, 36);
            this.Btn6.TabIndex = 8;
            this.Btn6.Text = "/";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(105, 50);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(217, 20);
            this.Txt1.TabIndex = 9;
            this.Txt1.Validated += new System.EventHandler(this.Txt1_Validated);
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(105, 89);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(217, 20);
            this.Txt2.TabIndex = 10;
            this.Txt2.Validated += new System.EventHandler(this.Txt2_Validated);
            // 
            // Txt3
            // 
            this.Txt3.Location = new System.Drawing.Point(105, 143);
            this.Txt3.Name = "Txt3";
            this.Txt3.Size = new System.Drawing.Size(217, 20);
            this.Txt3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 371);
            this.Controls.Add(this.Txt3);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt3;
    }
}

