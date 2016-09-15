using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleScrapbook.FormBuilderAPI.Forms;

namespace ConsoleScrapbook.FormBuilderAPI.Repositories
{
    interface IRepository
    {
        void CreateForm(string id);
        void UpdateForm();
        void GetComponent();
        void GetForm();
    }
}
