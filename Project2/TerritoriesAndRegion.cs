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
    public partial class TerritoriesAndRegion : Form
    {

        NorthwindEntities db;

        public TerritoriesAndRegion(NorthwindEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void TerritoriesAndRegion_Load(object sender, EventArgs e)
        {
            territoriesBindingSource.DataSource = db.Territories.ToList();
            regionBindingSource.DataSource = db.Regions.ToList();
        }

        private void btnNewTer_Click(object sender, EventArgs e)
        {
            territoryIDComboBox.DataBindings.Add("Text", territoriesBindingSource, "TerritoryID");
            territoriesBindingSource.DataSource = new Territory();
        }

        private void btnAddTerr_Click(object sender, EventArgs e)
        {
            db.Territories.Add(territoriesBindingSource.Current as Territory);
            db.SaveChanges();
            MessageBox.Show("Save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnEditTerr_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            MessageBox.Show("Save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            territoriesBindingSource.DataSource = db.Territories.ToList();
        }

        private void btnDeleteTerr_Click(object sender, EventArgs e)
        {
            territoryIDComboBox.Enabled = false;

            string terID = territoryIDComboBox.Text;

            if (MessageBox.Show("Are you sure you want to delete the territory " + terID + "?", "Delete Territory", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var od = db.Territories.Where(t => t.TerritoryID == terID).First() as Territory;
                var emp = od.Employees.ToList();
                foreach (var i in emp)
                {
                    od.Employees.Remove(i);
                    db.SaveChanges();
                }

                var entity = db.Territories.Where(ter => ter.TerritoryID == terID).Single() as Territory;
                db.Territories.Remove(entity);
                db.SaveChanges();
                territoriesBindingSource.DataSource = db.Territories.ToList();
                territoryIDComboBox.Enabled = true;
            }
        }

        private void btnNewReg_Click(object sender, EventArgs e)
        {
            regionIDComboBox.DataBindings.Add("Text", regionBindingSource, "RegionID");
            regionBindingSource.DataSource = new Region();
        }

        private void btnAddReg_Click(object sender, EventArgs e)
        {
            regionIDComboBox.DataBindings.Clear();
            regionIDComboBox.DataBindings.Add("Text",
                                regionBindingSource,
                                "RegionID");

            db.Regions.Add(regionBindingSource.Current as Region);
            db.SaveChanges();
            MessageBox.Show("Save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnEditReg_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            MessageBox.Show("Save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            regionBindingSource.DataSource = db.Regions.ToList();
        }

        private void btnDeleteReg_Click(object sender, EventArgs e)
        {
            regionIDComboBox.Enabled = false;
            List<string> terrID = new List<string>();

            int regID = Convert.ToInt32(regionIDComboBox.Text);

            if (MessageBox.Show("Are you sure you want to delete the region " + regID + "? By deleting an region, you delete all Territories associated with it!!!", "Delete Region", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                var q = from ter in db.Territories
                        where ter.RegionID == regID
                        select new
                        {
                            terID = ter.TerritoryID
                        };

                foreach (var i in q)
                {
                    terrID.Add(i.terID);
                }

                foreach (string j in terrID)
                {
                    bool a = true;
                    while (a)
                    {
                        try
                        {
                            var od = db.Territories.Where(t => t.TerritoryID == j).First() as Territory;
                            var emp = od.Employees.ToList();
                            foreach (var i in emp)
                            {
                                od.Employees.Remove(i);
                                db.SaveChanges();
                            }

                            db.Territories.Remove(od);
                            db.SaveChanges();

                        }
                        catch
                        {
                            a = false;
                        }
                    }
                }

                var entity = db.Regions.Where(reg => reg.RegionID == regID).Single() as Region;
                db.Regions.Remove(entity);
                db.SaveChanges();
                regionBindingSource.DataSource = db.Regions.ToList();
                territoriesBindingSource.DataSource = db.Territories.ToList();
                regionIDComboBox.Enabled = true;
            }
        }
    }
}
