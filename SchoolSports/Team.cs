using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSports
{
   public class Team
    {
        public string SportNumber { get; set; }
       public string SportType { get; set; }
      

        public string CoachFirstName { get; set; }
        public string CoachLastName { get; set; }
       
        public string MostActiveSeason { get; set; }

        public Team()
        {

        }
        public Team(string SportNo,string Type,string FName,string LName,string MActiveSeason)
        {
            SportNumber = SportNo;
            SportType = Type;
            CoachFirstName = FName;
            CoachLastName = LName;
            MostActiveSeason = MActiveSeason;
        }
        public List<string> SportTypeList = new List<string>();
        
       

    }
}
