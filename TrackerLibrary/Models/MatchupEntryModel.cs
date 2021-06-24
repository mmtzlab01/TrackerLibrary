using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
	public class MatchupEntryModel
	{
		public int Id { get; set; }
		/// <summary>
		/// Represents one team in matchup
		/// </summary>
		public TeamModel TeamCompeting { get; set; }
		/// <summary>
		/// Represents score for this particular team.
		/// </summary>
		public double Score { get; set; }
		/// <summary>
		/// Represent matchup which this team camre from
		/// as the winner.
		/// </summary>
		public MatchupModel ParentMatchup { get; set; }


	}
}
