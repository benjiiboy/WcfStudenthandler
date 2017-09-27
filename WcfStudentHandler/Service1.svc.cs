using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfStudentHandler
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public Student student { get; set; }

        /*Virker*/
        public void AddStudent(int id, string navn)
        {
            Student.Studentliste.Add(new Student(){Navn = navn, Id = id});
        }

        public void EditStudent(int id, string navn, string newname)
        {
            foreach (var item in Student.Studentliste)
            {
                if (item.Id == id && item.Navn == navn)
                {
                    item.Navn = newname;
                }
            }
        }

        /*Virker*/
        public Student FindStudent(int id)
        {
           return Student.Studentliste.Find(x => x.Id == id);
        }

        /*Virker*/
        public List<Student> GetAllStudents()
        {
            List<Student> nyliste = new List<Student>();

            foreach (var itemstudent in Student.Studentliste)
            {
                  nyliste.Add(itemstudent);
            }
            return nyliste;
        }

        /*Virker*/
        public void RemoveStudent(int id)
        {
            foreach (var item in Student.Studentliste)
            {
                if (item.Id == id)
                {
                    Student.Studentliste.Remove(item);
                }
            }
        }



        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


    }
}
