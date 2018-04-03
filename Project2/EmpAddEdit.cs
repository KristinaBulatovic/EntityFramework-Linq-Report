using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class EmpAddEdit : Form
    {

        NorthwindEntities db;
        bool add;

        public EmpAddEdit(NorthwindEntities db, Object obj)
        {
            InitializeComponent();
            this.db = db;

            if (obj == null)
            {
                add = true;
                employeeBindingSource.DataSource = new Employee();
            }
            else
            {
                employeeBindingSource.DataSource = obj;
                btnNew.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text != "" && firstNameTextBox.Text != "")
            {
                if (add == true)
                {
                    db.Employees.Add(employeeBindingSource.Current as Employee);
                }
                db.SaveChanges();
                MessageBox.Show("Save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Please enter your Last Name and First Name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = new Employee();
        }
    }
}
