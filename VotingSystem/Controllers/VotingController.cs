using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VotingSystem.Data.Models;
using VotingSystem.Data.ViewModels;
using VotingSystem.Infrastructure.Repository;
using VotingSystem.Infrastructure.Repository.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace VotingSystem.Controllers
{
    public class VotingController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public VotingController(IUnitOfWork unitOfWork) 
        {
           _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {

            string query = @"Select v.CandidateId CandidateId,c.Name CandidateName,
                    SUM(CASE When v.IsUpvote='1' Then 1 Else 0 End ) 'UpVote',  
                    SUM(CASE When v.IsUpvote='0' Then 1 Else 0 End ) 'DownVote'  
                    from VoteDetails v Inner JOIN Candidates c ON v.CandidateId=c.Id group by v.CandidateId,c.Name
                    order by 'UpVote' desc,'DownVote',c.Name"
            ;

            var preList = _unitOfWork.SP_Call.ListByRawQuery<VotingDisplayVM>(query);
            return View(preList);
        }


        
        [HttpPost]
        public IActionResult UpVote(int id)
        {
            var objFromDb = _unitOfWork.Candidate.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while voting" });
            }

            var vote = new VoteDetails
            {
                Candidate = objFromDb,
                CandidateId=objFromDb.Id,
                IsUpvote = true,
                Votetime=DateTimeOffset.UtcNow
            };

            _unitOfWork.VoteDetails.Add(vote);
            _unitOfWork.Save();
            return Json(new { success = true, message = "UpVote given successful to " + objFromDb.Name });
        }

        [HttpPost]
        public IActionResult DownVote(int id)
        {
            var objFromDb = _unitOfWork.Candidate.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while voting" });
            }

            var vote = new VoteDetails
            {
                Candidate = objFromDb,
                CandidateId = objFromDb.Id,
                IsUpvote = false,
                Votetime = DateTimeOffset.UtcNow
            };

            _unitOfWork.VoteDetails.Add(vote);
            _unitOfWork.Save();
            return Json(new { success = true, message = "DownVote given successful to" + objFromDb.Name });
        }

    }
}
