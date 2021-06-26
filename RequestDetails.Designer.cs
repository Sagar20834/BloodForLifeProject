
namespace BloodForLifeProject
{
    partial class RequestDetails
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
            this.gridrequestdetails = new System.Windows.Forms.DataGridView();
            this.btngoback = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnprintit = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridrequestdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // gridrequestdetails
            // 
            this.gridrequestdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridrequestdetails.Location = new System.Drawing.Point(2, 3);
            this.gridrequestdetails.Name = "gridrequestdetails";
            this.gridrequestdetails.Size = new System.Drawing.Size(1130, 568);
            this.gridrequestdetails.TabIndex = 0;
            // 
            // btngoback
            // 
            this.btngoback.AutoRoundedCorners = true;
            this.btngoback.BorderRadius = 17;
            this.btngoback.CheckedState.Parent = this.btngoback;
            this.btngoback.CustomImages.Parent = this.btngoback;
            this.btngoback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngoback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngoback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngoback.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngoback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngoback.DisabledState.Parent = this.btngoback;
            this.btngoback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btngoback.ForeColor = System.Drawing.Color.White;
            this.btngoback.HoverState.Parent = this.btngoback;
            this.btngoback.Location = new System.Drawing.Point(20, 573);
            this.btngoback.Name = "btngoback";
            this.btngoback.ShadowDecoration.Parent = this.btngoback;
            this.btngoback.Size = new System.Drawing.Size(145, 36);
            this.btngoback.TabIndex = 44;
            this.btngoback.Text = "Go Back";
            this.btngoback.Click += new System.EventHandler(this.btngoback_Click);
            // 
            // btnprintit
            // 
            this.btnprintit.AutoRoundedCorners = true;
            this.btnprintit.BorderRadius = 16;
            this.btnprintit.CheckedState.Parent = this.btnprintit;
            this.btnprintit.CustomImages.Parent = this.btnprintit;
            this.btnprintit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnprintit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnprintit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnprintit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnprintit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnprintit.DisabledState.Parent = this.btnprintit;
            this.btnprintit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnprintit.ForeColor = System.Drawing.Color.White;
            this.btnprintit.HoverState.Parent = this.btnprintit;
            this.btnprintit.Location = new System.Drawing.Point(958, 573);
            this.btnprintit.Name = "btnprintit";
            this.btnprintit.ShadowDecoration.Parent = this.btnprintit;
            this.btnprintit.Size = new System.Drawing.Size(154, 35);
            this.btnprintit.TabIndex = 44;
            this.btnprintit.Text = "Print";
            this.btnprintit.Click += new System.EventHandler(this.btnprintit_Click);
            // 
            // RequestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.btnprintit);
            this.Controls.Add(this.btngoback);
            this.Controls.Add(this.gridrequestdetails);
            this.Name = "RequestDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestDetails";
            this.Load += new System.EventHandler(this.RequestDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridrequestdetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridrequestdetails;
        private Guna.UI2.WinForms.Guna2GradientButton btngoback;
        private Guna.UI2.WinForms.Guna2GradientButton btnprintit;
    }
}