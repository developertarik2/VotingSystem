using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem.Infrastructure.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ISP_Call SP_Call { get; }
        ICandidateRepository Candidate { get; }
        IVoteDetailsRepository VoteDetails { get; }
        void Save();
    }
}
