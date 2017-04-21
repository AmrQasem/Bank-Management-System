using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Mangement_System
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f1 = new Form1();
            f1.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 f4 = new Form4();
            f4.Visible = true; 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 f5 = new Form5();
            f5.Visible = true;
        }

       
    }
}
