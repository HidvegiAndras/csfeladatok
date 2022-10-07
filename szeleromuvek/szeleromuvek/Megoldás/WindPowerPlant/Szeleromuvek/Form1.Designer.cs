namespace Szeleromuvek
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
            this.feladat2 = new System.Windows.Forms.Button();
            this.feladat3 = new System.Windows.Forms.Button();
            this.feladat4 = new System.Windows.Forms.Button();
            this.feladat5 = new System.Windows.Forms.Button();
            this.feladat6 = new System.Windows.Forms.Button();
            this.feladat7 = new System.Windows.Forms.Button();
            this.lbl_eredmeny = new System.Windows.Forms.Label();
            this.lb_eredmeny = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // feladat2
            // 
            this.feladat2.Location = new System.Drawing.Point(63, 49);
            this.feladat2.Name = "feladat2";
            this.feladat2.Size = new System.Drawing.Size(393, 25);
            this.feladat2.TabIndex = 0;
            this.feladat2.Text = "2. Adja meg, hány torony épült összesen eddig Magyarországon!";
            this.feladat2.UseVisualStyleBackColor = true;
            this.feladat2.Click += new System.EventHandler(this.feladat2_Click);
            // 
            // feladat3
            // 
            this.feladat3.Location = new System.Drawing.Point(63, 80);
            this.feladat3.Name = "feladat3";
            this.feladat3.Size = new System.Drawing.Size(393, 25);
            this.feladat3.TabIndex = 1;
            this.feladat3.Text = "3. Adja meg, hogy melyik településen és melyik évben épült a legtöbb torony!";
            this.feladat3.UseVisualStyleBackColor = true;
            this.feladat3.Click += new System.EventHandler(this.feladat3_Click);
            // 
            // feladat4
            // 
            this.feladat4.Location = new System.Drawing.Point(63, 111);
            this.feladat4.Name = "feladat4";
            this.feladat4.Size = new System.Drawing.Size(393, 45);
            this.feladat4.TabIndex = 2;
            this.feladat4.Text = "4. Átlagosan hány tornyot építettek a Nyugat-Dunántúl régióban? Az értéket pontos" +
    "an 2 tizedes jeggyel jelenítse meg!";
            this.feladat4.UseVisualStyleBackColor = true;
            // 
            // feladat5
            // 
            this.feladat5.Location = new System.Drawing.Point(63, 162);
            this.feladat5.Name = "feladat5";
            this.feladat5.Size = new System.Drawing.Size(393, 38);
            this.feladat5.TabIndex = 3;
            this.feladat5.Text = "5. Épült-e torony a dél-alföldi régióban? Ha igen, akkor adjon meg egy ilyen tele" +
    "pülésnevet, ha nem, akkor írja ki, hogy nem épült ebben a régióban torony!";
            this.feladat5.UseVisualStyleBackColor = true;
            // 
            // feladat6
            // 
            this.feladat6.Location = new System.Drawing.Point(63, 206);
            this.feladat6.Name = "feladat6";
            this.feladat6.Size = new System.Drawing.Size(393, 41);
            this.feladat6.TabIndex = 4;
            this.feladat6.Text = "6. Adja meg a Vas megyében épült tornyok településeit, darabszámát, teljesítményé" +
    "t és építési évét!";
            this.feladat6.UseVisualStyleBackColor = true;
            // 
            // feladat7
            // 
            this.feladat7.Location = new System.Drawing.Point(63, 253);
            this.feladat7.Name = "feladat7";
            this.feladat7.Size = new System.Drawing.Size(393, 39);
            this.feladat7.TabIndex = 5;
            this.feladat7.Text = "7.Hány építkezés folyt az Észak-Alföld és a Dél - Alföld régiókban összesen?";
            this.feladat7.UseVisualStyleBackColor = true;
            // 
            // lbl_eredmeny
            // 
            this.lbl_eredmeny.Location = new System.Drawing.Point(566, 49);
            this.lbl_eredmeny.Name = "lbl_eredmeny";
            this.lbl_eredmeny.Size = new System.Drawing.Size(506, 39);
            this.lbl_eredmeny.TabIndex = 6;
            this.lbl_eredmeny.Text = "label1";
            // 
            // lb_eredmeny
            // 
            this.lb_eredmeny.FormattingEnabled = true;
            this.lb_eredmeny.Location = new System.Drawing.Point(565, 104);
            this.lb_eredmeny.Name = "lb_eredmeny";
            this.lb_eredmeny.Size = new System.Drawing.Size(507, 381);
            this.lb_eredmeny.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 570);
            this.Controls.Add(this.lb_eredmeny);
            this.Controls.Add(this.lbl_eredmeny);
            this.Controls.Add(this.feladat7);
            this.Controls.Add(this.feladat6);
            this.Controls.Add(this.feladat5);
            this.Controls.Add(this.feladat4);
            this.Controls.Add(this.feladat3);
            this.Controls.Add(this.feladat2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button feladat2;
        private System.Windows.Forms.Button feladat3;
        private System.Windows.Forms.Button feladat4;
        private System.Windows.Forms.Button feladat5;
        private System.Windows.Forms.Button feladat6;
        private System.Windows.Forms.Button feladat7;
        private System.Windows.Forms.Label lbl_eredmeny;
        private System.Windows.Forms.ListBox lb_eredmeny;
    }
}

