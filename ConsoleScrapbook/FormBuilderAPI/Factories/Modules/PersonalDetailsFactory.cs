using ConsoleScrapbook.FormBuilderAPI.Modules;
using ConsoleScrapbook.FormBuilderAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.Factories.Modules
{
    public class PersonalDetailsFactory
    {
        public PersonalDetails construct(PersonalDetailsViewModel vm)
        {
            PersonalDetails personalDetails = new PersonalDetails()
            {
                Address = vm.Address,
                DateOfBirth = vm.DateOfBirth,
                Forename = vm.Forename,
                MiddleNames = vm.MiddleNames,
                Surname = vm.Surname,
                TelephoneNumber = vm.TelephoneNumber,
                Title = vm.Title

            };
            return personalDetails;
        }

        public PersonalDetailsViewModel deconstruct(PersonalDetails personalDetails)
        {
            PersonalDetailsViewModel vm = new PersonalDetailsViewModel()
            {
                Address = personalDetails.Address,
                DateOfBirth = personalDetails.DateOfBirth,
                Forename = personalDetails.Forename,
                MiddleNames = personalDetails.MiddleNames,
                Surname = personalDetails.Surname,
                TelephoneNumber = personalDetails.TelephoneNumber,
                Title = personalDetails.Title
            };
            return vm;
        }
    }
}
