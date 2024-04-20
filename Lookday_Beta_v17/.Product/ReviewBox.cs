using Lookday_Beta_v17;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lookday_Beta.Product
{
    public partial class ReviewBox : UserControl
    {
        private Reviews _reviews;
        public Reviews review
        {
            get { return _reviews; }
            set
            {
                _reviews = value;
                lblUsername.Text = _reviews.User.Username;
                lblRating.Text = _reviews.Rating.ToString();
                lblComment.Text = _reviews.Comment;
            }
        }
        public ReviewBox()
        {
            InitializeComponent();
        }
    }
}
