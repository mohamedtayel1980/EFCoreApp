using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [Column("StudentId")]
        public Guid StudentId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters")]
        public string Name { get; set; }
        public int? Age { get; set; }
        [NotMapped]
        public int LocalCalculation { get; set; }

        public bool IsRegularStudent { get; set; }

        public StudentDetails StudentDetails { get; set; }
    }
}
