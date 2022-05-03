using System;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Collections.Generic;
namespace portfolio.Models
{
    public class Study
    {
        public int studyId { get; set; }
        public ICollection<Certification> certifications { get; set; }
        public ICollection<Faculty> faculties { get; set; }
        public int profileId { get; set; }
        public Profile profile { get; set; }
    }
}
