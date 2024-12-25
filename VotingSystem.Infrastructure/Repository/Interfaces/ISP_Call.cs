using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem.Infrastructure.Repository.Interfaces
{
    public interface ISP_Call : IDisposable
    {
        List<T> ListByRawQuery<T>(string sql);
    }
}
