namespace Bajnoksag
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
            this.lbl_bajnoksagcim = new System.Windows.Forms.Label();
            this.btn_fajlbeolvas = new System.Windows.Forms.Button();
            this.lb_csapatokfajlbol = new System.Windows.Forms.ListBox();
            this.lb_bajnoksag = new System.Windows.Forms.ListBox();
            this.dgv_Bajnoksag = new System.Windows.Forms.DataGridView();
            this.btn_fordulo = new System.Windows.Forms.Button();
            this.lbl_bajnoksaginfo1 = new System.Windows.Forms.Label();
            this.btn_bajnoksagstart = new System.Windows.Forms.Button();
            this.tb_bajnoksagneve = new System.Windows.Forms.TextBox();
            this.bp_bajnoksaginfo = new System.Windows.Forms.GroupBox();
            this.lbl_bajnoksagadatokinfo3 = new System.Windows.Forms.Label();
            this.lbl_bajnoksagadatokinfo2 = new System.Windows.Forms.Label();
            this.lbl_bajnoksagadatokinfo1 = new System.Windows.Forms.Label();
            this.tb_konyvtar = new System.Windows.Forms.TextBox();
            this.lb_eredmenyek = new System.Windows.Forms.ListBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_bajnoksagvege = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bajnoksag)).BeginInit();
            this.bp_bajnoksaginfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_bajnoksagcim
            // 
            this.lbl_bajnoksagcim.AutoSize = true;
            this.lbl_bajnoksagcim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_bajnoksagcim.Location = new System.Drawing.Point(329, 9);
            this.lbl_bajnoksagcim.Name = "lbl_bajnoksagcim";
            this.lbl_bajnoksagcim.Size = new System.Drawing.Size(186, 24);
            this.lbl_bajnoksagcim.TabIndex = 0;
            this.lbl_bajnoksagcim.Text = "Bajnokság szimulátor";
            // 
            // btn_fajlbeolvas
            // 
            this.btn_fajlbeolvas.Location = new System.Drawing.Point(8, 57);
            this.btn_fajlbeolvas.Name = "btn_fajlbeolvas";
            this.btn_fajlbeolvas.Size = new System.Drawing.Size(238, 25);
            this.btn_fajlbeolvas.TabIndex = 1;
            this.btn_fajlbeolvas.Text = "Nevezések beolvasása fájlból";
            this.btn_fajlbeolvas.UseVisualStyleBackColor = true;
            this.btn_fajlbeolvas.Click += new System.EventHandler(this.btn_fajlbeolvas_Click);
            // 
            // lb_csapatokfajlbol
            // 
            this.lb_csapatokfajlbol.FormattingEnabled = true;
            this.lb_csapatokfajlbol.Location = new System.Drawing.Point(8, 140);
            this.lb_csapatokfajlbol.Name = "lb_csapatokfajlbol";
            this.lb_csapatokfajlbol.Size = new System.Drawing.Size(236, 147);
            this.lb_csapatokfajlbol.TabIndex = 2;
            // 
            // lb_bajnoksag
            // 
            this.lb_bajnoksag.FormattingEnabled = true;
            this.lb_bajnoksag.Location = new System.Drawing.Point(8, 293);
            this.lb_bajnoksag.Name = "lb_bajnoksag";
            this.lb_bajnoksag.Size = new System.Drawing.Size(234, 147);
            this.lb_bajnoksag.TabIndex = 3;
            // 
            // dgv_Bajnoksag
            // 
            this.dgv_Bajnoksag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Bajnoksag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bajnoksag.Location = new System.Drawing.Point(275, 108);
            this.dgv_Bajnoksag.Name = "dgv_Bajnoksag";
            this.dgv_Bajnoksag.Size = new System.Drawing.Size(595, 205);
            this.dgv_Bajnoksag.TabIndex = 4;
            // 
            // btn_fordulo
            // 
            this.btn_fordulo.Enabled = false;
            this.btn_fordulo.Location = new System.Drawing.Point(716, 68);
            this.btn_fordulo.Name = "btn_fordulo";
            this.btn_fordulo.Size = new System.Drawing.Size(154, 34);
            this.btn_fordulo.TabIndex = 5;
            this.btn_fordulo.Text = "Lejátszás";
            this.btn_fordulo.UseVisualStyleBackColor = true;
            this.btn_fordulo.Click += new System.EventHandler(this.btn_fordulo_Click);
            // 
            // lbl_bajnoksaginfo1
            // 
            this.lbl_bajnoksaginfo1.AutoSize = true;
            this.lbl_bajnoksaginfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_bajnoksaginfo1.Location = new System.Drawing.Point(524, 74);
            this.lbl_bajnoksaginfo1.Name = "lbl_bajnoksaginfo1";
            this.lbl_bajnoksaginfo1.Size = new System.Drawing.Size(93, 20);
            this.lbl_bajnoksaginfo1.TabIndex = 6;
            this.lbl_bajnoksaginfo1.Text = "Bajnokság";
            // 
            // btn_bajnoksagstart
            // 
            this.btn_bajnoksagstart.Location = new System.Drawing.Point(277, 68);
            this.btn_bajnoksagstart.Name = "btn_bajnoksagstart";
            this.btn_bajnoksagstart.Size = new System.Drawing.Size(154, 34);
            this.btn_bajnoksagstart.TabIndex = 8;
            this.btn_bajnoksagstart.Text = "Bajnokság kezdése";
            this.btn_bajnoksagstart.UseVisualStyleBackColor = true;
            this.btn_bajnoksagstart.Click += new System.EventHandler(this.btn_bajnoksagstart_Click);
            // 
            // tb_bajnoksagneve
            // 
            this.tb_bajnoksagneve.Location = new System.Drawing.Point(8, 114);
            this.tb_bajnoksagneve.Name = "tb_bajnoksagneve";
            this.tb_bajnoksagneve.Size = new System.Drawing.Size(238, 20);
            this.tb_bajnoksagneve.TabIndex = 9;
            this.tb_bajnoksagneve.Text = "Bajnokság / Fájl neve";
            // 
            // bp_bajnoksaginfo
            // 
            this.bp_bajnoksaginfo.Controls.Add(this.lbl_bajnoksagadatokinfo3);
            this.bp_bajnoksaginfo.Controls.Add(this.lbl_bajnoksagadatokinfo2);
            this.bp_bajnoksaginfo.Controls.Add(this.lbl_bajnoksagadatokinfo1);
            this.bp_bajnoksaginfo.Location = new System.Drawing.Point(9, 446);
            this.bp_bajnoksaginfo.Name = "bp_bajnoksaginfo";
            this.bp_bajnoksaginfo.Size = new System.Drawing.Size(233, 104);
            this.bp_bajnoksaginfo.TabIndex = 11;
            this.bp_bajnoksaginfo.TabStop = false;
            this.bp_bajnoksaginfo.Text = "Bajnokság adatai";
            // 
            // lbl_bajnoksagadatokinfo3
            // 
            this.lbl_bajnoksagadatokinfo3.AutoSize = true;
            this.lbl_bajnoksagadatokinfo3.Location = new System.Drawing.Point(6, 81);
            this.lbl_bajnoksagadatokinfo3.Name = "lbl_bajnoksagadatokinfo3";
            this.lbl_bajnoksagadatokinfo3.Size = new System.Drawing.Size(35, 13);
            this.lbl_bajnoksagadatokinfo3.TabIndex = 2;
            this.lbl_bajnoksagadatokinfo3.Text = "label1";
            // 
            // lbl_bajnoksagadatokinfo2
            // 
            this.lbl_bajnoksagadatokinfo2.AutoSize = true;
            this.lbl_bajnoksagadatokinfo2.Location = new System.Drawing.Point(6, 52);
            this.lbl_bajnoksagadatokinfo2.Name = "lbl_bajnoksagadatokinfo2";
            this.lbl_bajnoksagadatokinfo2.Size = new System.Drawing.Size(35, 13);
            this.lbl_bajnoksagadatokinfo2.TabIndex = 1;
            this.lbl_bajnoksagadatokinfo2.Text = "label1";
            // 
            // lbl_bajnoksagadatokinfo1
            // 
            this.lbl_bajnoksagadatokinfo1.AutoSize = true;
            this.lbl_bajnoksagadatokinfo1.Location = new System.Drawing.Point(6, 25);
            this.lbl_bajnoksagadatokinfo1.Name = "lbl_bajnoksagadatokinfo1";
            this.lbl_bajnoksagadatokinfo1.Size = new System.Drawing.Size(35, 13);
            this.lbl_bajnoksagadatokinfo1.TabIndex = 0;
            this.lbl_bajnoksagadatokinfo1.Text = "label1";
            // 
            // tb_konyvtar
            // 
            this.tb_konyvtar.Location = new System.Drawing.Point(8, 88);
            this.tb_konyvtar.Name = "tb_konyvtar";
            this.tb_konyvtar.Size = new System.Drawing.Size(238, 20);
            this.tb_konyvtar.TabIndex = 12;
            this.tb_konyvtar.Text = "Fájl helye: Asztal";
            // 
            // lb_eredmenyek
            // 
            this.lb_eredmenyek.FormattingEnabled = true;
            this.lb_eredmenyek.Location = new System.Drawing.Point(275, 319);
            this.lb_eredmenyek.Name = "lb_eredmenyek";
            this.lb_eredmenyek.Size = new System.Drawing.Size(595, 264);
            this.lb_eredmenyek.TabIndex = 0;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(6, 558);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(238, 25);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_bajnoksagvege
            // 
            this.btn_bajnoksagvege.Location = new System.Drawing.Point(6, 590);
            this.btn_bajnoksagvege.Name = "btn_bajnoksagvege";
            this.btn_bajnoksagvege.Size = new System.Drawing.Size(238, 23);
            this.btn_bajnoksagvege.TabIndex = 14;
            this.btn_bajnoksagvege.Text = "Bajnokság vége";
            this.btn_bajnoksagvege.UseVisualStyleBackColor = true;
            this.btn_bajnoksagvege.Click += new System.EventHandler(this.btn_bajnoksagvege_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 619);
            this.Controls.Add(this.btn_bajnoksagvege);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lb_eredmenyek);
            this.Controls.Add(this.tb_konyvtar);
            this.Controls.Add(this.bp_bajnoksaginfo);
            this.Controls.Add(this.tb_bajnoksagneve);
            this.Controls.Add(this.btn_bajnoksagstart);
            this.Controls.Add(this.lbl_bajnoksaginfo1);
            this.Controls.Add(this.btn_fordulo);
            this.Controls.Add(this.dgv_Bajnoksag);
            this.Controls.Add(this.lb_bajnoksag);
            this.Controls.Add(this.lb_csapatokfajlbol);
            this.Controls.Add(this.btn_fajlbeolvas);
            this.Controls.Add(this.lbl_bajnoksagcim);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bajnoksag)).EndInit();
            this.bp_bajnoksaginfo.ResumeLayout(false);
            this.bp_bajnoksaginfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bajnoksagcim;
        private System.Windows.Forms.Button btn_fajlbeolvas;
        private System.Windows.Forms.ListBox lb_csapatokfajlbol;
        private System.Windows.Forms.ListBox lb_bajnoksag;
        private System.Windows.Forms.DataGridView dgv_Bajnoksag;
        private System.Windows.Forms.Button btn_fordulo;
        private System.Windows.Forms.Label lbl_bajnoksaginfo1;
        private System.Windows.Forms.Button btn_bajnoksagstart;
        private System.Windows.Forms.TextBox tb_bajnoksagneve;
        private System.Windows.Forms.GroupBox bp_bajnoksaginfo;
        private System.Windows.Forms.Label lbl_bajnoksagadatokinfo3;
        private System.Windows.Forms.Label lbl_bajnoksagadatokinfo2;
        private System.Windows.Forms.Label lbl_bajnoksagadatokinfo1;
        private System.Windows.Forms.TextBox tb_konyvtar;
        private System.Windows.Forms.ListBox lb_eredmenyek;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_bajnoksagvege;
    }
}

