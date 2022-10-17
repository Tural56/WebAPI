using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ReactWebAPI.Model
{
    public class DimNews
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string des { get; set; }

        public DateTime dateTime { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string source_link { get; set; }

        [Column(TypeName = "varbinary(max)")]
        public string? img { get; set; }
    }
}
