using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem.Data.Models
{
    public class Candidate
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        //public string VotingLogo {  get; set; }

       // public DateTimeOffset Created {  get; set; }=DateTimeOffset.UtcNow;
       // public bool IsActive {  get; set; }=true;

    }
}
