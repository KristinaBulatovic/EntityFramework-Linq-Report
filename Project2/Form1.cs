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
    public partial class Form1 : Form
    {
        NorthwindEntities db;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new NorthwindEntities();

            employeeBindingSource.DataSource = db.Employees.ToList();
            orderBindingSource.DataSource = db.Orders.ToList();
            orderDetailBindingSource.DataSource = db.Orders.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (EmpAddEdit addEdit = new EmpAddEdit(db, null))
            {
                addEdit.ShowDialog();
                employeeBindingSource.DataSource = db.Employees.ToList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (EmpAddEdit addEdit = new EmpAddEdit(db, employeeBindingSource.Current as Employee))
            {
                addEdit.ShowDialog();
                employeeBindingSource.DataSource = db.Employees.ToList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> orderID = new List<int>();
            if (dvrgEmp.SelectedRows.Count > 0)
            {
                int empID = (int)dvrgEmp.SelectedRows[0].Cells[0].Value;

                if (MessageBox.Show("Are you sure you want to delete the employee " + empID + "? By deleting an employee, you delete all Orders and Territories associated with it!!!", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var q = from ord in db.Orders
                            where ord.EmployeeID == empID
                            select new
                            {
                                ordID = ord.OrderID
                            };

                    foreach (var i in q)
                    {
                        orderID.Add(i.ordID);
                    }
                    
                    foreach (int j in orderID)
                    {
                        bool a = true;
                        while (a)
                        {
                            try
                            {
                                var od = db.Order_Details.Where(ordDet => ordDet.OrderID == j).First() as Order_Detail;
                                db.Order_Details.Remove(od);
                                db.SaveChanges();
                            }
                            catch
                            {
                                a = false;
                            }
                        }

                        var o = db.Orders.Where(ord => ord.OrderID == j).Single() as Order;
                        db.Orders.Remove(o);
                        db.SaveChanges();
                    }
    
                    var entity = db.Employees.Where(emp => emp.EmployeeID == empID).Single() as Employee;

                    var terr = entity.Territories.ToList();

                    foreach (var i in terr)
                    {
                        entity.Territories.Remove(i);
                        db.SaveChanges();
                    }

                    
                   (from e2 in db.Employees
                    where e2.ReportsTo == empID
                    select e2).ToList().ForEach(x => x.ReportsTo = null);

                    db.SaveChanges();


                    db.Employees.Remove(entity);
                    db.SaveChanges();
                    employeeBindingSource.DataSource = db.Employees.ToList();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (TerritoriesAndRegion tr = new TerritoriesAndRegion(db))
            {
                tr.ShowDialog();
            }
        }

        private void btnDistribution_Click(object sender, EventArgs e)
        {
            using (UpdateEmpTerr et = new UpdateEmpTerr(db))
            {
                et.ShowDialog();
            }
        }

        private void btnRep1_Click(object sender, EventArgs e)
        {
            using (Report1 r1 = new Report1(db))
            {
                r1.ShowDialog();
            }
        }

        private void btnRep2_Click(object sender, EventArgs e)
        {
            using (Report2 r2 = new Report2(db))
            {
                r2.ShowDialog();
            }
        }
    }
}
