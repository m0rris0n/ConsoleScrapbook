using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.Modules
{
    public class Tutor
    {
        public int Id { get; set; }
        public int ApplicationFormId { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public int RegistrationNumber { get; set; }
    }
}
