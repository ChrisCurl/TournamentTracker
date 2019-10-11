using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// One team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Score for the particular team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// The matchup that this team came from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        /// <summary>
        /// some text
        /// </summary>
        /// <param name="initialScore"></param>
    }
}
