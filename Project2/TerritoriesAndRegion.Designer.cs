namespace Project2
{
    partial class TerritoriesAndRegion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label regionIDLabel;
            System.Windows.Forms.Label territoryDescriptionLabel;
            System.Windows.Forms.Label regionDescriptionLabel;
            System.Windows.Forms.Label territoryIDLabel1;
            System.Windows.Forms.Label regionIDLabel2;
            this.regionIDTextBox = new System.Windows.Forms.TextBox();
            this.territoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.territoryDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.regionDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.territoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.regionIDComboBox = new System.Windows.Forms.ComboBox();
            this.btnDeleteTerr = new System.Windows.Forms.Button();
            this.btnEditTerr = new System.Windows.Forms.Button();
            this.btnAddTerr = new System.Windows.Forms.Button();
            this.btnNewTer = new System.Windows.Forms.Button();
            this.btnNewReg = new System.Windows.Forms.Button();
            this.btnDeleteReg = new System.Windows.Forms.Button();
            this.btnEditReg = new System.Windows.Forms.Button();
            this.btnAddReg = new System.Windows.Forms.Button();
            regionIDLabel = new System.Windows.Forms.Label();
            territoryDescriptionLabel = new System.Windows.Forms.Label();
            regionDescriptionLabel = new System.Windows.Forms.Label();
            territoryIDLabel1 = new System.Windows.Forms.Label();
            regionIDLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.territoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // regionIDLabel
            // 
            regionIDLabel.AutoSize = true;
            regionIDLabel.Location = new System.Drawing.Point(23, 125);
            regionIDLabel.Name = "regionIDLabel";
            regionIDLabel.Size = new System.Drawing.Size(82, 22);
            regionIDLabel.TabIndex = 1;
            regionIDLabel.Text = "Region ID:";
            // 
            // territoryDescriptionLabel
            // 
            territoryDescriptionLabel.AutoSize = true;
            territoryDescriptionLabel.Location = new System.Drawing.Point(23, 78);
            territoryDescriptionLabel.Name = "territoryDescriptionLabel";
            territoryDescriptionLabel.Size = new System.Drawing.Size(154, 22);
            territoryDescriptionLabel.TabIndex = 3;
            territoryDescriptionLabel.Text = "Territory Description:";
            // 
            // regionDescriptionLabel
            // 
            regionDescriptionLabel.AutoSize = true;
            regionDescriptionLabel.Location = new System.Drawing.Point(393, 78);
            regionDescriptionLabel.Name = "regionDescriptionLabel";
            regionDescriptionLabel.Size = new System.Drawing.Size(142, 22);
            regionDescriptionLabel.TabIndex = 7;
            regionDescriptionLabel.Text = "Region Description:";
            // 
            // territoryIDLabel1
            // 
            territoryIDLabel1.AutoSize = true;
            territoryIDLabel1.Location = new System.Drawing.Point(23, 33);
            territoryIDLabel1.Name = "territoryIDLabel1";
            territoryIDLabel1.Size = new System.Drawing.Size(94, 22);
            territoryIDLabel1.TabIndex = 17;
            territoryIDLabel1.Text = "Territory ID:";
            // 
            // regionIDLabel2
            // 
            regionIDLabel2.AutoSize = true;
            regionIDLabel2.Location = new System.Drawing.Point(393, 30);
            regionIDLabel2.Name = "regionIDLabel2";
            regionIDLabel2.Size = new System.Drawing.Size(82, 22);
            regionIDLabel2.TabIndex = 18;
            regionIDLabel2.Text = "Region ID:";
            // 
            // regionIDTextBox
            // 
            this.regionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.territoriesBindingSource, "RegionID", true));
            this.regionIDTextBox.Location = new System.Drawing.Point(183, 122);
            this.regionIDTextBox.Name = "regionIDTextBox";
            this.regionIDTextBox.Size = new System.Drawing.Size(121, 29);
            this.regionIDTextBox.TabIndex = 2;
            // 
            // territoriesBindingSource
            // 
            this.territoriesBindingSource.DataSource = typeof(Project2.Territory);
            // 
            // territoryDescriptionTextBox
            // 
            this.territoryDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.territoriesBindingSource, "TerritoryDescription", true));
            this.territoryDescriptionTextBox.Location = new System.Drawing.Point(183, 75);
            this.territoryDescriptionTextBox.Name = "territoryDescriptionTextBox";
            this.territoryDescriptionTextBox.Size = new System.Drawing.Size(121, 29);
            this.territoryDescriptionTextBox.TabIndex = 4;
            // 
            // regionDescriptionTextBox
            // 
            this.regionDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regionBindingSource, "RegionDescription", true));
            this.regionDescriptionTextBox.Location = new System.Drawing.Point(541, 75);
            this.regionDescriptionTextBox.Name = "regionDescriptionTextBox";
            this.regionDescriptionTextBox.Size = new System.Drawing.Size(121, 29);
            this.regionDescriptionTextBox.TabIndex = 8;
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataSource = typeof(Project2.Region);
            // 
            // territoryIDComboBox
            // 
            this.territoryIDComboBox.DataSource = this.territoriesBindingSource;
            this.territoryIDComboBox.DisplayMember = "TerritoryID";
            this.territoryIDComboBox.FormattingEnabled = true;
            this.territoryIDComboBox.Location = new System.Drawing.Point(183, 27);
            this.territoryIDComboBox.Name = "territoryIDComboBox";
            this.territoryIDComboBox.Size = new System.Drawing.Size(121, 30);
            this.territoryIDComboBox.TabIndex = 18;
            this.territoryIDComboBox.ValueMember = "TerritoryID";
            // 
            // regionIDComboBox
            // 
            this.regionIDComboBox.DataSource = this.regionBindingSource;
            this.regionIDComboBox.DisplayMember = "RegionID";
            this.regionIDComboBox.FormattingEnabled = true;
            this.regionIDComboBox.Location = new System.Drawing.Point(541, 30);
            this.regionIDComboBox.Name = "regionIDComboBox";
            this.regionIDComboBox.Size = new System.Drawing.Size(121, 30);
            this.regionIDComboBox.TabIndex = 19;
            this.regionIDComboBox.ValueMember = "RegionID";
            // 
            // btnDeleteTerr
            // 
            this.btnDeleteTerr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTerr.Location = new System.Drawing.Point(233, 188);
            this.btnDeleteTerr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteTerr.Name = "btnDeleteTerr";
            this.btnDeleteTerr.Size = new System.Drawing.Size(71, 32);
            this.btnDeleteTerr.TabIndex = 22;
            this.btnDeleteTerr.Text = "Delete";
            this.btnDeleteTerr.UseVisualStyleBackColor = true;
            this.btnDeleteTerr.Click += new System.EventHandler(this.btnDeleteTerr_Click);
            // 
            // btnEditTerr
            // 
            this.btnEditTerr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditTerr.Location = new System.Drawing.Point(168, 188);
            this.btnEditTerr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditTerr.Name = "btnEditTerr";
            this.btnEditTerr.Size = new System.Drawing.Size(57, 32);
            this.btnEditTerr.TabIndex = 21;
            this.btnEditTerr.Text = "Edit";
            this.btnEditTerr.UseVisualStyleBackColor = true;
            this.btnEditTerr.Click += new System.EventHandler(this.btnEditTerr_Click);
            // 
            // btnAddTerr
            // 
            this.btnAddTerr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTerr.Location = new System.Drawing.Point(103, 188);
            this.btnAddTerr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTerr.Name = "btnAddTerr";
            this.btnAddTerr.Size = new System.Drawing.Size(57, 32);
            this.btnAddTerr.TabIndex = 20;
            this.btnAddTerr.Text = "Add";
            this.btnAddTerr.UseVisualStyleBackColor = true;
            this.btnAddTerr.Click += new System.EventHandler(this.btnAddTerr_Click);
            // 
            // btnNewTer
            // 
            this.btnNewTer.Location = new System.Drawing.Point(38, 188);
            this.btnNewTer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewTer.Name = "btnNewTer";
            this.btnNewTer.Size = new System.Drawing.Size(57, 32);
            this.btnNewTer.TabIndex = 23;
            this.btnNewTer.Text = "New";
            this.btnNewTer.UseVisualStyleBackColor = true;
            this.btnNewTer.Click += new System.EventHandler(this.btnNewTer_Click);
            // 
            // btnNewReg
            // 
            this.btnNewReg.Location = new System.Drawing.Point(397, 188);
            this.btnNewReg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewReg.Name = "btnNewReg";
            this.btnNewReg.Size = new System.Drawing.Size(57, 32);
            this.btnNewReg.TabIndex = 27;
            this.btnNewReg.Text = "New";
            this.btnNewReg.UseVisualStyleBackColor = true;
            this.btnNewReg.Click += new System.EventHandler(this.btnNewReg_Click);
            // 
            // btnDeleteReg
            // 
            this.btnDeleteReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteReg.Location = new System.Drawing.Point(592, 188);
            this.btnDeleteReg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteReg.Name = "btnDeleteReg";
            this.btnDeleteReg.Size = new System.Drawing.Size(71, 32);
            this.btnDeleteReg.TabIndex = 26;
            this.btnDeleteReg.Text = "Delete";
            this.btnDeleteReg.UseVisualStyleBackColor = true;
            this.btnDeleteReg.Click += new System.EventHandler(this.btnDeleteReg_Click);
            // 
            // btnEditReg
            // 
            this.btnEditReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditReg.Location = new System.Drawing.Point(527, 188);
            this.btnEditReg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditReg.Name = "btnEditReg";
            this.btnEditReg.Size = new System.Drawing.Size(57, 32);
            this.btnEditReg.TabIndex = 25;
            this.btnEditReg.Text = "Edit";
            this.btnEditReg.UseVisualStyleBackColor = true;
            this.btnEditReg.Click += new System.EventHandler(this.btnEditReg_Click);
            // 
            // btnAddReg
            // 
            this.btnAddReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddReg.Location = new System.Drawing.Point(462, 188);
            this.btnAddReg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddReg.Name = "btnAddReg";
            this.btnAddReg.Size = new System.Drawing.Size(57, 32);
            this.btnAddReg.TabIndex = 24;
            this.btnAddReg.Text = "Add";
            this.btnAddReg.UseVisualStyleBackColor = true;
            this.btnAddReg.Click += new System.EventHandler(this.btnAddReg_Click);
            // 
            // TerritoriesAndRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 234);
            this.Controls.Add(this.btnNewReg);
            this.Controls.Add(this.btnDeleteReg);
            this.Controls.Add(this.btnEditReg);
            this.Controls.Add(this.btnAddReg);
            this.Controls.Add(this.btnNewTer);
            this.Controls.Add(this.btnDeleteTerr);
            this.Controls.Add(this.btnEditTerr);
            this.Controls.Add(this.btnAddTerr);
            this.Controls.Add(regionIDLabel2);
            this.Controls.Add(this.regionIDComboBox);
            this.Controls.Add(territoryIDLabel1);
            this.Controls.Add(this.territoryIDComboBox);
            this.Controls.Add(regionDescriptionLabel);
            this.Controls.Add(this.regionDescriptionTextBox);
            this.Controls.Add(regionIDLabel);
            this.Controls.Add(this.regionIDTextBox);
            this.Controls.Add(territoryDescriptionLabel);
            this.Controls.Add(this.territoryDescriptionTextBox);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TerritoriesAndRegion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.TerritoriesAndRegion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.territoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource territoriesBindingSource;
        private System.Windows.Forms.TextBox regionIDTextBox;
        private System.Windows.Forms.TextBox territoryDescriptionTextBox;
        private System.Windows.Forms.TextBox regionDescriptionTextBox;
        private System.Windows.Forms.ComboBox territoryIDComboBox;
        private System.Windows.Forms.ComboBox regionIDComboBox;
        private System.Windows.Forms.Button btnDeleteTerr;
        private System.Windows.Forms.Button btnEditTerr;
        private System.Windows.Forms.Button btnAddTerr;
        private System.Windows.Forms.Button btnNewTer;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private System.Windows.Forms.Button btnNewReg;
        private System.Windows.Forms.Button btnDeleteReg;
        private System.Windows.Forms.Button btnEditReg;
        private System.Windows.Forms.Button btnAddReg;
    }
}