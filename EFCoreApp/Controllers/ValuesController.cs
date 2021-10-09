using Contracts;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        //[HttpPost]
        //public IActionResult AllStudents()
        //{

        //    var students = _context.Students
        //                    .Select(s => new StudentDto
        //                    {
        //                        Name = s.Name,
        //                        Age = s.Age,
        //                        NumberOfEvaluations = s.Evaluations.Count
        //                    })
        //                    .ToList();

        //    return Ok(students);
        //}
        [HttpPost]
        public IActionResult StudentWithEvalutionConcated(int id = 0)
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
    }
}
