using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.Modules
{
    public class WorkExp
    {
        public int Id { get; set; }
        public int ApplicationFormId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Role { get; set; }
        public string Company { get; set; }
        public string Duties { get; set; }
    }
}
