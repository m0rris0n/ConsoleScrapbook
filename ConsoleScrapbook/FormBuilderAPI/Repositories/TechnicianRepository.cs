using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleScrapbook.FormBuilderAPI.Forms;
using ConsoleScrapbook.FormBuilderAPI.Factories;
using ConsoleScrapbook.FormBuilderAPI.Factories.Modules;

namespace ConsoleScrapbook.FormBuilderAPI.Repositories
{
    class TechnicianRepository //: IRepository
    {
        public TechnicianFactory _formFactory = null;
        public PersonalDetailsFactory _personalDetails = null;
        public QualificationFactory _qualfification = null;
        public CounterSigFactory _counterSig = null;
        public SupervisorFactory _supervisor = null;
        public EqualityMonFactory _equalityMon = null;
        public FTPDecFactory _ftpDec = null;
        public PreviousRegFactory _previousReg = null;
        public WorkExpFactory _workExp = null;
        public PhotoCertFactory _photoCert = null;

        public TechnicianRepository()
        {
            _formFactory = new TechnicianFactory();
            _personalDetails = new PersonalDetailsFactory();
            _qualfification = new QualificationFactory();
            _counterSig = new CounterSigFactory();
            _supervisor = new SupervisorFactory();
            _equalityMon = new EqualityMonFactory();
            _ftpDec = new FTPDecFactory();
            _previousReg = new PreviousRegFactory();
            _workExp = new WorkExpFactory();
            _photoCert = new PhotoCertFactory();
        }

        public void CreateForm(string id)
        {


        }

        public void UpdateForm(IViewModel viewModel, int componentType)
        {
            switch (componentType)
            {
                case 0:
                    //_counterSig.
                    break;
                case 1:
                    //equal
                    break;
                case 2:
                    //ftpdec
                    break;
                case 3:
                    //details
                    break;
                case 4:
                    //photo
                    break;
                case 5:
                    //prev reg
                    break;
                case 6:
                    //qual
                    break;
                case 7:
                    //super
                    break;
                case 10:
                    //workExp
                    break;
                default: //error
                    break;
            }

        }
    }
}
