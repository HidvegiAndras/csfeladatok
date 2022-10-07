using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Oroklodes
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = 0.ToString();
            textBox2.Text = 0.ToString();
            textBox3.Text = 0.ToString();
            textBox4.Text = 0.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int oldalhossza = int.Parse(textBox3.Text);
            int oldalhosszb = int.Parse(textBox4.Text);

            if (radioButton1.Checked)
            {
                Negyzet n = new Negyzet(x, y, oldalhossza);
                n.Rajzol(g);
            }
            else
            {
                Teglalap t = new Teglalap(x, y, oldalhossza, oldalhosszb);
                t.Rajzol(g);
            }

            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = 0.ToString();
            textBox2.Text = 0.ToString();
            textBox3.Text = 0.ToString();
            textBox4.Text = 0.ToString();
            pictureBox1.Image = null;
        }
    }
}
