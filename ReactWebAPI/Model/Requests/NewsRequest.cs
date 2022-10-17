using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReactWebAPI.Model.Requests
{
    public class NewsRequest
    {
        public string Name { get; set; }

        
        public string des { get; set; }

        
        public string text { get; set; }

        
        public string source_link { get; set; }

        
        public string? img { get; set; }
    }
}
