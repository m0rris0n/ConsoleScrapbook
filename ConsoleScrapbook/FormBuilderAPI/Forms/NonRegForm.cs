using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleScrapbook.FormBuilderAPI.Modules;

namespace ConsoleScrapbook.FormBuilderAPI.Forms
{
    class NonRegForm:BaseForm
    {
        public PersonalDetails myPersonalDetails { get; set; }     
        public EqualityMon myEdi { get; set; }
    }
}
