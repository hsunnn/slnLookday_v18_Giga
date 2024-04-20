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
    public partial class LabelBox : UserControl
    {
        public LabelBox()
        {
            InitializeComponent();
        }

        public string title 
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string content
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

    }
}
