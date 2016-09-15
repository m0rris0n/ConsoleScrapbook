using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleScrapbook.Scrap
{
    class ModelPropertyMatch
    {

        public StudentFull buildJson(StudentPartial studentPartial)
        {
            StudentFull studentFull = new StudentFull();

            foreach (PropertyInfo p in studentPartial.GetType().GetProperties())
            {
                if(p.Name != "Id")
                    studentFull.GetType().GetProperty(p.Name).SetValue(studentFull, p.GetValue(studentPartial));
            }



            return studentFull;
        }

        public StudentPartial mockStudentPartial()
        {
            StudentPartial mock = new StudentPartial();
            mock.Id = 33;
            mock.Name = "Jim";
            mock.Thing = "What";

            return mock;
        }



    }

    class StudentFull
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Thing { get; set; }
        public bool Boolean { get; set; }
        public string OtherThing { get; set; }

    }

    class StudentPartial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Thing { get; set; }
    }

    //Main Code



}
