using System;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Collections.Generic;
namespace portfolio.Models
{
    public  class Skill
    {
        public int skillId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int rate { get; set; }
        public Profile profile { get; set; }
        public int profileId { get; set; }

    }
}
