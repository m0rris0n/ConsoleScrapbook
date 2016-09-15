using ConsoleScrapbook.FormBuilderAPI.Factories.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.ViewModels
{
    public class TrainingViewModel : IViewModel
    {
        public string Name { get; set; }
        public int PremisesNumber { get; set; }
    }
}
