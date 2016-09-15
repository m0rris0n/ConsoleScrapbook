using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleScrapbook.FormBuilderAPI.Forms;
using ConsoleScrapbook.FormBuilderAPI.Factories;
using ConsoleScrapbook.FormBuilderAPI.Factories.Modules;

namespace ConsoleScrapbook.FormBuilderAPI.Factories
{
    class TechnicianFactory
    {
        public TechnicianForm BuildInitialForm(string id)
        {
            var form = new TechnicianForm
            {
                DateCreated = DateTime.Now,
                Id = id
            };
            return form;
        }
    }
}
