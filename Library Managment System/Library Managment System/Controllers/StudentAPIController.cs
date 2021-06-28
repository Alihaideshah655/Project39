using Library_Managment_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using System.Collections.Generic;

namespace Library_Managment_System.Controllers
{
     
    public class StudentAPIController : ApiController
    {
        // api/StudentAPI/AddStudent
        [HttpPost]
        public bool AddStudent(user model)
        {
            try
            {
                StreamWriter writer = new StreamWriter("D:/Project39/Library Managment System/data.txt", true);
                writer.WriteLine(model.firstName + "," + model.lastName + "," + model.regristrationNo);
                writer.Flush();
                writer.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        // api/StudentAPI/ListStudents
        [HttpGet]
        public List<user> AllStudent()
        {
            List<user>  list = new List<user>();
            StreamReader reader = new StreamReader("D:/Project39/Library Managment System/data.txt");
            String line = reader.ReadLine();
            while (!String.IsNullOrEmpty(line))
            {
                String[] token = line.Split(',');
                user obj = new user();
                obj.firstName = token[0];
                obj.lastName = token[1];
                obj.regristrationNo = token[2];
                list.Add(obj);
                line = reader.ReadLine();
            }
            return list;
        }
    }
}
