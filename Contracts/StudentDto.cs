using System;
using System.Collections.Generic;

namespace Contracts
{
    public class StudentDto
    {
       
        public Guid StudentId { get; set; }
       
        public string Name { get; set; }
        public int? Age { get; set; }
       
        public int LocalCalculation { get; set; }
        public string Explanations { get; set; }
        public bool IsRegularStudent { get; set; }
        public int NumberOfEvaluations { get; set; }
        public StudentDetailsDto StudentDetails { get; set; }
        public ICollection<EvaluationDto> Evaluations { get; set; }
        public ICollection<StudentSubjectDto> StudentSubjects { get; set; }
    }
}
