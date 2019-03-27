using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDM_LMS
{
    public partial class HRdashboard : Form
    {
        public HRdashboard()
        {
            InitializeComponent();
        }

        private void btnAddStaffHrDash_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(AddStaffUserControl1.Instance))
            {
                contentPanel.Controls.Add(AddStaffUserControl1.Instance);
                AddStaffUserControl1.Instance.Dock = DockStyle.Fill;
                AddStaffUserControl1.Instance.BringToFront();
            }
            else
            {
                AddStaffUserControl1.Instance.BringToFront();
            }
        }

        private void btnLogOutHrDash_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditStaffHrDash_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(EditStaffUserControl.Instance))
            {
                contentPanel.Controls.Add(EditStaffUserControl.Instance);
                EditStaffUserControl.Instance.Dock = DockStyle.Fill;
                EditStaffUserControl.Instance.BringToFront();
            }
            else
            {
                EditStaffUserControl.Instance.BringToFront();
            }
        }
        bool isSlidingPanelExpanded;
        const int MaxSliderWidth = 256;
        const int MinSliderWidth = 42;
        private void SlidingPaneltoggleButton_Click(object sender, EventArgs e)
        {
            if (panelLeft.Width >= 256)
            {
                panelLeft.Width = 42;
                SlidingPaneltoggleButton.Width = 42;
                contentPanel.Move = 894;
                //panelAddStaffUserControl.width= 894;
            }
            else
            {
                panelLeft.Width = 256;
                //SlidingPaneltoggleButton.Width = 256;
            }
        }

        private void btnAddStaffHrDash_MouseEnter(object sender, EventArgs e)
        {
            btnAddStaffHrDash.BackColor = Color.DodgerBlue;
        }

        private void HRdashboard_Load(object sender, EventArgs e)
        {

        }
    }
    }


