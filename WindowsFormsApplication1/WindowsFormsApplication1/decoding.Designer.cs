namespace WindowsFormsApplication1
{
    partial class decoding
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
            this.plaintxt = new System.Windows.Forms.TextBox();
            this.ciphertxt = new System.Windows.Forms.TextBox();
            this.afterplaintxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plaintxt
            // 
            this.plaintxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plaintxt.Location = new System.Drawing.Point(60, 27);
            this.plaintxt.Multiline = true;
            this.plaintxt.Name = "plaintxt";
            this.plaintxt.Size = new System.Drawing.Size(263, 105);
            this.plaintxt.TabIndex = 0;
            // 
            // ciphertxt
            // 
            this.ciphertxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ciphertxt.Location = new System.Drawing.Point(60, 182);
            this.ciphertxt.Multiline = true;
            this.ciphertxt.Name = "ciphertxt";
            this.ciphertxt.Size = new System.Drawing.Size(263, 105);
            this.ciphertxt.TabIndex = 0;
            // 
            // afterplaintxt
            // 
            this.afterplaintxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.afterplaintxt.Location = new System.Drawing.Point(60, 349);
            this.afterplaintxt.Multiline = true;
            this.afterplaintxt.Name = "afterplaintxt";
            this.afterplaintxt.Size = new System.Drawing.Size(263, 105);
            this.afterplaintxt.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(581, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Encryption";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(394, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Decryption";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plaintxt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ciphertxt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Afterplaintxt";
            // 
            // decoding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(720, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.afterplaintxt);
            this.Controls.Add(this.ciphertxt);
            this.Controls.Add(this.plaintxt);
            this.Name = "decoding";
            this.Text = "decoding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plaintxt;
        private System.Windows.Forms.TextBox ciphertxt;
        private System.Windows.Forms.TextBox afterplaintxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}