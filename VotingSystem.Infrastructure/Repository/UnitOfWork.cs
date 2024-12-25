using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Infrastructure.Data;
using VotingSystem.Infrastructure.Repository.Interfaces;

namespace VotingSystem.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Candidate=new CandidateRepository(_db);
            VoteDetails=new VoteDetailsRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ISP_Call SP_Call { get;private set; }

        public ICandidateRepository Candidate {  get; private set; }
        public IVoteDetailsRepository VoteDetails { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
