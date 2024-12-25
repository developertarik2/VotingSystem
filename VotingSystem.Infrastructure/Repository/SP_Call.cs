using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Infrastructure.Data;
using VotingSystem.Infrastructure.Repository.Interfaces;

namespace VotingSystem.Infrastructure.Repository
{
    public class SP_Call : ISP_Call
    {
        private readonly ApplicationDbContext _db;
        private static string ConnectionString = "";

        public SP_Call(ApplicationDbContext db)
        {
            _db = db;
            ConnectionString = db.Database.GetDbConnection().ConnectionString;
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public List<T> ListByRawQuery<T>(string sql)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                return connection.Query<T>(sql).ToList();
                //return data;
                // use data
            }
        }
    }
}
