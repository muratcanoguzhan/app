using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Hahn.ApplicatonProcess.December2020.Data.ThirdPartyLibraries.Address;
using Hahn.ApplicatonProcess.December2020.Domain.Applicants.Dtos;

namespace Hahn.ApplicatonProcess.December2020.Web.Validators
{
    public class ApplicantValidator : AbstractValidator<ApplicantDto>
    {
        private readonly ICountryInfoFinder _countyInfoFinder;

        public ApplicantValidator(ICountryInfoFinder countyInfoFinder)
        {
            _countyInfoFinder = countyInfoFinder;

            RuleFor(x => x.Name).MinimumLength(5);
            RuleFor(x => x.FamilyName).MinimumLength(5);
            RuleFor(x => x.Address).MinimumLength(10);

            RuleFor(x => x.CountryOfOrigin).Must((rootObject, c, context) => {
                context.MessageFormatter
                  .AppendArgument("CountryToCheck", c);

                return _countyInfoFinder.IsCountryExist(c);
            })
            .WithMessage("{CountryToCheck} not found!");

            RuleFor(x => x.EmailAdress).EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible);
            RuleFor(x => x.Age).InclusiveBetween(20, 60);
            RuleFor(x => x.Hired).NotNull();
        }
    }
}
