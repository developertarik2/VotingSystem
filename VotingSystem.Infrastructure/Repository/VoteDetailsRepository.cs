using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Data.Models;
using VotingSystem.Infrastructure.Data;
using VotingSystem.Infrastructure.Repository.Interfaces;

namespace VotingSystem.Infrastructure.Repository
{
    internal class VoteDetailsRepository : Repository<VoteDetails>, IVoteDetailsRepository
    {
        private readonly ApplicationDbContext _db;

        public VoteDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
