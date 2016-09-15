using ConsoleScrapbook.FormBuilderAPI.Factories.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.ViewModels
{
    public class PreviousRegViewModel : IViewModel
    {
        public string Organisation { get; set; }
        public string RegistrationNumber { get; set; }
    }
}
