using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleScrapbook.FormBuilderAPI.Forms;
using ConsoleScrapbook.FormBuilderAPI.Infrastructure;
using ConsoleScrapbook.FormBuilderAPI.Repositories;
using ConsoleScrapbook.FormBuilderAPI.Factories.Modules;
using ConsoleScrapbook.FormBuilderAPI.Modules;

namespace ConsoleScrapbook.FormBuilderAPI
{
    // Modules int ID list:
    // 0 = CounterSig
    // 1 = EqualityMon
    // 2 = FTPDec
    // 3 = PersonalDetails
    // 4 = PhotoCert
    // 5 = PreviousReg
    // 6 = Qualification
    // 7 = Supervisor
    // 8 = Training
    // 9 = Tutor
    // 10 = WorkExp
    
    class DummyAPI
    {
        int UserID;
        public FormAppDbContext dbCtx;

        
        public DummyAPI()
        {
            UserID = 1;
            dbCtx = new FormAppDbContext();
        }

        string CreateForm(int type, string userId)
        {
            switch(type)
            {
                case 0: //Techician
                    TechnicianRepository _techRepo = new TechnicianRepository();
                    _techRepo.CreateForm(userId);
                    return "form created";
                case 1: //prereg
                    
                    break;
                case 2: //nonreg           ...etc etc...
                    break; 
                default:
                    //return failure?
                    break;
            }
            throw new NotImplementedException();
        }

        void UpdateForm(int componentType, int formType, IViewModel viewModel)
        {
            switch(formType)
            {
                case 0:
                    TechnicianRepository _techRepo = new TechnicianRepository();
                    _techRepo.UpdateForm(viewModel, componentType);
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        void GetComponent(int componentType, int componentId)
        {

        }

        void GetForm(int userID, int formType)
        {

        }

    }
}
