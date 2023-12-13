namespace WindowsFormsApplication1
{
    partial class Alqeiser
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
            this.keytxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.plainafter_textbox = new System.Windows.Forms.TextBox();
            this.ciphertextbox = new System.Windows.Forms.TextBox();
            this.plain_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // keytxt
            // 
            this.keytxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.keytxt.Location = new System.Drawing.Point(283, 70);
            this.keytxt.Name = "keytxt";
            this.keytxt.Size = new System.Drawing.Size(200, 22);
            this.keytxt.TabIndex = 13;
            this.keytxt.TextChanged += new System.EventHandler(this.keytxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "cipher text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "plain after decrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "plaintext";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(283, 244);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(446, 244);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plainafter_textbox
            // 
            this.plainafter_textbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plainafter_textbox.Location = new System.Drawing.Point(28, 304);
            this.plainafter_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.plainafter_textbox.Multiline = true;
            this.plainafter_textbox.Name = "plainafter_textbox";
            this.plainafter_textbox.Size = new System.Drawing.Size(169, 84);
            this.plainafter_textbox.TabIndex = 4;
            this.plainafter_textbox.TextChanged += new System.EventHandler(this.plainafter_textbox_TextChanged);
            // 
            // ciphertextbox
            // 
            this.ciphertextbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ciphertextbox.Location = new System.Drawing.Point(28, 172);
            this.ciphertextbox.Margin = new System.Windows.Forms.Padding(4);
            this.ciphertextbox.Multiline = true;
            this.ciphertextbox.Name = "ciphertextbox";
            this.ciphertextbox.Size = new System.Drawing.Size(169, 84);
            this.ciphertextbox.TabIndex = 5;
            this.ciphertextbox.TextChanged += new System.EventHandler(this.ciphertextbox_TextChanged);
            // 
            // plain_textbox
            // 
            this.plain_textbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plain_textbox.Location = new System.Drawing.Point(28, 37);
            this.plain_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.plain_textbox.Multiline = true;
            this.plain_textbox.Name = "plain_textbox";
            this.plain_textbox.Size = new System.Drawing.Size(169, 84);
            this.plain_textbox.TabIndex = 6;
            this.plain_textbox.TextChanged += new System.EventHandler(this.plain_textbox_TextChanged);
            // 
            // Alqeiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(619, 447);
            this.Controls.Add(this.keytxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plainafter_textbox);
            this.Controls.Add(this.ciphertextbox);
            this.Controls.Add(this.plain_textbox);
            this.Name = "Alqeiser";
            this.Text = "Alqeiser";
            this.Load += new System.EventHandler(this.Alqeiser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keytxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox plainafter_textbox;
        private System.Windows.Forms.TextBox ciphertextbox;
        private System.Windows.Forms.TextBox plain_textbox;
    }
}