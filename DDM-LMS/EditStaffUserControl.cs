using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDM_LMS
{
    public partial class EditStaffUserControl : UserControl
    {
        public EditStaffUserControl()
        {
            InitializeComponent();
        }
        private static EditStaffUserControl _instance;
        public static EditStaffUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EditStaffUserControl();
                }
                return _instance;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditStaffUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
