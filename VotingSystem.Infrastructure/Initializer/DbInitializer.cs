using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Data.Models;
using VotingSystem.Infrastructure.Data;

namespace VotingSystem.Infrastructure.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        public DbInitializer(ApplicationDbContext db)
        { 
            _db = db;
        }

        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {

            }

            if (_db.Candidates.Any()) { return; }

            var newCandidate1 = new Candidate
            {
                Name = "Trump",
                Description="American President"
            };
            var newCandidate2 = new Candidate
            {
                Name = "Putin",
                Description = "Russian President"
            };

            _db.Candidates.Add(newCandidate1 );
            _db.Candidates.Add(newCandidate2);
            _db.SaveChanges();
        }
    }
}
