using Hahn.ApplicatonProcess.December2020.Domain.Applicants.Dtos;
using Swashbuckle.AspNetCore.Filters;

namespace Hahn.ApplicatonProcess.December2020.Web.Controllers
{
    public class ApplicantDtoModelExample : IExamplesProvider<ApplicantDto>
    {
        public ApplicantDto GetExamples()
        {
            return new ApplicantDto { ID = 0, Address = "Uskudar Istanbul", Age = 29, CountryOfOrigin = "Germany", EmailAdress = "m.c.ogzhan@gmail.com", FamilyName = "Oguzhan", Hired = true, Name = "Murat" };
        }
    }
}
