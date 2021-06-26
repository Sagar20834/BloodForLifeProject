
namespace BloodForLifeProject
{
    partial class DonorRegisration
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
            this.griddonor = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.donorDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodForLifeDataSet1 = new BloodForLifeProject.BloodForLifeDataSet1();
            this.gbdonor = new System.Windows.Forms.GroupBox();
            this.btngUpload = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btngDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btngClear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btngUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btngSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbBgroup = new System.Windows.Forms.ComboBox();
            this.pbDRprofile = new System.Windows.Forms.PictureBox();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.dtDRnow = new System.Windows.Forms.DateTimePicker();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.donorDetailTableAdapter = new BloodForLifeProject.BloodForLifeDataSet1TableAdapters.DonorDetailTableAdapter();
            this.btngsearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btngrefrexh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btngback = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.griddonor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodForLifeDataSet1)).BeginInit();
            this.gbdonor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDRprofile)).BeginInit();
            this.SuspendLayout();
            // 
            // griddonor
            // 
            this.griddonor.AllowUserToAddRows = false;
            this.griddonor.AllowUserToDeleteRows = false;
            this.griddonor.AutoGenerateColumns = false;
            this.griddonor.BackgroundColor = System.Drawing.Color.Silver;
            this.griddonor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddonor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.bloodgroupDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.griddonor.DataSource = this.donorDetailBindingSource;
            this.griddonor.Location = new System.Drawing.Point(12, 38);
            this.griddonor.Name = "griddonor";
            this.griddonor.Size = new System.Drawing.Size(1110, 282);
            this.griddonor.TabIndex = 0;
            this.griddonor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.griddonor_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "dateofbirth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "dateofbirth";
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // bloodgroupDataGridViewTextBoxColumn
            // 
            this.bloodgroupDataGridViewTextBoxColumn.DataPropertyName = "bloodgroup";
            this.bloodgroupDataGridViewTextBoxColumn.HeaderText = "bloodgroup";
            this.bloodgroupDataGridViewTextBoxColumn.Name = "bloodgroupDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "image";
            this.imageDataGridViewImageColumn.HeaderText = "image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // donorDetailBindingSource
            // 
            this.donorDetailBindingSource.DataMember = "DonorDetail";
            this.donorDetailBindingSource.DataSource = this.bloodForLifeDataSet1;
            // 
            // bloodForLifeDataSet1
            // 
            this.bloodForLifeDataSet1.DataSetName = "BloodForLifeDataSet1";
            this.bloodForLifeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbdonor
            // 
            this.gbdonor.Controls.Add(this.btngUpload);
            this.gbdonor.Controls.Add(this.btngDelete);
            this.gbdonor.Controls.Add(this.btngClear);
            this.gbdonor.Controls.Add(this.btngUpdate);
            this.gbdonor.Controls.Add(this.btngSave);
            this.gbdonor.Controls.Add(this.cbBgroup);
            this.gbdonor.Controls.Add(this.pbDRprofile);
            this.gbdonor.Controls.Add(this.rbfemale);
            this.gbdonor.Controls.Add(this.rbmale);
            this.gbdonor.Controls.Add(this.dtDRnow);
            this.gbdonor.Controls.Add(this.tbPhone);
            this.gbdonor.Controls.Add(this.label3);
            this.gbdonor.Controls.Add(this.tbLname);
            this.gbdonor.Controls.Add(this.label2);
            this.gbdonor.Controls.Add(this.tbAddress);
            this.gbdonor.Controls.Add(this.tbid);
            this.gbdonor.Controls.Add(this.tbFname);
            this.gbdonor.Controls.Add(this.label5);
            this.gbdonor.Controls.Add(this.label4);
            this.gbdonor.Controls.Add(this.label7);
            this.gbdonor.Controls.Add(this.label6);
            this.gbdonor.Controls.Add(this.label8);
            this.gbdonor.Controls.Add(this.label1);
            this.gbdonor.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdonor.Location = new System.Drawing.Point(12, 350);
            this.gbdonor.Name = "gbdonor";
            this.gbdonor.Size = new System.Drawing.Size(1110, 249);
            this.gbdonor.TabIndex = 1;
            this.gbdonor.TabStop = false;
            this.gbdonor.Text = "Donor Module";
            // 
            // btngUpload
            // 
            this.btngUpload.AutoRoundedCorners = true;
            this.btngUpload.BorderRadius = 21;
            this.btngUpload.CheckedState.Parent = this.btngUpload;
            this.btngUpload.CustomImages.Parent = this.btngUpload;
            this.btngUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngUpload.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngUpload.DisabledState.Parent = this.btngUpload;
            this.btngUpload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btngUpload.ForeColor = System.Drawing.Color.White;
            this.btngUpload.HoverState.Parent = this.btngUpload;
            this.btngUpload.Location = new System.Drawing.Point(955, 153);
            this.btngUpload.Name = "btngUpload";
            this.btngUpload.ShadowDecoration.Parent = this.btngUpload;
            this.btngUpload.Size = new System.Drawing.Size(154, 45);
            this.btngUpload.TabIndex = 40;
            this.btngUpload.Text = "Upload";
            this.btngUpload.Click += new System.EventHandler(this.btngUpload_Click);
            // 
            // btngDelete
            // 
            this.btngDelete.AutoRoundedCorners = true;
            this.btngDelete.BorderRadius = 21;
            this.btngDelete.CheckedState.Parent = this.btngDelete;
            this.btngDelete.CustomImages.Parent = this.btngDelete;
            this.btngDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngDelete.DisabledState.Parent = this.btngDelete;
            this.btngDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btngDelete.ForeColor = System.Drawing.Color.White;
            this.btngDelete.HoverState.Parent = this.btngDelete;
            this.btngDelete.Location = new System.Drawing.Point(754, 204);
            this.btngDelete.Name = "btngDelete";
            this.btngDelete.ShadowDecoration.Parent = this.btngDelete;
            this.btngDelete.Size = new System.Drawing.Size(154, 45);
            this.btngDelete.TabIndex = 41;
            this.btngDelete.Text = "Delete";
            this.btngDelete.Click += new System.EventHandler(this.btngDelete_Click);
            // 
            // btngClear
            // 
            this.btngClear.AutoRoundedCorners = true;
            this.btngClear.BorderRadius = 21;
            this.btngClear.CheckedState.Parent = this.btngClear;
            this.btngClear.CustomImages.Parent = this.btngClear;
            this.btngClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngClear.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngClear.DisabledState.Parent = this.btngClear;
            this.btngClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btngClear.ForeColor = System.Drawing.Color.White;
            this.btngClear.HoverState.Parent = this.btngClear;
            this.btngClear.Location = new System.Drawing.Point(955, 204);
            this.btngClear.Name = "btngClear";
            this.btngClear.ShadowDecoration.Parent = this.btngClear;
            this.btngClear.Size = new System.Drawing.Size(154, 45);
            this.btngClear.TabIndex = 42;
            this.btngClear.Text = "Clear";
            this.btngClear.Click += new System.EventHandler(this.btngClear_Click);
            // 
            // btngUpdate
            // 
            this.btngUpdate.AutoRoundedCorners = true;
            this.btngUpdate.BorderRadius = 21;
            this.btngUpdate.CheckedState.Parent = this.btngUpdate;
            this.btngUpdate.CustomImages.Parent = this.btngUpdate;
            this.btngUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngUpdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngUpdate.DisabledState.Parent = this.btngUpdate;
            this.btngUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btngUpdate.ForeColor = System.Drawing.Color.White;
            this.btngUpdate.HoverState.Parent = this.btngUpdate;
            this.btngUpdate.Location = new System.Drawing.Point(575, 204);
            this.btngUpdate.Name = "btngUpdate";
            this.btngUpdate.ShadowDecoration.Parent = this.btngUpdate;
            this.btngUpdate.Size = new System.Drawing.Size(154, 45);
            this.btngUpdate.TabIndex = 43;
            this.btngUpdate.Text = "Update";
            this.btngUpdate.Click += new System.EventHandler(this.btngUpdate_Click);
            // 
            // btngSave
            // 
            this.btngSave.AutoRoundedCorners = true;
            this.btngSave.BorderRadius = 21;
            this.btngSave.CheckedState.Parent = this.btngSave;
            this.btngSave.CustomImages.Parent = this.btngSave;
            this.btngSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngSave.DisabledState.Parent = this.btngSave;
            this.btngSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btngSave.ForeColor = System.Drawing.Color.White;
            this.btngSave.HoverState.Parent = this.btngSave;
            this.btngSave.Location = new System.Drawing.Point(375, 204);
            this.btngSave.Name = "btngSave";
            this.btngSave.ShadowDecoration.Parent = this.btngSave;
            this.btngSave.Size = new System.Drawing.Size(154, 45);
            this.btngSave.TabIndex = 44;
            this.btngSave.Text = "Save";
            this.btngSave.Click += new System.EventHandler(this.btngSave_Click);
            // 
            // cbBgroup
            // 
            this.cbBgroup.FormattingEnabled = true;
            this.cbBgroup.Items.AddRange(new object[] {
            "O +",
            "O -",
            "A +",
            "A -",
            "B +",
            "B -",
            "AB +",
            "AB -"});
            this.cbBgroup.Location = new System.Drawing.Point(457, 142);
            this.cbBgroup.Name = "cbBgroup";
            this.cbBgroup.Size = new System.Drawing.Size(49, 25);
            this.cbBgroup.TabIndex = 38;
            // 
            // pbDRprofile
            // 
            this.pbDRprofile.BackColor = System.Drawing.Color.Gainsboro;
            this.pbDRprofile.Location = new System.Drawing.Point(976, 17);
            this.pbDRprofile.Name = "pbDRprofile";
            this.pbDRprofile.Size = new System.Drawing.Size(132, 130);
            this.pbDRprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDRprofile.TabIndex = 4;
            this.pbDRprofile.TabStop = false;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.rbfemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.rbfemale.Location = new System.Drawing.Point(643, 84);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(86, 23);
            this.rbfemale.TabIndex = 3;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Checked = true;
            this.rbmale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.rbmale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.rbmale.Location = new System.Drawing.Point(560, 82);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(66, 23);
            this.rbmale.TabIndex = 3;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // dtDRnow
            // 
            this.dtDRnow.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.dtDRnow.Location = new System.Drawing.Point(135, 82);
            this.dtDRnow.Name = "dtDRnow";
            this.dtDRnow.Size = new System.Drawing.Size(255, 25);
            this.dtDRnow.TabIndex = 2;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbPhone.Location = new System.Drawing.Point(777, 17);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(191, 27);
            this.tbPhone.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(707, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone :";
            // 
            // tbLname
            // 
            this.tbLname.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbLname.Location = new System.Drawing.Point(510, 17);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(191, 27);
            this.tbLname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(408, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name :";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbAddress.Location = new System.Drawing.Point(103, 138);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(192, 27);
            this.tbAddress.TabIndex = 1;
            // 
            // tbid
            // 
            this.tbid.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbid.Location = new System.Drawing.Point(36, 17);
            this.tbid.Name = "tbid";
            this.tbid.ReadOnly = true;
            this.tbid.Size = new System.Drawing.Size(65, 27);
            this.tbid.TabIndex = 1;
            // 
            // tbFname
            // 
            this.tbFname.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbFname.Location = new System.Drawing.Point(208, 17);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(191, 27);
            this.tbFname.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(453, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(19, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date Of Birth :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(336, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Blood Group :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(19, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(-2, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(107, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Location = new System.Drawing.Point(12, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 18);
            this.panel1.TabIndex = 2;
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.Location = new System.Drawing.Point(767, 7);
            this.textBox_search.Multiline = true;
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(167, 27);
            this.textBox_search.TabIndex = 34;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // donorDetailTableAdapter
            // 
            this.donorDetailTableAdapter.ClearBeforeFill = true;
            // 
            // btngsearch
            // 
            this.btngsearch.AutoRoundedCorners = true;
            this.btngsearch.BorderRadius = 16;
            this.btngsearch.CheckedState.Parent = this.btngsearch;
            this.btngsearch.CustomImages.Parent = this.btngsearch;
            this.btngsearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngsearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngsearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngsearch.DisabledState.Parent = this.btngsearch;
            this.btngsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btngsearch.ForeColor = System.Drawing.Color.White;
            this.btngsearch.HoverState.Parent = this.btngsearch;
            this.btngsearch.Location = new System.Drawing.Point(950, 3);
            this.btngsearch.Name = "btngsearch";
            this.btngsearch.ShadowDecoration.Parent = this.btngsearch;
            this.btngsearch.Size = new System.Drawing.Size(171, 34);
            this.btngsearch.TabIndex = 45;
            this.btngsearch.Text = "Search";
            this.btngsearch.Click += new System.EventHandler(this.btngsearch_Click);
            // 
            // btngrefrexh
            // 
            this.btngrefrexh.AutoRoundedCorners = true;
            this.btngrefrexh.BorderRadius = 16;
            this.btngrefrexh.CheckedState.Parent = this.btngrefrexh;
            this.btngrefrexh.CustomImages.Parent = this.btngrefrexh;
            this.btngrefrexh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngrefrexh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngrefrexh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngrefrexh.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngrefrexh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngrefrexh.DisabledState.Parent = this.btngrefrexh;
            this.btngrefrexh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btngrefrexh.ForeColor = System.Drawing.Color.White;
            this.btngrefrexh.HoverState.Parent = this.btngrefrexh;
            this.btngrefrexh.Location = new System.Drawing.Point(496, 3);
            this.btngrefrexh.Name = "btngrefrexh";
            this.btngrefrexh.ShadowDecoration.Parent = this.btngrefrexh;
            this.btngrefrexh.Size = new System.Drawing.Size(171, 34);
            this.btngrefrexh.TabIndex = 46;
            this.btngrefrexh.Text = "Refresh ";
            this.btngrefrexh.Click += new System.EventHandler(this.btngrefrexh_Click);
            // 
            // btngback
            // 
            this.btngback.AutoRoundedCorners = true;
            this.btngback.BorderRadius = 16;
            this.btngback.CheckedState.Parent = this.btngback;
            this.btngback.CustomImages.Parent = this.btngback;
            this.btngback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngback.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngback.DisabledState.Parent = this.btngback;
            this.btngback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btngback.ForeColor = System.Drawing.Color.White;
            this.btngback.HoverState.Parent = this.btngback;
            this.btngback.Location = new System.Drawing.Point(24, 2);
            this.btngback.Name = "btngback";
            this.btngback.ShadowDecoration.Parent = this.btngback;
            this.btngback.Size = new System.Drawing.Size(171, 35);
            this.btngback.TabIndex = 47;
            this.btngback.Text = "Back";
            this.btngback.Click += new System.EventHandler(this.btngback_Click);
            // 
            // DonorRegisration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.btngsearch);
            this.Controls.Add(this.btngrefrexh);
            this.Controls.Add(this.btngback);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbdonor);
            this.Controls.Add(this.griddonor);
            this.Name = "DonorRegisration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donor Registration";
            this.Load += new System.EventHandler(this.DonorRegisration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griddonor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodForLifeDataSet1)).EndInit();
            this.gbdonor.ResumeLayout(false);
            this.gbdonor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDRprofile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView griddonor;
        private System.Windows.Forms.GroupBox gbdonor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDRnow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.PictureBox pbDRprofile;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBgroup;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label label8;
        private BloodForLifeDataSet1 bloodForLifeDataSet1;
        private System.Windows.Forms.BindingSource donorDetailBindingSource;
        private BloodForLifeDataSet1TableAdapters.DonorDetailTableAdapter donorDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private Guna.UI2.WinForms.Guna2GradientButton btngUpload;
        private Guna.UI2.WinForms.Guna2GradientButton btngDelete;
        private Guna.UI2.WinForms.Guna2GradientButton btngClear;
        private Guna.UI2.WinForms.Guna2GradientButton btngUpdate;
        private Guna.UI2.WinForms.Guna2GradientButton btngSave;
        private Guna.UI2.WinForms.Guna2GradientButton btngsearch;
        private Guna.UI2.WinForms.Guna2GradientButton btngrefrexh;
        private Guna.UI2.WinForms.Guna2GradientButton btngback;
    }
}