using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.Modules
{
    public class Qualification
    {
        public int Id { get; set; }
        public int ApplicationFormId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Title { get; set; }
        public string Provider { get; set; }
        public string Grade { get; set; }
    }
}
