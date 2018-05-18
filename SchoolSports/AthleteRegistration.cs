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
    public partial class AthleteRegistration : Form
    {
        public AthleteRegistration()
        {
            InitializeComponent();
        }
        Athlete _athlete = new Athlete();

        private SqlConnection _sqlconnection;
        private SqlCommand _sqlcommand;

        private string sConnection;
        private string sql;

        private void btnSubmitAthlete_Click(object sender, EventArgs e)
        {
          
            _athlete.StudentFirstName = txtBxStudenFirstName.Text;
            _athlete.StudentLastName = txtBxStudentLastName.Text;
            _athlete.SportType = txtBxSportType.Text;


            try
            {


                sConnection = "Server = STELLAS-MFB-IT; integrated security = true; database = SchoolSports; ";
                _sqlconnection = new SqlConnection(sConnection);
                sql = "INSERT INTO Athlete  VALUES (@StudentFirstName,@StudentLastName,@SportType)";
                _sqlcommand = new SqlCommand();


               
                _sqlcommand.Parameters.AddWithValue("@StudentFirstName", _athlete.StudentFirstName);
                _sqlcommand.Parameters.AddWithValue("@StudentLastName", _athlete.StudentLastName);
                _sqlcommand.Parameters.AddWithValue("@SportType", _athlete.SportType);

                _sqlcommand.CommandText = sql;
                _sqlcommand.Connection = _sqlconnection;
                _sqlcommand.Connection.Open();
                _sqlcommand.ExecuteNonQuery();
                _sqlcommand.Connection.Close();


                MessageBox.Show("Registered successfully!!!");



            }
            catch (SqlException ex)
            {
                lblErrorAthlete.Text = ex.Message;
            }

            ClearAthleteEntry();
        }

        public void ClearAthleteEntry()
        {

            txtBxSportType.Clear();
            txtBxStudenFirstName.Clear();
            txtBxStudentLastName.Clear();
            
        }

    
    }
}
