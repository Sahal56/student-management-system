using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Students.API.Models;

namespace Students.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public DBContext _db;

        public StudentsController(DBContext dBContext)
        {
            _db = dBContext;
        }

        // GET : api/Students

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            try
            {
                if (_db.Students == null) { return NotFound(); }

                return await _db.Students.ToListAsync();
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(long id)
        {
            try
            {
                if (_db.Students == null) { return NotFound(); }

                var student = await _db.Students.FindAsync(id);
                if (student == null) { return NotFound(); }

                return Ok(student);
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST : api/Students

        [HttpPost]
        public async Task<ActionResult<Student>> CreateStudent(Student student)
        {
            try
            {
                _db.Students.Add(student);
                await _db.SaveChangesAsync();
                return Ok(student);
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // PUT : api/Students/id

        [HttpPut("{id}")]
        public async Task<ActionResult<Student>> UpdateStudent(long id, Student student)
        {
            try
            {
                if (id != student.s_id) { return BadRequest(); }

                if (_db.Students == null) { return NotFound(); }

                var studentExist = _db.Students.Find(id);
                if (studentExist == null) { return NotFound(); }

                _db.Students.Update(student);
                await _db.SaveChangesAsync();
                return Ok("Student : " + student.s_name + " updated");
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // DELETE : api/Students/id

        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> DeleteStudent(long id)
        {
            try
            {
                if (_db.Students == null) { return NotFound(); }

                var student = await _db.Students.FindAsync(id);
                if (student == null) { return NotFound(); }

                _db.Students.Remove(student);
                await _db.SaveChangesAsync();

                return Ok("Student : " + student.s_name + " deleted");

            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

    }
}
