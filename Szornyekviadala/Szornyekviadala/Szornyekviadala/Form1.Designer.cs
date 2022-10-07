namespace Szornyekviadala
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
            this.btn_beolvas = new System.Windows.Forms.Button();
            this.lb_szornyfajllista = new System.Windows.Forms.ListBox();
            this.lb_besorozva = new System.Windows.Forms.ListBox();
            this.lb_elhunyt = new System.Windows.Forms.ListBox();
            this.btn_kuzdelem = new System.Windows.Forms.Button();
            this.lb_arena = new System.Windows.Forms.ListBox();
            this.lbl_gyoztes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ujszorny = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_ujszorny = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_beolvas
            // 
            this.btn_beolvas.Location = new System.Drawing.Point(48, 26);
            this.btn_beolvas.Name = "btn_beolvas";
            this.btn_beolvas.Size = new System.Drawing.Size(75, 23);
            this.btn_beolvas.TabIndex = 0;
            this.btn_beolvas.Text = "Beolvas";
            this.btn_beolvas.UseVisualStyleBackColor = true;
            this.btn_beolvas.Click += new System.EventHandler(this.btn_beolvas_Click);
            // 
            // lb_szornyfajllista
            // 
            this.lb_szornyfajllista.FormattingEnabled = true;
            this.lb_szornyfajllista.Location = new System.Drawing.Point(48, 83);
            this.lb_szornyfajllista.Name = "lb_szornyfajllista";
            this.lb_szornyfajllista.Size = new System.Drawing.Size(193, 95);
            this.lb_szornyfajllista.TabIndex = 1;
            // 
            // lb_besorozva
            // 
            this.lb_besorozva.FormattingEnabled = true;
            this.lb_besorozva.Location = new System.Drawing.Point(48, 204);
            this.lb_besorozva.Name = "lb_besorozva";
            this.lb_besorozva.Size = new System.Drawing.Size(191, 95);
            this.lb_besorozva.TabIndex = 2;
            // 
            // lb_elhunyt
            // 
            this.lb_elhunyt.FormattingEnabled = true;
            this.lb_elhunyt.Location = new System.Drawing.Point(48, 329);
            this.lb_elhunyt.Name = "lb_elhunyt";
            this.lb_elhunyt.Size = new System.Drawing.Size(191, 82);
            this.lb_elhunyt.TabIndex = 3;
            // 
            // btn_kuzdelem
            // 
            this.btn_kuzdelem.Location = new System.Drawing.Point(308, 26);
            this.btn_kuzdelem.Name = "btn_kuzdelem";
            this.btn_kuzdelem.Size = new System.Drawing.Size(75, 23);
            this.btn_kuzdelem.TabIndex = 4;
            this.btn_kuzdelem.Text = "Küzdelem";
            this.btn_kuzdelem.UseVisualStyleBackColor = true;
            this.btn_kuzdelem.Click += new System.EventHandler(this.btn_kuzdelem_Click);
            // 
            // lb_arena
            // 
            this.lb_arena.FormattingEnabled = true;
            this.lb_arena.Location = new System.Drawing.Point(308, 67);
            this.lb_arena.Name = "lb_arena";
            this.lb_arena.Size = new System.Drawing.Size(191, 56);
            this.lb_arena.TabIndex = 5;
            // 
            // lbl_gyoztes
            // 
            this.lbl_gyoztes.AutoSize = true;
            this.lbl_gyoztes.Location = new System.Drawing.Point(305, 136);
            this.lbl_gyoztes.Name = "lbl_gyoztes";
            this.lbl_gyoztes.Size = new System.Drawing.Size(48, 13);
            this.lbl_gyoztes.TabIndex = 6;
            this.lbl_gyoztes.Text = "Gyöztes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Szörnyek a fájlból:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Szörnyek akik küzdhetnek:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Temető:";
            // 
            // btn_ujszorny
            // 
            this.btn_ujszorny.Location = new System.Drawing.Point(105, 62);
            this.btn_ujszorny.Name = "btn_ujszorny";
            this.btn_ujszorny.Size = new System.Drawing.Size(75, 23);
            this.btn_ujszorny.TabIndex = 11;
            this.btn_ujszorny.Text = "Hozzáad";
            this.btn_ujszorny.UseVisualStyleBackColor = true;
            this.btn_ujszorny.Click += new System.EventHandler(this.btn_ujszorny_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_ujszorny);
            this.groupBox1.Controls.Add(this.btn_ujszorny);
            this.groupBox1.Location = new System.Drawing.Point(256, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 91);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új szörny érkezik";
            // 
            // tb_ujszorny
            // 
            this.tb_ujszorny.Location = new System.Drawing.Point(8, 36);
            this.tb_ujszorny.Name = "tb_ujszorny";
            this.tb_ujszorny.Size = new System.Drawing.Size(172, 20);
            this.tb_ujszorny.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Minta: Tipus:Név:Tapasztalat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_gyoztes);
            this.Controls.Add(this.lb_arena);
            this.Controls.Add(this.btn_kuzdelem);
            this.Controls.Add(this.lb_elhunyt);
            this.Controls.Add(this.lb_besorozva);
            this.Controls.Add(this.lb_szornyfajllista);
            this.Controls.Add(this.btn_beolvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_beolvas;
        private System.Windows.Forms.ListBox lb_szornyfajllista;
        private System.Windows.Forms.ListBox lb_besorozva;
        private System.Windows.Forms.ListBox lb_elhunyt;
        private System.Windows.Forms.Button btn_kuzdelem;
        private System.Windows.Forms.ListBox lb_arena;
        private System.Windows.Forms.Label lbl_gyoztes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ujszorny;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ujszorny;
    }
}

