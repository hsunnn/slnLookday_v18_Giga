using Lookday_Beta.Models;
using Lookday_Beta.Product;
using Lookday_Beta_v17;
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

namespace Lookday_Beta.FrmClient
{
    public partial class FrmWritingReview : Form
    {
        public static string Aname;
        public static int Aid;
        //private string AName()
        //{
        //    dblookdaysEntities db = new dblookdaysEntities();
        //    var name = db.Activities.FirstOrDefault(p => p.Name == Aname);
        //    return name.Name;
        //}

        private DialogResult _isOk;
        private Reviews _reviews;
        private string _rated;

        public Reviews reviews
        {
            get
            {
                if (_reviews == null)
                {
                    _reviews = new Reviews();
                }
                _reviews.UserID = CCheckInfo.CurrentUserID;
                _reviews.ActivityID = Aid;
                _reviews.Rating = _rated;
                _reviews.Comment = richTextBox1.Text;
                return _reviews;
            }
            set
            {
                _reviews = value;
                label1.Text = _reviews.Activities.Name;
                label1.Left = (panel1.Width - label1.Width) / 2;
                richTextBox1.Text = _reviews.Comment;
                _reviews.ActivityID = _reviews.Activities.ActivityID;
            }
        }



        public FrmWritingReview()
        {
            InitializeComponent();
        }

        private void FrmWritingReview_Load(object sender, EventArgs e)
        {
            CAnimation.FadeIn(this);
            label1.Text = Aname;
        }
        public DialogResult isOk
        {
            get
            {
                return _isOk;
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Orange || 
                button2.BackColor == Color.Orange ||
                button3.BackColor == Color.Orange ||
                button4.BackColor == Color.Orange ||
                button5.BackColor == Color.Orange)
            {
                _isOk = DialogResult.OK;
                CManager.CloseFormsAndActivateMain(this);
                MessageBox.Show("非常謝謝您的好評!");
            }

            else
            {
                MessageBox.Show("請填寫完整訊息並給予您的評價，非常謝謝您!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _isOk = DialogResult.Cancel;
            CManager.CloseFormsAndActivateMain(this);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private Button lastClickedButton;


        private void button1_Click(object sender, EventArgs e)
        {
            _rated = "\u2605\u2605\u2605\u2605\u2605";
            Button clickedButton = (Button)sender;

            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = SystemColors.Control;
                lastClickedButton.ForeColor = SystemColors.ControlText;
            }

            lastClickedButton = clickedButton;
            clickedButton.BackColor = Color.Orange;
            clickedButton.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _rated = "\u2605\u2605\u2605\u2605\u2606";
            Button clickedButton = (Button)sender;

            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = SystemColors.Control;
                lastClickedButton.ForeColor = SystemColors.ControlText;
            }

            lastClickedButton = clickedButton;
            clickedButton.BackColor = Color.Orange;
            clickedButton.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _rated = "\u2605\u2605\u2605\u2606\u2606";
            Button clickedButton = (Button)sender;

            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = SystemColors.Control;
                lastClickedButton.ForeColor = SystemColors.ControlText;
            }

            lastClickedButton = clickedButton;
            clickedButton.BackColor = Color.Orange;
            clickedButton.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _rated = "\u2605\u2605\u2606\u2606\u2606";
            Button clickedButton = (Button)sender;

            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = SystemColors.Control;
                lastClickedButton.ForeColor = SystemColors.ControlText;
            }

            lastClickedButton = clickedButton;
            clickedButton.BackColor = Color.Orange;
            clickedButton.ForeColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _rated = "\u2605\u2606\u2606\u2606\u2606";
            Button clickedButton = (Button)sender;

            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = SystemColors.Control;
                lastClickedButton.ForeColor = SystemColors.ControlText;
            }

            lastClickedButton = clickedButton;
            clickedButton.BackColor = Color.Orange;
            clickedButton.ForeColor = Color.White;
        }
    }

}
