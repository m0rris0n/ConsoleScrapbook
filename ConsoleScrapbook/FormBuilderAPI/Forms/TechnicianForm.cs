using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleScrapbook.FormBuilderAPI.Modules;

namespace ConsoleScrapbook.FormBuilderAPI.Forms
{
    class TechnicianForm:BaseForm
    {
        public PersonalDetails myPersonalDetails { get; set; }
        public ICollection<Qualification> myQualifications { get; set; }
        public CounterSig myCSig { get; set; }
        public Supervisor mySuper { get; set; }
        public EqualityMon myEdi { get; set; }
        public FTPDec myFtp { get; set; }
        public ICollection<PreviousReg> myRegistrations { get; set; }
        public ICollection<WorkExp> myWorkExp { get; set; }
        public PhotoCert myPhoto { get; set; }
    }
}
