using ConsoleScrapbook.FormBuilderAPI.Modules;
using ConsoleScrapbook.FormBuilderAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.Factories.Modules
{
    public class CounterSigFactory
    {
        public CounterSig construct(CounterSigViewModel vm)
        {
            CounterSig counterSig = new CounterSig()
            {
                Surname = vm.Surname,
                Forename = vm.Forename,
                RegistrationNumber = vm.RegistrationNumber

            };
            return counterSig;
        }

        public CounterSigViewModel deconstruct(CounterSig counterSig)
        {
            CounterSigViewModel vm = new CounterSigViewModel()
            {
                Surname = counterSig.Surname,
                Forename = counterSig.Forename,
                RegistrationNumber = counterSig.RegistrationNumber
            };
            return vm;
        }

    }
}
