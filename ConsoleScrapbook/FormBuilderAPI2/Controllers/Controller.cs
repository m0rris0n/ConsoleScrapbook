using ConsoleScrapbook.FormBuilderAPI2.Factories;
using ConsoleScrapbook.FormBuilderAPI2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI2.Controllers
{
    public abstract class Controller
    {
        Repository _repo;
        Factory _fctry;

        public Controller()
        {
            _fctry = new Factory();
        }

    }
}
