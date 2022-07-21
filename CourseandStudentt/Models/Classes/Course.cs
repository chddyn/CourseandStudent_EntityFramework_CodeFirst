using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseandStudentt.Models.Classes
{
    public class Course
    {
        [Key]  //key parametresi ile bir primarykey oluşturularak ilişki ve takip konusunda kolaylık sağlandı

        public int CourseID { get; set; } // kurs id benzersiz ve int türünde

        public string CourseName { get; set; } // kurs adı

        public virtual ICollection<Student> Students { get; set; } // bir kursu 1 den fazla öğrenci alabileceği için collection türünde tuttum
    }
}