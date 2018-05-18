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
    public partial class TeamRegistration : Form
    {
        public TeamRegistration()
        {
            InitializeComponent();
        }
      private  Team _team = new Team();

        


        private SqlConnection _sqlconnection;
      private  SqlCommand _sqlcommand;
       

        private string sConnection;
        private string sql;

        private void btnSubmitTeam_Click(object sender, EventArgs e)
        {
           


            _team.SportType = txtBxSportType.Text;
            _team.CoachFirstName = TxtBxCoachFirstName.Text;
            _team.CoachLastName = txtBxCoachLastName.Text;
            _team.MostActiveSeason = txtBxMostActiveSeason.Text;

          

            
            
                        
            try
            {
                                
                sConnection = "Server = STELLAS-MFB-IT; integrated security = true; database = SchoolSports; ";
                _sqlconnection = new SqlConnection(sConnection);
                sql = "INSERT INTO Team  VALUES (@SportType,@CoachFirstName,@CoachLastName,@MostActiveSeason)";
                _sqlcommand = new SqlCommand();

             
                _sqlcommand.Parameters.AddWithValue("@SportType", _team.SportType);
                _sqlcommand.Parameters.AddWithValue("@CoachFirstName", _team.CoachFirstName);
                _sqlcommand.Parameters.AddWithValue("@CoachLastName", _team.CoachLastName);
                _sqlcommand.Parameters.AddWithValue("@MostActiveSeason", _team.MostActiveSeason);

                _sqlcommand.CommandText = sql;
                _sqlcommand.Connection = _sqlconnection;
                _sqlcommand.Connection.Open();
                _sqlcommand.ExecuteNonQuery();
                _sqlcommand.Connection.Close();
               

                MessageBox.Show("Registered successfully!!!");

                

            }
            catch (SqlException ex)
            {
                lblErrorTeam.Text = ex.Message;
            }

            ClearTeamEntry();
        }

        public void ClearTeamEntry()
        {
           
            txtBxSportType.Clear();
            TxtBxCoachFirstName.Clear();
            txtBxCoachLastName.Clear();
            txtBxMostActiveSeason.Clear();
        }

        

        
    }
}
