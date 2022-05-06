using System;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Collections.Generic;
namespace portfolio.Models
{
    public  class Faculty
    {
        public int facultyId { get; set; }
        public string title { set; get; }
        public string faculty { get; set; }
        public string university { get; set; }
        public string field { get; set; }
        public DateTime enroll { get; set; }
        public DateTime graduation { get; set; }
        public Study study { get; set; }
        public int studyId { get; set; }
    }
}
