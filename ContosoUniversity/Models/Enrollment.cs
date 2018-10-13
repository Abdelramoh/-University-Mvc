using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        // pk
        public int EnrollmentID { get; set; }

        //foreign key
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        //The Grade property is an enum (. The question mark after the Grade type declaration indicates that the Grade property is nullable
        
                [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }
      //  An Enrollmententity is associated with one Course entity.
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}