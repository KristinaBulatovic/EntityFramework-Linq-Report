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
    public partial class Report1 : Form
    {
        NorthwindEntities db;
        public Report1(NorthwindEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            territoryBindingSource.DataSource = db.Territories.ToList();
            employeeBindingSource.DataSource = db.Employees.ToList();
            //regionBindingSource.DataSource = db.Regions.ToList();

            reportViewer1.RefreshReport();
        }
    }
}
