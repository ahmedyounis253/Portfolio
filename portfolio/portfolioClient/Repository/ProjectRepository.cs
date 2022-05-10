using System.ComponentModel.DataAnnotations;


namespace portfolioClient.Repository
{
    public class ProjectRepository
    {
        [Required(ErrorMessage ="title is required.")]
        public string title { get; set; }
        [Required(ErrorMessage ="github Url is required.")]
        public Uri github { get; set; }
        [Required(ErrorMessage = "you need to descripe your project.")]
        public string description { get; set; }
        [Required(ErrorMessage ="you need to mention skills you used.")]
        public List<SkillRepository> usedSkills { get; set; }
        [Required(ErrorMessage = "you need to set project date.")]
        public DateTime date { get; set; }
        [Required(ErrorMessage = "you need a vedio for you project ")]
        public Uri vedioPath { get; set; }


    }
}
