
namespace portfolioClient.Repository
{
    public class CertificationRepository
    {
        public int certificationId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Uri link { get; set; }
        public string source { get; set; }
        public DateTime expiration { get; set; }

    }
}
