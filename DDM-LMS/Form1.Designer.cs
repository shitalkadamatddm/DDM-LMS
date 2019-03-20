namespace DDM_LMS
{
    partial class HRdashboard
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.textBoxUserNameHrDash = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.SlidingPaneltoggleButton = new System.Windows.Forms.Button();
            this.btnLogOutHrDash = new System.Windows.Forms.Button();
            this.btnAddStaffHrDash = new System.Windows.Forms.Button();
            this.btnHolidayCalenderHrDash = new System.Windows.Forms.Button();
            this.btnLeavesRequestHrDash = new System.Windows.Forms.Button();
            this.btnStaffAvailabilityHrDash = new System.Windows.Forms.Button();
            this.btnEditStaffHrDash = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DarkGray;
            this.panelLeft.Controls.Add(this.SlidingPaneltoggleButton);
            this.panelLeft.Controls.Add(this.textBoxUserNameHrDash);
            this.panelLeft.Controls.Add(this.btnLogOutHrDash);
            this.panelLeft.Controls.Add(this.btnAddStaffHrDash);
            this.panelLeft.Controls.Add(this.btnHolidayCalenderHrDash);
            this.panelLeft.Controls.Add(this.btnLeavesRequestHrDash);
            this.panelLeft.Controls.Add(this.btnStaffAvailabilityHrDash);
            this.panelLeft.Controls.Add(this.btnEditStaffHrDash);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(256, 561);
            this.panelLeft.TabIndex = 0;
            // 
            // textBoxUserNameHrDash
            // 
            this.textBoxUserNameHrDash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUserNameHrDash.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxUserNameHrDash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserNameHrDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserNameHrDash.ForeColor = System.Drawing.Color.White;
            this.textBoxUserNameHrDash.Location = new System.Drawing.Point(40, 62);
            this.textBoxUserNameHrDash.Name = "textBoxUserNameHrDash";
            this.textBoxUserNameHrDash.Size = new System.Drawing.Size(155, 19);
            this.textBoxUserNameHrDash.TabIndex = 13;
            this.textBoxUserNameHrDash.Text = "User\'s  Name";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(915, 611);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(262, 1);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(722, 560);
            this.contentPanel.TabIndex = 4;
            // 
            // SlidingPaneltoggleButton
            // 
            this.SlidingPaneltoggleButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.SlidingPaneltoggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidingPaneltoggleButton.ForeColor = System.Drawing.Color.DarkGray;
            this.SlidingPaneltoggleButton.Image = global::DDM_LMS.Properties.Resources.Menu_icon32;
            this.SlidingPaneltoggleButton.Location = new System.Drawing.Point(0, 0);
            this.SlidingPaneltoggleButton.Name = "SlidingPaneltoggleButton";
            this.SlidingPaneltoggleButton.Size = new System.Drawing.Size(57, 56);
            this.SlidingPaneltoggleButton.TabIndex = 0;
            this.SlidingPaneltoggleButton.UseVisualStyleBackColor = true;
            this.SlidingPaneltoggleButton.Click += new System.EventHandler(this.SlidingPaneltoggleButton_Click);
            // 
            // btnLogOutHrDash
            // 
            this.btnLogOutHrDash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLogOutHrDash.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOutHrDash.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogOutHrDash.FlatAppearance.BorderSize = 0;
            this.btnLogOutHrDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOutHrDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOutHrDash.ForeColor = System.Drawing.Color.White;
            this.btnLogOutHrDash.Image = global::DDM_LMS.Properties.Resources.Logout_32;
            this.btnLogOutHrDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOutHrDash.Location = new System.Drawing.Point(0, 470);
            this.btnLogOutHrDash.Name = "btnLogOutHrDash";
            this.btnLogOutHrDash.Size = new System.Drawing.Size(250, 60);
            this.btnLogOutHrDash.TabIndex = 12;
            this.btnLogOutHrDash.Text = "Log Out";
            this.btnLogOutHrDash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOutHrDash.UseVisualStyleBackColor = false;
            this.btnLogOutHrDash.Click += new System.EventHandler(this.btnLogOutHrDash_Click);
            // 
            // btnAddStaffHrDash
            // 
            this.btnAddStaffHrDash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddStaffHrDash.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStaffHrDash.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddStaffHrDash.FlatAppearance.BorderSize = 0;
            this.btnAddStaffHrDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaffHrDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaffHrDash.ForeColor = System.Drawing.Color.White;
            this.btnAddStaffHrDash.Image = global::DDM_LMS.Properties.Resources.Person_white_add_32__1_;
            this.btnAddStaffHrDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStaffHrDash.Location = new System.Drawing.Point(3, 99);
            this.btnAddStaffHrDash.Name = "btnAddStaffHrDash";
            this.btnAddStaffHrDash.Size = new System.Drawing.Size(250, 60);
            this.btnAddStaffHrDash.TabIndex = 7;
            this.btnAddStaffHrDash.Text = "Add Staff";
            this.btnAddStaffHrDash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStaffHrDash.UseVisualStyleBackColor = false;
            this.btnAddStaffHrDash.Click += new System.EventHandler(this.btnAddStaffHrDash_Click);
            // 
            // btnHolidayCalenderHrDash
            // 
            this.btnHolidayCalenderHrDash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHolidayCalenderHrDash.BackColor = System.Drawing.Color.Transparent;
            this.btnHolidayCalenderHrDash.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHolidayCalenderHrDash.FlatAppearance.BorderSize = 0;
            this.btnHolidayCalenderHrDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHolidayCalenderHrDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHolidayCalenderHrDash.ForeColor = System.Drawing.Color.White;
            this.btnHolidayCalenderHrDash.Image = global::DDM_LMS.Properties.Resources.New_Year_Calendar_32;
            this.btnHolidayCalenderHrDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHolidayCalenderHrDash.Location = new System.Drawing.Point(0, 396);
            this.btnHolidayCalenderHrDash.Name = "btnHolidayCalenderHrDash";
            this.btnHolidayCalenderHrDash.Size = new System.Drawing.Size(250, 60);
            this.btnHolidayCalenderHrDash.TabIndex = 11;
            this.btnHolidayCalenderHrDash.Text = "Office Holiday Calender";
            this.btnHolidayCalenderHrDash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHolidayCalenderHrDash.UseVisualStyleBackColor = false;
            // 
            // btnLeavesRequestHrDash
            // 
            this.btnLeavesRequestHrDash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLeavesRequestHrDash.BackColor = System.Drawing.Color.Transparent;
            this.btnLeavesRequestHrDash.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLeavesRequestHrDash.FlatAppearance.BorderSize = 0;
            this.btnLeavesRequestHrDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeavesRequestHrDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeavesRequestHrDash.ForeColor = System.Drawing.Color.White;
            this.btnLeavesRequestHrDash.Image = global::DDM_LMS.Properties.Resources.Gnome_X_Office_Spreadsheet_32;
            this.btnLeavesRequestHrDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeavesRequestHrDash.Location = new System.Drawing.Point(0, 248);
            this.btnLeavesRequestHrDash.Name = "btnLeavesRequestHrDash";
            this.btnLeavesRequestHrDash.Size = new System.Drawing.Size(250, 60);
            this.btnLeavesRequestHrDash.TabIndex = 8;
            this.btnLeavesRequestHrDash.Text = "Leaves Request";
            this.btnLeavesRequestHrDash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLeavesRequestHrDash.UseVisualStyleBackColor = false;
            // 
            // btnStaffAvailabilityHrDash
            // 
            this.btnStaffAvailabilityHrDash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStaffAvailabilityHrDash.BackColor = System.Drawing.Color.Transparent;
            this.btnStaffAvailabilityHrDash.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStaffAvailabilityHrDash.FlatAppearance.BorderSize = 0;
            this.btnStaffAvailabilityHrDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffAvailabilityHrDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffAvailabilityHrDash.ForeColor = System.Drawing.Color.White;
            this.btnStaffAvailabilityHrDash.Image = global::DDM_LMS.Properties.Resources.User_Info_32;
            this.btnStaffAvailabilityHrDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffAvailabilityHrDash.Location = new System.Drawing.Point(0, 322);
            this.btnStaffAvailabilityHrDash.Name = "btnStaffAvailabilityHrDash";
            this.btnStaffAvailabilityHrDash.Size = new System.Drawing.Size(244, 60);
            this.btnStaffAvailabilityHrDash.TabIndex = 10;
            this.btnStaffAvailabilityHrDash.Text = "Staff Availability";
            this.btnStaffAvailabilityHrDash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaffAvailabilityHrDash.UseVisualStyleBackColor = false;
            // 
            // btnEditStaffHrDash
            // 
            this.btnEditStaffHrDash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEditStaffHrDash.BackColor = System.Drawing.Color.Transparent;
            this.btnEditStaffHrDash.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditStaffHrDash.FlatAppearance.BorderSize = 0;
            this.btnEditStaffHrDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStaffHrDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStaffHrDash.ForeColor = System.Drawing.Color.White;
            this.btnEditStaffHrDash.Image = global::DDM_LMS.Properties.Resources.user_delete_48;
            this.btnEditStaffHrDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditStaffHrDash.Location = new System.Drawing.Point(0, 174);
            this.btnEditStaffHrDash.Name = "btnEditStaffHrDash";
            this.btnEditStaffHrDash.Size = new System.Drawing.Size(250, 60);
            this.btnEditStaffHrDash.TabIndex = 9;
            this.btnEditStaffHrDash.Text = "Delete/Edit Staff";
            this.btnEditStaffHrDash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditStaffHrDash.UseVisualStyleBackColor = false;
            this.btnEditStaffHrDash.Click += new System.EventHandler(this.btnEditStaffHrDash_Click);
            // 
            // HRdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelLeft);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "HRdashboard";
            this.Text = "HR Dashboard";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxUserNameHrDash;
        private System.Windows.Forms.Button btnLogOutHrDash;
        private System.Windows.Forms.Button btnHolidayCalenderHrDash;
        private System.Windows.Forms.Button btnStaffAvailabilityHrDash;
        private System.Windows.Forms.Button btnEditStaffHrDash;
        private System.Windows.Forms.Button btnLeavesRequestHrDash;
        private System.Windows.Forms.Button btnAddStaffHrDash;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button SlidingPaneltoggleButton;
    }
}

