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
    public partial class AddStaffUserControl1 : UserControl
    {
        //creates Instance
        private static AddStaffUserControl1 _instance;
        public static AddStaffUserControl1 Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new AddStaffUserControl1();
                }
                return _instance;
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseDDM-LMS.mdf;Integrated Security=True");
        public AddStaffUserControl1()
        {
            InitializeComponent();
        }
        private void AddStaffUserControl1_Load(object sender, EventArgs e)
        {

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
                dataGridView1.DataSource = DS.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void btnSaveUcAs_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("AddStaff_Sp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", comboBoxTitleUcAs.Text);
            cmd.Parameters.AddWithValue("@FirstName", textBoxFirstNameUcAs.Text);
            cmd.Parameters.AddWithValue("@LastName", textBoxLastNameUcAs.Text);
            cmd.Parameters.AddWithValue("@ContactNumber1", textBoxContactNumber1Ae.Text);
            cmd.Parameters.AddWithValue("@ContactNumber2", textBoxContactNumber2As.Text);
            cmd.Parameters.AddWithValue("@PersonalEmailId", textBoxPersonalEmailAs.Text);
            cmd.Parameters.AddWithValue("@OfficeEmailId", textBoxOfficeEmailAs.Text);
            cmd.Parameters.AddWithValue("@Department", comboBoxDepartmentAs.Text);
            cmd.Parameters.AddWithValue("@Manager", textBoxStaffManagerAs.Text);
            cmd.Parameters.AddWithValue("@LeavesAllowanceSick", textBoxSickLeaveAs.Text);
            cmd.Parameters.AddWithValue("@LeavesAllowanceCasual", textBoxCasualLeaveAs.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("<<<Invalid SQL OPERATION>>>: \n" + ex);
            }
            con.Close();
            MessageBox.Show("Added staff successfully");
            refresh_DataGridview();
            
        }

        
    }
}
