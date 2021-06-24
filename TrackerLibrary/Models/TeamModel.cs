using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
		public List<PersonModel1> TeamMembers { get; set; } = new List<PersonModel1>();
		public string TeamName { get; set; }
	}
}
