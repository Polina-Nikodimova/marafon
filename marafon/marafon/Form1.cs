using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marafon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true; pictureBox15.Visible = true;
            pictureBox16.Visible = false; pictureBox17.Visible = false; pictureBox18.Visible = false;
            label2.Visible = true; label3.Visible = true;
            label4.Visible = false; label5.Visible = false; label6.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true; pictureBox15.Visible = true; pictureBox16.Visible = true; pictureBox17.Visible = true; pictureBox18.Visible = true;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true; pictureBox15.Visible = true; pictureBox16.Visible = true;
            pictureBox17.Visible = false; pictureBox18.Visible = false;
            label2.Visible = true; label3.Visible = true; label4.Visible = true;
            label5.Visible = false; label6.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true; pictureBox15.Visible = true; pictureBox16.Visible = true; pictureBox18.Visible = true;
            pictureBox17.Visible = false;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label6.Visible = true;
            label5.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true; pictureBox15.Visible = true; pictureBox16.Visible = true; pictureBox17.Visible = true;
            pictureBox18.Visible = false;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true;
            label6.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true; pictureBox15.Visible = true; pictureBox16.Visible = true;
            pictureBox17.Visible = false; pictureBox18.Visible = false;
            label2.Visible = true; label3.Visible = true; label4.Visible = true;
            label5.Visible = false; label6.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true; pictureBox15.Visible = true; pictureBox16.Visible = true; pictureBox17.Visible = true; pictureBox18.Visible = true;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true; pictureBox15.Visible = true; pictureBox16.Visible = true; pictureBox17.Visible = true; pictureBox18.Visible = true;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true;
        }


    }
}
