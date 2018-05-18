using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSports
{
   public class Athlete
    {
       
        public string SportType { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }


        public Athlete()
        {

        }
        public Athlete(string StudentNo, string Type, string FName, string LName)
        {
           
            SportType = Type;
            StudentFirstName = FName;
            StudentLastName = LName;
            
        }
    }
   

    
}
