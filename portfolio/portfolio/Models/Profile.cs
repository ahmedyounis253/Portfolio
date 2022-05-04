using System;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Collections.Generic;

namespace portfolio.Models
{
    public class Profile
    {
        public int profileId { get; set; }
        public string  name { get; set; }
        public string  preferedName { get; set; }
        public Uri imageUrl { get; set; }
        public Uri leetcode { get; set; }
        public Uri linkedin { get; set; }
        public Uri hackerRank { get; set; }
        public string description { get; set; }
        public Study study { get; set; }
        public ICollection<Skill> skills { get; set; }
        public ICollection<Project> projects { get; set; }



    }
}
