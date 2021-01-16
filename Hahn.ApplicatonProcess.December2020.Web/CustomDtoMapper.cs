using AutoMapper;
using ApplicatonProcess.December2020.Domain.Applicants.Dtos;
using ApplicatonProcess.December2020.Domain.Models;

namespace ApplicatonProcess.December2020.Web
{
    internal static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<ApplicantDto, Applicant>().ReverseMap();
        }
    }
}
