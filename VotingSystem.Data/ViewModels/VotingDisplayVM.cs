using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem.Data.ViewModels
{
    public class VotingDisplayVM
    {
        public int CandidateId {  get; set; }
        public string CandidateName {  get; set; }

        public int UpVote {  get; set; }
        public int DownVote { get; set; }

    }
}
