namespace WindowsFormsApplication1
{
    partial class Multipliction
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
            this.key_textbox = new System.Windows.Forms.ComboBox();
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
            // key_textbox
            // 
            this.key_textbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.key_textbox.FormattingEnabled = true;
            this.key_textbox.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9",
            "11",
            "15",
            "17",
            "19",
            "21",
            "23",
            "25"});
            this.key_textbox.Location = new System.Drawing.Point(283, 67);
            this.key_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.key_textbox.Name = "key_textbox";
            this.key_textbox.Size = new System.Drawing.Size(209, 24);
            this.key_textbox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "cipher text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "plain after decrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "plaintext";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(267, 210);
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
            this.button1.Location = new System.Drawing.Point(423, 210);
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
            this.plainafter_textbox.Location = new System.Drawing.Point(23, 293);
            this.plainafter_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.plainafter_textbox.Multiline = true;
            this.plainafter_textbox.Name = "plainafter_textbox";
            this.plainafter_textbox.Size = new System.Drawing.Size(169, 84);
            this.plainafter_textbox.TabIndex = 4;
            // 
            // ciphertextbox
            // 
            this.ciphertextbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ciphertextbox.Location = new System.Drawing.Point(23, 154);
            this.ciphertextbox.Margin = new System.Windows.Forms.Padding(4);
            this.ciphertextbox.Multiline = true;
            this.ciphertextbox.Name = "ciphertextbox";
            this.ciphertextbox.Size = new System.Drawing.Size(169, 84);
            this.ciphertextbox.TabIndex = 5;
            // 
            // plain_textbox
            // 
            this.plain_textbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plain_textbox.Location = new System.Drawing.Point(23, 25);
            this.plain_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.plain_textbox.Multiline = true;
            this.plain_textbox.Name = "plain_textbox";
            this.plain_textbox.Size = new System.Drawing.Size(169, 84);
            this.plain_textbox.TabIndex = 6;
            // 
            // Multipliction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(608, 410);
            this.Controls.Add(this.key_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plainafter_textbox);
            this.Controls.Add(this.ciphertextbox);
            this.Controls.Add(this.plain_textbox);
            this.Name = "Multipliction";
            this.Text = "Multipliction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox key_textbox;
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