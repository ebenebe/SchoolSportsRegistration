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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        
        

       
       

       

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            

           



        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            TeamRegistration _teamReg = new TeamRegistration();
            _teamReg.Show();
            

        }

        private void btnAthlete_Click(object sender, EventArgs e)
        {
            AthleteRegistration _athleteReg = new AthleteRegistration();
            _athleteReg.Show();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayPage _displayPage = new DisplayPage();
            _displayPage.Show();
        }
    }
}
