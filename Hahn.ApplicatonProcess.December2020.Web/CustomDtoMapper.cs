using AutoMapper;
using Hahn.ApplicatonProcess.December2020.Domain.Applicants.Dtos;
using Hahn.ApplicatonProcess.December2020.Domain.Models;

namespace Hahn.ApplicatonProcess.December2020.Web
{
    internal static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<ApplicantDto, Applicant>().ReverseMap();
        }
    }
}
