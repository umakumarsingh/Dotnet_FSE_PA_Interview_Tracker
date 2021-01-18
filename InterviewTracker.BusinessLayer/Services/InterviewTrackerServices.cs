using InterviewTracker.BusinessLayer.Interfaces;
using InterviewTracker.BusinessLayer.Services.Repository;
using InterviewTracker.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewTracker.BusinessLayer.Services
{
    public class InterviewTrackerServices : IInterviewTrackerServices
    {
        /// <summary>
        /// creating a referance object of IInterviewTrackerRepository
        /// </summary>
        private readonly IInterviewTrackerRepository _interviewTR;

        /// <summary>
        /// injecting IInterviewTrackerRepository in consructor to access all methods
        /// </summary>
        public InterviewTrackerServices(IInterviewTrackerRepository interviewTrackerRepository)
        {
            _interviewTR = interviewTrackerRepository;
        }
        public async Task<Interview> AddInterview(Interview interview)
        {
            //Do Code Here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteInterviewById(string interviewId)
        {
            //Do Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Interview>> GetAllInterview()
        {
            //Do Code Here
            throw new NotImplementedException();
        }

        public async Task<Interview> GetInterviewrById(string interviewId)
        {
            //Do Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Interview>> InterviewByName(string name)
        {
            //Do Code Here
            throw new NotImplementedException();
        }

        public long TotalCount()
        {
            //Do Code Here
            throw new NotImplementedException();
        }

        public async Task<Interview> UpdateInterview(string interviewId, Interview interview)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
    }
}
