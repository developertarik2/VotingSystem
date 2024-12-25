using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem.Data.Models
{
    public class VoteDetails
    {
        [Key]
        public int Id { get; set; }

        public bool IsUpvote {  get; set; }=false;

        [ForeignKey(nameof(CandidateId))]
        public int CandidateId {  get; set; }
        public virtual Candidate Candidate { get; set; }

        public DateTimeOffset Votetime { get; set; } = DateTimeOffset.UtcNow;
    }
}
