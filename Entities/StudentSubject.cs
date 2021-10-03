﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class StudentSubject
    {
      
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
