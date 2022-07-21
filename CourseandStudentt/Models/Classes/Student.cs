using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseandStudentt.Models.Classes
{
    public class Student
    {
        [Key]  //key parametresi ile bir primarykey oluşturularak ilişki ve takip konusunda kolaylık sağlandı
        
        public int StudentID { get; set; }  //öğrenci numarası her öğrenci için benzersiz olmalıdır primarykey olduğu için benzersiz
        
        public string StudentName { get; set; } // öğrenci ismi

        public string StudentSurname { get; set; } // öğrenci soyadı

        public DateTime StudentBirthdate { get; set; } // öğrenci doğum tarihi
        public int CourseID { get; set; }
        public virtual Course Course { get; set; } //öğrenci tablosu ile kurs tablosu arasındaki ilişki her öğrenci 1 kurs alabilir
    }
}