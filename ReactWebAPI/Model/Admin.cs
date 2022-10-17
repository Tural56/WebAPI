using System.ComponentModel.DataAnnotations;

namespace ReactWebAPI.Model
{
    public class Admin
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string token { get; set; }
    }
}
