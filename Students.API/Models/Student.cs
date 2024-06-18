using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Students.API.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public long s_id { get; set; }
        public string? s_name { get; set; }
        public string? s_c_num { get; set; }
        public int s_age { get; set; }
        public DateOnly? s_birth { get; set; }

    }
}
