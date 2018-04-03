namespace Project2
{
    partial class UpdateEmpTerr
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
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label territoryIDLabel;
            System.Windows.Forms.Label territoryDescriptionLabel;
            System.Windows.Forms.Label regionIDLabel;
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.territoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDistribution = new System.Windows.Forms.Button();
            this.employeeIDComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.territoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.territoryDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.regionIDTextBox = new System.Windows.Forms.TextBox();
            employeeIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            territoryIDLabel = new System.Windows.Forms.Label();
            territoryDescriptionLabel = new System.Windows.Forms.Label();
            regionIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(26, 32);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(103, 22);
            employeeIDLabel.TabIndex = 1;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(25, 121);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(90, 22);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(26, 76);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(89, 22);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // territoryIDLabel
            // 
            territoryIDLabel.AutoSize = true;
            territoryIDLabel.Location = new System.Drawing.Point(321, 32);
            territoryIDLabel.Name = "territoryIDLabel";
            territoryIDLabel.Size = new System.Drawing.Size(94, 22);
            territoryIDLabel.TabIndex = 7;
            territoryIDLabel.Text = "Territory ID:";
            // 
            // territoryDescriptionLabel
            // 
            territoryDescriptionLabel.AutoSize = true;
            territoryDescriptionLabel.Location = new System.Drawing.Point(321, 76);
            territoryDescriptionLabel.Name = "territoryDescriptionLabel";
            territoryDescriptionLabel.Size = new System.Drawing.Size(154, 22);
            territoryDescriptionLabel.TabIndex = 9;
            territoryDescriptionLabel.Text = "Territory Description:";
            // 
            // regionIDLabel
            // 
            regionIDLabel.AutoSize = true;
            regionIDLabel.Location = new System.Drawing.Point(321, 121);
            regionIDLabel.Name = "regionIDLabel";
            regionIDLabel.Size = new System.Drawing.Size(82, 22);
            regionIDLabel.TabIndex = 11;
            regionIDLabel.Text = "Region ID:";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Project2.Employee);
            // 
            // territoryBindingSource
            // 
            this.territoryBindingSource.DataSource = typeof(Project2.Territory);
            // 
            // btnDistribution
            // 
            this.btnDistribution.Location = new System.Drawing.Point(152, 185);
            this.btnDistribution.Name = "btnDistribution";
            this.btnDistribution.Size = new System.Drawing.Size(362, 36);
            this.btnDistribution.TabIndex = 0;
            this.btnDistribution.Text = "&Distribution";
            this.btnDistribution.UseVisualStyleBackColor = true;
            this.btnDistribution.Click += new System.EventHandler(this.btnDistribution_Click);
            // 
            // employeeIDComboBox
            // 
            this.employeeIDComboBox.DataSource = this.employeeBindingSource;
            this.employeeIDComboBox.DisplayMember = "EmployeeID";
            this.employeeIDComboBox.FormattingEnabled = true;
            this.employeeIDComboBox.Location = new System.Drawing.Point(135, 29);
            this.employeeIDComboBox.Name = "employeeIDComboBox";
            this.employeeIDComboBox.Size = new System.Drawing.Size(121, 30);
            this.employeeIDComboBox.TabIndex = 2;
            this.employeeIDComboBox.ValueMember = "EmployeeID";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(135, 118);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(121, 29);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(135, 73);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(121, 29);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // territoryIDComboBox
            // 
            this.territoryIDComboBox.DataSource = this.territoryBindingSource;
            this.territoryIDComboBox.FormattingEnabled = true;
            this.territoryIDComboBox.Location = new System.Drawing.Point(481, 29);
            this.territoryIDComboBox.Name = "territoryIDComboBox";
            this.territoryIDComboBox.Size = new System.Drawing.Size(121, 30);
            this.territoryIDComboBox.TabIndex = 8;
            this.territoryIDComboBox.ValueMember = "TerritoryID";
            // 
            // territoryDescriptionTextBox
            // 
            this.territoryDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.territoryBindingSource, "TerritoryDescription", true));
            this.territoryDescriptionTextBox.Location = new System.Drawing.Point(481, 73);
            this.territoryDescriptionTextBox.Name = "territoryDescriptionTextBox";
            this.territoryDescriptionTextBox.Size = new System.Drawing.Size(121, 29);
            this.territoryDescriptionTextBox.TabIndex = 10;
            // 
            // regionIDTextBox
            // 
            this.regionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.territoryBindingSource, "RegionID", true));
            this.regionIDTextBox.Location = new System.Drawing.Point(481, 118);
            this.regionIDTextBox.Name = "regionIDTextBox";
            this.regionIDTextBox.Size = new System.Drawing.Size(121, 29);
            this.regionIDTextBox.TabIndex = 12;
            // 
            // UpdateEmpTerr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 245);
            this.Controls.Add(regionIDLabel);
            this.Controls.Add(this.regionIDTextBox);
            this.Controls.Add(territoryDescriptionLabel);
            this.Controls.Add(this.territoryDescriptionTextBox);
            this.Controls.Add(territoryIDLabel);
            this.Controls.Add(this.territoryIDComboBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDComboBox);
            this.Controls.Add(this.btnDistribution);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "UpdateEmpTerr";
            this.Text = "Distribution of employees across territories";
            this.Load += new System.EventHandler(this.UpdateEmpTerr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource territoryBindingSource;
        private System.Windows.Forms.Button btnDistribution;
        private System.Windows.Forms.ComboBox employeeIDComboBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ComboBox territoryIDComboBox;
        private System.Windows.Forms.TextBox territoryDescriptionTextBox;
        private System.Windows.Forms.TextBox regionIDTextBox;
    }
}