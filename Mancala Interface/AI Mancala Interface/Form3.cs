using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AI_Mancala_Interface
{
    
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
            

            this.Show();
            this.timer1.Start();
            Application.DoEvents();
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            progressBar1.Maximum = 100;

         





        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            this.progressBar1.Increment(15);
            if (progressBar1.Value == progressBar1.Maximum )
            {
                this.Hide();

                timer1.Dispose();
                Form1 f1 = new Form1();
                f1.Show();
            }


        }

 
    }
}
