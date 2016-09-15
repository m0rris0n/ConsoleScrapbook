using ConsoleScrapbook.FormBuilderAPI.Factories.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.ViewModels
{
    public class EqualityMonViewModel : IViewModel
    {
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Religion { get; set; }
    }
}
