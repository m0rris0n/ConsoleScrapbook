
using ConsoleScrapbook.FormBuilderAPI.Modules;
using ConsoleScrapbook.FormBuilderAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.Factories.Modules
{
    public class EqualityMonFactory
    {
        public EqualityMon construct(EqualityMonViewModel vm)
        {
            EqualityMon equalityMon = new EqualityMon()
            {
                Gender = vm.Gender,
                Race = vm.Race,
                Religion = vm.Religion
            };
            return equalityMon;
        }

        public EqualityMonViewModel deconstruct(EqualityMon equalityMon)
        {
            EqualityMonViewModel vm = new EqualityMonViewModel()
            {
                Gender = equalityMon.Gender,
                Race = equalityMon.Race,
                Religion = equalityMon.Religion
            };
            return vm;
        }
    }
}
