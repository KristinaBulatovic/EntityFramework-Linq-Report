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
    public partial class UpdateEmpTerr : Form
    {
        NorthwindEntities db;
        public UpdateEmpTerr(NorthwindEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void UpdateEmpTerr_Load(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = db.Employees.ToList();
            territoryBindingSource.DataSource = db.Territories.ToList(); 
        }

        private void btnDistribution_Click(object sender, EventArgs e)
        {
            employeeIDComboBox.DataBindings.Add("Text",
                                      employeeBindingSource,
                                      "EmployeeID");
            territoryIDComboBox.DataBindings.Add("Text",
                                         territoryBindingSource,
                                         "TerritoryID");

            int empID = Convert.ToInt32(employeeIDComboBox.Text);
            string terID = territoryIDComboBox.Text;

            var employee = db.Employees.Where(emp => emp.EmployeeID == empID).Single() as Employee;
            var terr = db.Territories.Where(t => t.TerritoryID == terID).Single() as Territory;

            employee.Territories.Add(terr);
            db.SaveChanges();

            MessageBox.Show("Save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
    }
}
