﻿namespace WindowsFormsApplication1
{
    partial class Super
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(61, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Al Qeiser";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Location = new System.Drawing.Point(278, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 90);
            this.button2.TabIndex = 1;
            this.button2.Text = "Multiplication";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.Location = new System.Drawing.Point(486, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 90);
            this.button3.TabIndex = 2;
            this.button3.Text = "decoding";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button4.Location = new System.Drawing.Point(681, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 90);
            this.button4.TabIndex = 3;
            this.button4.Text = "Vigner";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button8.Location = new System.Drawing.Point(278, 189);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 90);
            this.button8.TabIndex = 7;
            this.button8.Text = "RSA";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button9.Location = new System.Drawing.Point(63, 189);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 90);
            this.button9.TabIndex = 8;
            this.button9.Text = "DES";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button6.Location = new System.Drawing.Point(486, 189);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 90);
            this.button6.TabIndex = 9;
            this.button6.Text = "RC4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_2);
            // 
            // Super
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(853, 469);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Super";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;


    }
}

