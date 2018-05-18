using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolSports
{
    public partial class DisplayPage : Form
    {
        public DisplayPage()
        {
            InitializeComponent();
        }
        
        DataSet _dataset;
     private SqlConnection _sqlconnection;
     private SqlCommand _sqlcommand;
        SqlDataAdapter _sqldataAdapter;
        
        private string sConnection;
        private string sql;
        private void DisplayPage_Load(object sender, EventArgs e)
        {
            sConnection = "Server = STELLAS-MFB-IT; integrated security = true; database = SchoolSports; ";
            SqlDataAdapter da = new SqlDataAdapter("SELECT SportType FROM Team", sConnection);
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            for (int i = 0;i < dt.Rows.Count;i++)
            {
                comboTeam.Items.Add(dt.Rows[i]["SportType"].ToString());
            }
           
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            
            if(comboTeam.SelectedItem != null)
            {
                try
                {
                    sConnection = "Server = STELLAS-MFB-IT; integrated security = true; database = SchoolSports; ";
                    _sqlconnection = new SqlConnection(sConnection);




                    sql = " select *, (select CoachFirstName from team where SportType = a.SportType) as 'CoachFirstName',"+
                       " (select CoachLastName from team where SportType = a.SportType) AS 'Coachlastname' "+
                       " from Athlete a WHERE a.SportType ='" + comboTeam.Text + "'";
                    _sqlcommand = new SqlCommand();
                    _sqlcommand.CommandText = sql;
                    _sqlcommand.Connection = _sqlconnection;
                    _sqldataAdapter = new SqlDataAdapter();
                    _sqldataAdapter.SelectCommand = _sqlcommand;
                    _dataset = new DataSet();
                    _sqldataAdapter.Fill(_dataset, "Team");

                    dataGridView1.DataSource = _dataset;
                    dataGridView1.DataMember = "Team";

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            
            else 
                try
                {
                    sConnection = "Server = STELLAS-MFB-IT; integrated security = true; database = SchoolSports; ";
                    _sqlconnection = new SqlConnection(sConnection);

                    sql = "SELECT Team.sportNumber,Team.SportType,Team.CoachFirstName,Team.CoachLastName,Team.MostActiveSeason,"+
                       " Athlete.StudentNumber,Athlete.StudentFirstName,Athlete.StudentLastName"+
                       " FROM Team JOIN Athlete ON Team.SportType = Athlete.SportType; ";

                    _sqlcommand = new SqlCommand();
                    _sqlcommand.CommandText = sql;
                    _sqlcommand.Connection = _sqlconnection;
                    _sqldataAdapter = new SqlDataAdapter();
                    _sqldataAdapter.SelectCommand = _sqlcommand;
                    _dataset = new DataSet();
                    _sqldataAdapter.Fill(_dataset, "Team");

                    dataGridView1.DataSource = _dataset;
                    dataGridView1.DataMember = "Team";

                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }



            


        }
    }
}
