using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.Modules
{
    public class PersonalDetails
    {
        public int Id { get; set; }
        public int ApplicationFormId { get; set; }
        public string Title { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string MiddleNames { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
