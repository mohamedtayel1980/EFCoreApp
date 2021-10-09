using System;

namespace Contracts
{
    public class EvaluationDto
    {
       
        public Guid Id { get; set; }
       
        public int Grade { get; set; }
        public string AdditionalExplanation { get; set; }
     
        public Guid StudentId { get; set; }
    }
}