using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Models
{
    public class Student
    {
        [Key]
        [Column("Student_ID")]
        public int Id { get; set; }

        [Column("StudentName",TypeName = "varchar(60)")]
        public string Name { get; set; }

        [Column("StudentGender", TypeName = "varchar(7)")]
        public string Gender { get; set; }

        [Column("Student_Age")]
        public int Age { get; set; }
        

    }
}
