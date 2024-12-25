using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Data.Models;

namespace VotingSystem.Infrastructure.Repository.Interfaces
{
    public interface IVoteDetailsRepository : IRepository<VoteDetails>
    {
        //public IEnumerable<Candidate> GetAll();
    }
}
