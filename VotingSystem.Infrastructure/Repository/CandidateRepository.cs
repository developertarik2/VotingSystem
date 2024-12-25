using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Data.Models;
using VotingSystem.Infrastructure.Data;
using VotingSystem.Infrastructure.Repository.Interfaces;

namespace VotingSystem.Infrastructure.Repository
{
    public class CandidateRepository : Repository<Candidate>, ICandidateRepository
    {
        private readonly ApplicationDbContext _db;

        public CandidateRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        
    }
}
