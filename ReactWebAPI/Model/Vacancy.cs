using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ReactWebAPI.Model
{
    public class Vacancy
    {
        [Key]
        public Guid VacancyId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string department { get; set; }

        public DateTime sending_Time { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public int family_satus { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string date_of_birth { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string adress { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string info_about_us { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Telefon { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Mobil { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string knowledge_of_pc { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string foreign_language { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string branch_for_work { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string teaching_language { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string university_b { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Qualification { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string medium_rainting { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string receipt_date { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string organization_name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string work_position { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string work_experience { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string des { get; set; }
    }
}
