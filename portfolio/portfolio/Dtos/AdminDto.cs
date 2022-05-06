
namespace portfolio.Dtos
{
    public class AdminDto
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool isVerified{ get; set; }
        public string verificationCode { get; set; }
        public DateTime birth { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }
}
