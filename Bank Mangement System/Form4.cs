using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Bank_Mangement_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form14 F14 = new Form14();
            F14.Visible = true;
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name; string phone; string address; string position; string college; int graduationYear; int iD; string totalgrade;
            if (txtAddress.Text.Any() == false || txtName.Text.Any() == false || txtPhone.Text.Any() == false || txtID.Text.Any() == false || ComboxPosition.SelectedItem == null || txtCollege.Text.Any() == false || ComboxDegree.SelectedItem == null || txtYear.Text.Any() == false)
            {
                MessageBox.Show("Make sure you enter all data");
                return;
            }
            name = txtName.Text;
            iD =int.Parse( txtID.Text);
            address = txtAddress.Text;
            phone = txtPhone.Text;
            college = txtCollege.Text;
            graduationYear =int.Parse( txtYear.Text );
            totalgrade = ComboxDegree.Text;
            position = ComboxPosition.Text;
            Employee emp = new Employee(name, iD, address, phone, college, graduationYear, totalgrade, position);
            emp.add();
            MessageBox.Show("Successfully Added ");
            this.Visible = false;
            Form14 f14 = new Form14();
            f14.Visible = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
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
