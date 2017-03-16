using ContosoUniversityCore.Data;
using ContosoUniversityCore.Models.AccountViewModels;
using System;
using System.Collections.Generic;

namespace ContosoUniversityCore.Models
{
    public enum LanguagesEnum
    {
        Arabic,
        English,
        French,
        Hungarian,
        Italian,
        Japanese,
        Swedish
    }
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        //public Languages NativeLanguage { get; set; }

        public LanguagesEnum NativeLanguage { get; set; }


        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
