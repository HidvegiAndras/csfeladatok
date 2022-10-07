namespace lambdaharom
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
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.bt1 = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(12, 42);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(333, 212);
            this.lb1.TabIndex = 0;
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(680, 42);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(374, 212);
            this.lb2.TabIndex = 1;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rb7);
            this.gb1.Controls.Add(this.rb6);
            this.gb1.Controls.Add(this.rb5);
            this.gb1.Controls.Add(this.rb4);
            this.gb1.Controls.Add(this.rb3);
            this.gb1.Controls.Add(this.rb2);
            this.gb1.Controls.Add(this.rb1);
            this.gb1.Location = new System.Drawing.Point(351, 42);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(323, 215);
            this.gb1.TabIndex = 2;
            this.gb1.TabStop = false;
            this.gb1.Text = "Választható menüpontok";
            this.gb1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(21, 19);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(150, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Összes érvényes szavazat";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.Rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(21, 42);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(170, 17);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "Érvénytelen szavazatok átlaga";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.Rb2_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(21, 65);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(200, 17);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "A legtöbb érvényes szavazatot kapta";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.Rb3_CheckedChanged);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(21, 88);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(199, 17);
            this.rb4.TabIndex = 3;
            this.rb4.TabStop = true;
            this.rb4.Text = "Volt-e 10-nél több érvényes szavazat";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.CheckedChanged += new System.EventHandler(this.Rb4_CheckedChanged);
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(21, 111);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(295, 17);
            this.rb5.TabIndex = 4;
            this.rb5.TabStop = true;
            this.rb5.Text = "Legmagasabb szavazatszám érvénytelen szavazat nélkül";
            this.rb5.UseVisualStyleBackColor = true;
            this.rb5.CheckedChanged += new System.EventHandler(this.Rb5_CheckedChanged);
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Location = new System.Drawing.Point(21, 134);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(241, 17);
            this.rb6.TabIndex = 5;
            this.rb6.TabStop = true;
            this.rb6.Text = "Legalább 50 érvényes szavzattal rendelkezők";
            this.rb6.UseVisualStyleBackColor = true;
            this.rb6.CheckedChanged += new System.EventHandler(this.Rb6_CheckedChanged);
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Location = new System.Drawing.Point(21, 157);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(126, 17);
            this.rb7.TabIndex = 6;
            this.rb7.TabStop = true;
            this.rb7.Text = "Versenyzők sorrendje";
            this.rb7.UseVisualStyleBackColor = true;
            this.rb7.CheckedChanged += new System.EventHandler(this.Rb7_CheckedChanged);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(12, 261);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(333, 23);
            this.bt1.TabIndex = 3;
            this.bt1.Text = "Feltöltés";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 365);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button bt1;
    }
}

