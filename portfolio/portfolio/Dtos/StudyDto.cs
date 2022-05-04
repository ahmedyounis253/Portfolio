using portfolio.Models;

namespace portfolio.Dtos
{
    public class StudyDto
    {
        public ICollection<Certification> certifications { get; set; }
        public ICollection<Faculty> faculties { get; set; }

    }
}
