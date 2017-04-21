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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Any()==false||txtName.Text.Any()==false)
            {
                MessageBox.Show("Enter a valid Name and ID");
                return;
            }
            string name, id;
            name=txtName.Text;
            id=txtID.Text;
            //Employee Manag = new Employee();
            Manager Manag = Manager.Instance;
            if (Manag.deleteEmployee(name, id) == true)
            {
                MessageBox.Show(" Done ");
            }
            else
                MessageBox.Show("This employee is not found!");
            this.Visible = false;
            Form14 f14 = new Form14();
            f14.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form14 F14 = new Form14();
            F14.Visible = true;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }   
    }
}
