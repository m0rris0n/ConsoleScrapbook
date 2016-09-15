using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.Modules
{
    public class Training
    {
        public int Id { get; set; }
        public int ApplicationFormId { get; set; }
        public string Name { get; set; }
        public int PremisesNumber { get; set; }
    }
}
