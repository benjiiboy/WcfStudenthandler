using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfStudentHandler
{
    [DataContract]
    public class Student
    {
       public static List<Student> Studentliste = new List<Student>();

        [DataMember]
        public string Navn { get; set; }
        [DataMember]
        public int Id { get; set; }


    }
}