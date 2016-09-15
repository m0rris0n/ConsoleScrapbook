using ConsoleScrapbook.FormBuilderAPI.Factories.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.ViewModels
{
    public class SupervisorViewModel : IViewModel
    {
        public string Surname { get; set; }
        public string Forename { get; set; }
        public int RegistrationNumber { get; set; }
    }
}
