using Contracts;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace EFCoreApp.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public ValuesController(ApplicationContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            //       var entity = _context.Model
            //.FindEntityType(typeof(Student).FullName);
            //       var tableName = entity.GetTableName();
            //       var schemaName = entity.GetSchema();
            //       var key = entity.FindPrimaryKey();
            //       var properties = entity.GetProperties();
            //       return Ok(tableName);
            var students = _context.Students
             .AsNoTracking()
             .Include(e => e.Evaluations)
             .Include(ss => ss.StudentSubjects)
             .ThenInclude(s => s.Subject)
             .Where(s => s.Age > 25)
             .ToList();

            return Ok(students);
        }
        [HttpGet]
        [Route("GetAllStudents")]
        [SwaggerOperation("GetAllStudents")]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.NotFound)]
        public IActionResult AllStudents()
        {

            var students = _context.Students
                            .Select(s => new StudentDto
                            {
                                Name = s.Name,
                                Age = s.Age,
                                NumberOfEvaluations = s.Evaluations.Count
                            })
                            .ToList();

            return Ok(students);
        }
        [HttpGet]
        [Route("StudentWithEvalution")]
        [SwaggerOperation("StudentWithEvalution")]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.NotFound)]
        public IActionResult StudentWithEvalutionConcated()
        {

            var students = _context.Students
                            .Select(s => new StudentDto
                            {
                                Name = s.Name,
                                Age = s.Age,
                                Explanations = string.Join(",", s.Evaluations
            .Select(e => e.AdditionalExplanation))
                            })
                            .ToList();

            return Ok(students);
        }
        [HttpGet]
        [Route("FromSqlRawSample")]
        [SwaggerOperation("FromSqlRawSample")]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.NotFound)]
        public IActionResult FromSqlRawSample()
        {

            var student = _context.Students
     .FromSqlRaw(@"SELECT * FROM Student WHERE Name = {0}", "John Doe")
     .Include(e => e.Evaluations)
     .FirstOrDefault();

            return Ok(student);
        }
        [HttpGet]
        [Route("ExecuteSqlRawSample")]
        [SwaggerOperation("ExecuteSqlRawSample")]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.NotFound)]
        public IActionResult ExecuteSqlRawSample()
        {

            var rowsAffected = _context.Database
    .ExecuteSqlRaw(
        @"UPDATE Student
          SET Age = {0} 
          WHERE Name = {1}", 29, "Mike Miles");
            return Ok(new { RowsAffected = rowsAffected });
        }
        [HttpGet]
        [Route("ReloadSample")]
        [SwaggerOperation("ReloadSample")]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.NotFound)]
        public IActionResult ReloadSample()
        {

            var studentForUpdate = _context.Students
     .FirstOrDefault(s => s.Name.Equals("Mike Miles"));
            var age = 27;
            var rowsAffected = _context.Database
    .ExecuteSqlRaw(@"UPDATE Student 
                       SET Age = {0} 
                       WHERE Name = {1}", age, studentForUpdate.Name);
            _context.Entry(studentForUpdate).Reload();
            return Ok(new { RowsAffected = rowsAffected });
        }
    }
}
