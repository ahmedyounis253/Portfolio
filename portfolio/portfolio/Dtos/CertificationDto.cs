namespace portfolio.Dtos
{
    public class CertificationDto
    {
        public string title { get; set; }
        public string description { get; set; }
        public Uri link { get; set; }
        public string source { get; set; }
        public DateTime expiration { get; set; }

    }
}
