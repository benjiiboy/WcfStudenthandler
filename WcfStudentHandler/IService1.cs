using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfStudentHandler
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void AddStudent(int id, string navn);

        [OperationContract]
        void RemoveStudent(int id);

        [OperationContract]
        Student FindStudent(int id);

        [OperationContract]
        void EditStudent(int id, string navn, string newname);

        [OperationContract]
        List<Student> GetAllStudents();



        // TODO: Add your service operations here
    }






}
