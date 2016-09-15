using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleScrapbook.FormBuilderAPI2.Models;

namespace ConsoleScrapbook.FormBuilderAPI2.Controllers
{
    public interface SingleRepository
    {
        Model readModel(int formId);

        int UpdateModel(Model model);

        int Create(Model model);

        int Delete(int formId);
    }
}
