using ConsoleScrapbook.FormBuilderAPI.Factories.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.ViewModels
{
    public class PersonalDetailsViewModel : IViewModel
    {
        public string Title { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string MiddleNames { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
    }
}
