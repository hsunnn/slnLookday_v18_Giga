using Lookday_Beta_v17.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lookday_Beta_v17
{
    public partial class FrmService : Form
    {
        public FrmService()
        {
            InitializeComponent();
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 0, 0, 0);
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CManager.CloseFormsAndActivateMain(this);
        }

        private void FrmService_Load(object sender, EventArgs e)
        {
            CAnimation.FadeIn(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("我們會盡快以信件與您聯繫，謝謝!");
                CManager.CloseFormsAndActivateMain(this);
            }

            else
            {
                MessageBox.Show("標題與內文都要填寫才能送出唷!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            richTextBox1.Clear();
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Title")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = "Title";
            }
        }

        private void richTextBox1_MouseEnter(object sender, EventArgs e)
        {
           if (richTextBox1.Text == "Leave your message here! ")
            {
                richTextBox1.Text = "";
            }
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "Leave your message here! ";
            }
        }
    }
}
