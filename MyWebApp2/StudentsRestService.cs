using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MyWebApp2.Model;
using System.Linq;
namespace MyWebApp2{

    [Route("/api/students")]
    public class StudentsRestService : Controller{

        // ejecter le service MyDbContext via le constructeur

        private MyDbContext dbService;

        public StudentsRestService(MyDbContext dbContext)
        {
            dbService = dbContext;
        }

        [HttpGet]
        public IEnumerable<Student> list ()
        {
            return dbService.Students;
        }

         [HttpGet("{Id}")]
        public Student GetOne (long Id )
        {
            return dbService.Students.FirstOrDefault(s=>s.Id == Id );
        }

        [HttpDelete("{Id}")]
        public void Delete (long Id )
        {
            Student student = dbService.Students.FirstOrDefault(s=>s.Id == Id );
            dbService.Students.Remove( student );
            dbService.SaveChanges();
            
        }

         [HttpPut("{Id}")]
        public Student UpdateOne (long Id, [FromBody] Student student )
        {
            student.Id = Id;
            dbService.Students.Update(student);
            dbService.SaveChanges();
            return student;
            
        }

        [HttpPost]
        public Student Save([FromBody] Student student)
        {
            dbService.Students.Add(student);
            dbService.SaveChanges();
            return student;
        }
    }
}