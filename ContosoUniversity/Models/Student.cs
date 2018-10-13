using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    // table
    public class Student
    {
        // columns
        // pk
        public int ID { get; set; }

        [Required(ErrorMessage = "Last Name Must Be Required")]
        [MaxLength(30,ErrorMessage ="Maximum Length Must Be 30")]
        [Display(Name ="Last Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage ="PLease Must Start With Capital Letter And Not Start Number")]
        public string LastName { get; set; }
        //#####################
        [Required(ErrorMessage = "First Name Must Be Required")]
        [MaxLength(30, ErrorMessage = "Maximum Length Must Be 30")]
        [Display(Name = "First Name")]
        [Column("First Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Must Start With Capital Letter")]
        public string FirstMidName { get; set; }
        //#########################
        [DataType(DataType.Date)]
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
        //#########################
        public String FullName {
            get {
                return FirstMidName + " " + LastName;
            }
        }
        // relationship
        // Navigation properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}