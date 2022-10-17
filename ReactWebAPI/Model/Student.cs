using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReactWebAPI.Model
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string surname { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string group { get; set; }

        ///delete
        [Column(TypeName = "nvarchar(max)")]
        public string des { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string text { get; set; }

        [Column(TypeName = "varbinary(max)")]
        public string? img { get; set; }
    }
}
