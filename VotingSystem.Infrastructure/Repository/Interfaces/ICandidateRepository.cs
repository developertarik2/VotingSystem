using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Data.Models;

namespace VotingSystem.Infrastructure.Repository.Interfaces
{
    public interface ICandidateRepository:IRepository<Candidate>
    {
      //  public IEnumerable<Candidate> GetAll();
    }
}
