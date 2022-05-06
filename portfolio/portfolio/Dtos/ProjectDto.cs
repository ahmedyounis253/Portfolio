using portfolio.Models;

namespace portfolio.Dtos
{
    public class ProjectDto
    {
        public string title { get; set; }
        public Uri github { get; set; }
        public string description { get; set; }
        public List<Skill> usedSkills { get; set; }
        public DateTime date { get; set; }
        public Uri vedioPath { get; set; }


    }
}
