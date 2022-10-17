namespace ReactWebAPI.Model.Requests
{
    public class DimNewsRequest
    {
        public string Name { get; set; }

        public string des { get; set; }

        public DateTime date { get; set; }

        public string source_link { get; set; }

        public string? img { get; set; }
    }
}
