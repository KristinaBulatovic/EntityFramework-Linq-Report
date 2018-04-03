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
    public partial class Report2 : Form
    {
        NorthwindEntities db;
        public Report2(NorthwindEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void Report2_Load_1(object sender, EventArgs e)
        {
            Employee_fill();

            employeeBindingSource.DataSource = db.Employees.ToList();
            reportViewer1.RefreshReport();
        }

        public void Employee_fill()
        {
            foreach (var row in db.Employees)
            {
                row.RepLN = db.Employees.Find(row.ReportsTo).LastName;
                row.RepFN = db.Employees.Find(row.ReportsTo).FirstName;
            }
            reportViewer1.RefreshReport();
        }
    }
}
