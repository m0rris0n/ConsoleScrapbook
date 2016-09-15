using ConsoleScrapbook.FormBuilderAPI.Factories.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.ViewModels
{
    public class QualificationViewModel : IViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Title { get; set; }
        public string Provider { get; set; }
        public string Grade { get; set; }
    }
}
