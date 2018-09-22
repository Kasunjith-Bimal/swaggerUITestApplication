using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwagerAPIConfiguration.Modles;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwagerAPIConfiguration.Controllers
{
    
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        StudentDbContext _db;

        public StudentController(StudentDbContext db)
        {
            _db = db;
        }
        // GET: api/<controller>
        [HttpGet]
        public List<Student> Get()
        {
            return _db.students.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _db.students.Where(x=>x.StudentId==id).FirstOrDefault();
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Student Studentobj)
        {
             _db.students.Add(Studentobj);
            _db.SaveChanges();

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
