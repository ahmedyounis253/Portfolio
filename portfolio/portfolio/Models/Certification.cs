using System;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Collections.Generic;
namespace portfolio.Models
{
    public class Certification
    {
        public int certificationId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Uri link { get; set; }
        public string source { get; set; }
        public DateTime expiration { get; set; }

    }
}
