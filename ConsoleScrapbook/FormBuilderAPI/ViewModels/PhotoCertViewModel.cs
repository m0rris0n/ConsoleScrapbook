using ConsoleScrapbook.FormBuilderAPI.Factories.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.ViewModels
{
    public class PhotoCertViewModel :IViewModel
    {
        public string Image { get; set; }
        public string CounterSignatoryName { get; set; }
    }
}
