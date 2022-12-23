using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TallyAssignment5.Data;
using TallyAssignment5.Models;
using TallyAssignment5.Repository;

namespace TallyAssignment5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectRepository _subjectRepository;
        public SubjectController(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        //Getting all the subjects present in DB
        [HttpGet]
        public IEnumerable<Subject> GetSubjects()
        {
            var subjects =  _subjectRepository.GetSubjects();
            return subjects;
        }

        //Getting subject with given SubId
        [HttpGet("{subId}")]
        public Subject GetSubject(int subId)
        {
            return _subjectRepository.GetSubjectById(subId);
        }

        //Adding new subject to any student with given StudId
        [HttpPost]
        public Subject AddSubject(Subject subject)
        {
            return _subjectRepository.AddSubject(subject);
        }

        //Updating subject based on SubId
        [HttpPut("{subId}")]
        public Subject UpdateSubject(Subject subject)
        {
            return _subjectRepository.UpdateSubject(subject);
        }

        //[HttpDelete("{subId}/{studId}")]
        //Deleting subject with SubId
        [HttpDelete("{subId}")]
        public bool DeleteSubject(int subId)
        {
            return _subjectRepository.DeleteSubject(subId);
        }
    }
}
