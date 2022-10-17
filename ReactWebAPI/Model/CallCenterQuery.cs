using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ReactWebAPI.Model
{
    public class CallCenterQuery
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime sending_time { get; set; }
        public string sender_name { get; set; }

        public string sender_surname { get; set; }
        
        public string sender_email { get; set; }
        public string number { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string text { get; set; }
    }
}
