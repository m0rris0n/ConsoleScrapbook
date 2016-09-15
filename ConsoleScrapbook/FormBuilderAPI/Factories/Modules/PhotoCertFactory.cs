using ConsoleScrapbook.FormBuilderAPI.Modules;
using ConsoleScrapbook.FormBuilderAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.Factories.Modules
{
    public class PhotoCertFactory
    {
        public PhotoCert construct(PhotoCertViewModel vm)
        {
            PhotoCert photoCert = new PhotoCert()
            {

            };
            return photoCert;
        }

        public PhotoCertViewModel deconstruct(PhotoCert photoCert)
        {
            PhotoCertViewModel vm = new PhotoCertViewModel()
            {

            };
            return vm;
        }
    }
}
