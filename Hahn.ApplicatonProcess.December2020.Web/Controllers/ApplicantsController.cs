using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicatonProcess.December2020.Data.Repositories;
using ApplicatonProcess.December2020.Domain.Applicants.Dtos;
using ApplicatonProcess.December2020.Domain.Models;
using ApplicatonProcess.December2020.Web.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace ApplicatonProcess.December2020.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantsController : ControllerBase
    {
        private readonly IRepository<Applicant> _applicantRepository;
        private readonly IObjectMapper _objectMapper;

        public ApplicantsController(IRepository<Applicant> applicantRepository, IObjectMapper objectMapper)
        {
            _applicantRepository = applicantRepository;
            _objectMapper = objectMapper;
        }

        // GET: api/Applicants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicantDto>>> GetApplicants()
        {
            var applicants = await _applicantRepository.Get();

            return applicants.Select(a => _objectMapper.Map<ApplicantDto>(a)).ToList();
        }

        // GET: api/Applicants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicantDto>> GetApplicant(int id)
        {
            var applicant = await _applicantRepository.GetByID(id);

            if (applicant == null)
            {
                return NotFound();
            }

            return _objectMapper.Map<ApplicantDto>(applicant);
        }

        // PUT: api/Applicants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutApplicant(ApplicantDto applicant)
        {
            await _applicantRepository.Update(_objectMapper.Map<Applicant>(applicant));


            return NoContent();
        }

        // POST: api/Applicants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ApplicantDto>> PostApplicant(ApplicantDto applicant)
        {
            var entity = _objectMapper.Map<Applicant>(applicant);
            await _applicantRepository.Insert(entity);

            return CreatedAtAction("GetApplicant", new { id = applicant.ID }, _objectMapper.Map<Applicant>(entity));
        }

        // DELETE: api/Applicants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicant(int id)
        {
            var applicant = await _applicantRepository.GetByID(id);
            if (applicant == null)
            {
                return NotFound();
            }

            await _applicantRepository.Delete(applicant);

            return NoContent();
        }
    }
}
