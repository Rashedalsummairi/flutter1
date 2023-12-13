namespace WindowsFormsApplication1
{
    partial class Vigner
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
            this.Lang = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plainafter = new System.Windows.Forms.RichTextBox();
            this.ciphertext = new System.Windows.Forms.RichTextBox();
            this.key = new System.Windows.Forms.RichTextBox();
            this.plaintext = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Lang
            // 
            this.Lang.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Lang.FormattingEnabled = true;
            this.Lang.IntegralHeight = false;
            this.Lang.Items.AddRange(new object[] {
            "ABC",
            "abc",
            "أ ب ت"});
            this.Lang.Location = new System.Drawing.Point(310, 47);
            this.Lang.Margin = new System.Windows.Forms.Padding(4);
            this.Lang.Name = "Lang";
            this.Lang.Size = new System.Drawing.Size(307, 24);
            this.Lang.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.Location = new System.Drawing.Point(537, 458);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 41);
            this.button3.TabIndex = 26;
            this.button3.Text = "Decryption";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Location = new System.Drawing.Point(310, 458);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 41);
            this.button2.TabIndex = 27;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(82, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 41);
            this.button1.TabIndex = 28;
            this.button1.Text = "Encryption";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 393);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "PlainAfter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "CipherText";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Language";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "PlainText";
            // 
            // plainafter
            // 
            this.plainafter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.plainafter.Location = new System.Drawing.Point(310, 371);
            this.plainafter.Margin = new System.Windows.Forms.Padding(4);
            this.plainafter.Name = "plainafter";
            this.plainafter.Size = new System.Drawing.Size(307, 59);
            this.plainafter.TabIndex = 17;
            this.plainafter.Text = "";
            // 
            // ciphertext
            // 
            this.ciphertext.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ciphertext.Location = new System.Drawing.Point(310, 286);
            this.ciphertext.Margin = new System.Windows.Forms.Padding(4);
            this.ciphertext.Name = "ciphertext";
            this.ciphertext.Size = new System.Drawing.Size(307, 59);
            this.ciphertext.TabIndex = 18;
            this.ciphertext.Text = "";
            // 
            // key
            // 
            this.key.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.key.Location = new System.Drawing.Point(310, 197);
            this.key.Margin = new System.Windows.Forms.Padding(4);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(307, 59);
            this.key.TabIndex = 19;
            this.key.Text = "";
            // 
            // plaintext
            // 
            this.plaintext.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.plaintext.Location = new System.Drawing.Point(310, 102);
            this.plaintext.Margin = new System.Windows.Forms.Padding(4);
            this.plaintext.Name = "plaintext";
            this.plaintext.Size = new System.Drawing.Size(307, 59);
            this.plaintext.TabIndex = 20;
            this.plaintext.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(755, 547);
            this.Controls.Add(this.Lang);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plainafter);
            this.Controls.Add(this.ciphertext);
            this.Controls.Add(this.key);
            this.Controls.Add(this.plaintext);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Lang;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox plainafter;
        private System.Windows.Forms.RichTextBox ciphertext;
        private System.Windows.Forms.RichTextBox key;
        private System.Windows.Forms.RichTextBox plaintext;
    }
}