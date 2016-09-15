using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleScrapbook.FormBuilderAPI.Modules;

namespace ConsoleScrapbook.FormBuilderAPI.Forms
{
    class PreregForm:BaseForm
    {
        public PersonalDetails myPersonalDetails { get; set; }
        public ICollection<Qualification> myQualifications { get; set; }
        public ICollection<Training> myTraining { get; set; }
        public ICollection<Tutor> myTutors { get; set; }
        public EqualityMon myEdi { get; set; }
        public FTPDec myFtp { get; set; }
        public ICollection<PreviousReg> myRegistrations { get; set; }
        public PhotoCert myPhoto { get; set; }
    }
}
