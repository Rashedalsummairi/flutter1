namespace WindowsFormsApplication1
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
            this.comp = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.hash2 = new System.Windows.Forms.TextBox();
            this.hash1 = new System.Windows.Forms.TextBox();
            this.plain2 = new System.Windows.Forms.RichTextBox();
            this.plain1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comp
            // 
            this.comp.AutoSize = true;
            this.comp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comp.Location = new System.Drawing.Point(231, 323);
            this.comp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comp.Name = "comp";
            this.comp.Size = new System.Drawing.Size(0, 24);
            this.comp.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(438, 423);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(303, 66);
            this.button4.TabIndex = 14;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 423);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 66);
            this.button3.TabIndex = 15;
            this.button3.Text = "Compare";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Text 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Text 1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 357);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "Hashing";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Hashing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hash2
            // 
            this.hash2.Location = new System.Drawing.Point(214, 327);
            this.hash2.Margin = new System.Windows.Forms.Padding(4);
            this.hash2.Name = "hash2";
            this.hash2.Size = new System.Drawing.Size(301, 22);
            this.hash2.TabIndex = 8;
            // 
            // hash1
            // 
            this.hash1.Location = new System.Drawing.Point(214, 116);
            this.hash1.Margin = new System.Windows.Forms.Padding(4);
            this.hash1.Name = "hash1";
            this.hash1.Size = new System.Drawing.Size(301, 22);
            this.hash1.TabIndex = 9;
            // 
            // plain2
            // 
            this.plain2.Location = new System.Drawing.Point(163, 241);
            this.plain2.Margin = new System.Windows.Forms.Padding(4);
            this.plain2.Name = "plain2";
            this.plain2.Size = new System.Drawing.Size(388, 78);
            this.plain2.TabIndex = 6;
            this.plain2.Text = "";
            // 
            // plain1
            // 
            this.plain1.Location = new System.Drawing.Point(183, 30);
            this.plain1.Margin = new System.Windows.Forms.Padding(4);
            this.plain1.Name = "plain1";
            this.plain1.Size = new System.Drawing.Size(388, 78);
            this.plain1.TabIndex = 7;
            this.plain1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(754, 502);
            this.Controls.Add(this.comp);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hash2);
            this.Controls.Add(this.hash1);
            this.Controls.Add(this.plain2);
            this.Controls.Add(this.plain1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label comp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox hash2;
        private System.Windows.Forms.TextBox hash1;
        private System.Windows.Forms.RichTextBox plain2;
        private System.Windows.Forms.RichTextBox plain1;
    }
}