using ConsoleScrapbook.FormBuilderAPI.Modules;
using ConsoleScrapbook.FormBuilderAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.Factories.Modules
{
    public class FTPDecFactory
    {
        public FTPDec construct(FTPDecViewModel vm)
        {
            FTPDec ftpDec = new FTPDec()
            {
                Q1 = vm.Q1,
                Q2 = vm.Q2,
                Q3 = vm.Q3,
                Q4 = vm.Q4,
                Q5 = vm.Q5
            };
            return ftpDec;
        }

        public FTPDecViewModel deconstruct(FTPDec ftpDec)
        {
            FTPDecViewModel vm = new FTPDecViewModel()
            {
                Q1 = ftpDec.Q1,
                Q2 = ftpDec.Q2,
                Q3 = ftpDec.Q3,
                Q4 = ftpDec.Q4,
                Q5 = ftpDec.Q5
            };
            return vm;
        }
    }
}
