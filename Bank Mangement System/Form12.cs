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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           Form3 F3 = new Form3();
           F3.Visible = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(txtEnter.Text);
            Employee obj = new Employee();
            if(obj.CloseAccount(num)==true)
            {
                MessageBox.Show("Done");
                
                this.Visible = false;
                Form3 f3 = new Form3();
                f3.Visible = true;
            }
            else
            {
                MessageBox.Show("The Account is already closed");
                return;
            }
        }

        private void txtEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        } 
    }
}
