using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.Modules
{
    public class PhotoCert
    {
        public int Id { get; set; }
        public int ApplicationFormId { get; set; }
        public string Image { get; set; }
        public string CounterSignatoryName { get; set; }
    }
}
