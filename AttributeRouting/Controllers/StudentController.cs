using AttributeRouting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AttributeRouting.Controllers
{
    public class StudentController : ApiController
    {
        static List<Student> students = new List<Student>
        {
            new Student{ Id = 1, Name = "Anya" },
            new Student{ Id = 2, Name = "Eric" },
            new Student{ Id = 3, Name = "Grace" }
        };

        public IEnumerable<Student> Get()
        {
            return students;
        }

        public Student Get(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
        [Route("api/student/{id}/courses")]
        public IEnumerable<string> GetStudentCources(int id)
        {
            if (id == 1)
                return new List<string> { "C#", "WEBAPI", "JAVASCRIPT" };
            else if (id == 2)
                return new List<string> { "C#", "WEBAPI", "JAVASCRIPT" };
            else
                return new List<string> { "C#", "WEBAPI", "JAVASCRIPT" };
        }
    }
}
