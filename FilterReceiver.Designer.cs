
namespace BloodForLifeProject
{
    partial class FilterReceiver
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
            this.panelfilter = new System.Windows.Forms.Panel();
            this.lbfilterby = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbByGroup = new System.Windows.Forms.ComboBox();
            this.cbByGender = new System.Windows.Forms.ComboBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.gridFilter = new System.Windows.Forms.DataGridView();
            this.btngSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btngGoback = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btngPrint = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelfilter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFilter)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelfilter
            // 
            this.panelfilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.panelfilter.Controls.Add(this.lbfilterby);
            this.panelfilter.Location = new System.Drawing.Point(3, 3);
            this.panelfilter.Name = "panelfilter";
            this.panelfilter.Size = new System.Drawing.Size(1126, 34);
            this.panelfilter.TabIndex = 0;
            // 
            // lbfilterby
            // 
            this.lbfilterby.AutoSize = true;
            this.lbfilterby.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfilterby.Location = new System.Drawing.Point(9, 4);
            this.lbfilterby.Name = "lbfilterby";
            this.lbfilterby.Size = new System.Drawing.Size(109, 27);
            this.lbfilterby.TabIndex = 1;
            this.lbfilterby.Text = "Filter By :";
            this.lbfilterby.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.btngSearch);
            this.panel1.Controls.Add(this.textBox_search);
            this.panel1.Controls.Add(this.cbByGender);
            this.panel1.Controls.Add(this.cbByGroup);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(124, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 34);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blood Group :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(271, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gender :";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbByGroup
            // 
            this.cbByGroup.FormattingEnabled = true;
            this.cbByGroup.Items.AddRange(new object[] {
            "O +",
            "O -",
            "A +",
            "A -",
            "B +",
            "B -",
            "AB +",
            "AB -"});
            this.cbByGroup.Location = new System.Drawing.Point(108, 13);
            this.cbByGroup.Name = "cbByGroup";
            this.cbByGroup.Size = new System.Drawing.Size(85, 21);
            this.cbByGroup.TabIndex = 2;
            this.cbByGroup.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbByGender
            // 
            this.cbByGender.FormattingEnabled = true;
            this.cbByGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbByGender.Location = new System.Drawing.Point(342, 12);
            this.cbByGender.Name = "cbByGender";
            this.cbByGender.Size = new System.Drawing.Size(85, 21);
            this.cbByGender.TabIndex = 3;
            this.cbByGender.SelectedIndexChanged += new System.EventHandler(this.cbByGender_SelectedIndexChanged);
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.Location = new System.Drawing.Point(471, 5);
            this.textBox_search.Multiline = true;
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(167, 27);
            this.textBox_search.TabIndex = 39;
            // 
            // gridFilter
            // 
            this.gridFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFilter.Location = new System.Drawing.Point(3, 44);
            this.gridFilter.Name = "gridFilter";
            this.gridFilter.Size = new System.Drawing.Size(1119, 529);
            this.gridFilter.TabIndex = 1;
            // 
            // btngSearch
            // 
            this.btngSearch.AutoRoundedCorners = true;
            this.btngSearch.BorderRadius = 13;
            this.btngSearch.CheckedState.Parent = this.btngSearch;
            this.btngSearch.CustomImages.Parent = this.btngSearch;
            this.btngSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngSearch.DisabledState.Parent = this.btngSearch;
            this.btngSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btngSearch.ForeColor = System.Drawing.Color.White;
            this.btngSearch.HoverState.Parent = this.btngSearch;
            this.btngSearch.Location = new System.Drawing.Point(643, 3);
            this.btngSearch.Name = "btngSearch";
            this.btngSearch.ShadowDecoration.Parent = this.btngSearch;
            this.btngSearch.Size = new System.Drawing.Size(135, 29);
            this.btngSearch.TabIndex = 41;
            this.btngSearch.Text = "Search";
            this.btngSearch.Click += new System.EventHandler(this.btngSearch_Click);
            // 
            // btngGoback
            // 
            this.btngGoback.AutoRoundedCorners = true;
            this.btngGoback.BorderRadius = 14;
            this.btngGoback.CheckedState.Parent = this.btngGoback;
            this.btngGoback.CustomImages.Parent = this.btngGoback;
            this.btngGoback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngGoback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngGoback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngGoback.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngGoback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngGoback.DisabledState.Parent = this.btngGoback;
            this.btngGoback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btngGoback.ForeColor = System.Drawing.Color.White;
            this.btngGoback.HoverState.Parent = this.btngGoback;
            this.btngGoback.Location = new System.Drawing.Point(1, 1);
            this.btngGoback.Name = "btngGoback";
            this.btngGoback.ShadowDecoration.Parent = this.btngGoback;
            this.btngGoback.Size = new System.Drawing.Size(135, 31);
            this.btngGoback.TabIndex = 41;
            this.btngGoback.Text = "Go Back";
            this.btngGoback.Click += new System.EventHandler(this.btngGoback_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btngPrint);
            this.guna2GradientPanel1.Controls.Add(this.btngGoback);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Purple;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(3, 575);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1119, 33);
            this.guna2GradientPanel1.TabIndex = 2;
            // 
            // btngPrint
            // 
            this.btngPrint.AutoRoundedCorners = true;
            this.btngPrint.BorderRadius = 14;
            this.btngPrint.CheckedState.Parent = this.btngPrint;
            this.btngPrint.CustomImages.Parent = this.btngPrint;
            this.btngPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngPrint.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngPrint.DisabledState.Parent = this.btngPrint;
            this.btngPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btngPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btngPrint.ForeColor = System.Drawing.Color.White;
            this.btngPrint.HoverState.Parent = this.btngPrint;
            this.btngPrint.Location = new System.Drawing.Point(981, 1);
            this.btngPrint.Name = "btngPrint";
            this.btngPrint.ShadowDecoration.Parent = this.btngPrint;
            this.btngPrint.Size = new System.Drawing.Size(135, 31);
            this.btngPrint.TabIndex = 41;
            this.btngPrint.Text = "Print";
            this.btngPrint.Click += new System.EventHandler(this.btngPrint_Click);
            // 
            // FilterReceiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.gridFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelfilter);
            this.Name = "FilterReceiver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterReceiver";
            this.panelfilter.ResumeLayout(false);
            this.panelfilter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFilter)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelfilter;
        private System.Windows.Forms.Label lbfilterby;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbByGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbByGender;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.DataGridView gridFilter;
        private Guna.UI2.WinForms.Guna2GradientButton btngSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btngGoback;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btngPrint;
    }
}