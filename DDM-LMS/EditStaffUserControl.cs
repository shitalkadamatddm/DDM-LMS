using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseDDM-LMS.mdf;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditStaffUserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridview();
        }
        public void refresh_DataGridview()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAddedStaffStoredPro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("<<<Invalid SQL OPERATION>>>: \n" + ex);
                }
                con.Close();
                dataGridViewEmployeeSearchResult.DataSource = DS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void buttonSearchEmployeeEsUc_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchEmployeeStoredp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfficeEmailId", textBoxSearchEmployeeEsUc.Text);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("<<<Invalid SQL OPERATION>>>: \n" + ex);
                }
                con.Close();
                dataGridViewEmployeeSearchResult.DataSource = DS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
