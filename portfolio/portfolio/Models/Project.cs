using System;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Collections.Generic;
namespace portfolio.Models
{
    public class Project
    {
        public int projectId { get; set; }
        public string title { get; set; }
        public  Uri github { get; set; }
        public string description { get; set; }
        public ICollection<Skill> usedSkills { get; set; }
        public DateTime date { get; set; }
        public Uri vedioPath { get; set; }
        public Profile profile { get; set; }
        public int profileId { get; set; }


    }
}
