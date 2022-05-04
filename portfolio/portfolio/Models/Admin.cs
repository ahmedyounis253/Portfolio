using System;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace portfolio.Models
{
    public class Admin
    {
        [Key]
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string verificationCode { get; set; }
        public DateTime birth { get; set; }
        public string phone { get; set; }
        public bool isVerified { get; set; }







    }
}
