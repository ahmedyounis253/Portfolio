using portfolio.Dtos;
using portfolio.Models;

namespace portfolio.Data
{

    public static class Extensions
    {



        public static AdminDto AsDto(this Admin admin)


        {
            return new AdminDto
            {
                
                username = admin.username,
                birth = admin.birth,
                password = admin.password,
                phone = admin.phone,
                verificationCode = admin.verificationCode,
                isVerified = admin.isVerified,
                email=admin.email
            };

        }

        ////////////////////////////////////////



        public static ProfileDto AsDto(this Profile profile)


        {
            return new ProfileDto
            {
                name = profile.name,
                preferedName = profile.preferedName,
                imageUrl = profile.imageUrl,
                leetcode = profile.leetcode,
                linkedin = profile.linkedin,
                hackerRank = profile.hackerRank,
                description = profile.description,
                email=profile.email,
                profileId = profile.profileId,
            };


        }
        ////////////////////////////////////////    
        public static CertificationDto AsDto(this Certification certification)


        {
            return new CertificationDto
            {
                certificationId= certification.certificationId,
                title = certification.title,
                description = certification.description,
                link = certification.link,
                source = certification.source,
                expiration = certification.expiration

            };

        }
        ////////////////////////////////////////    
        public static List<CertificationDto> AsDto(this List<Certification> certifications)


        {
            List<CertificationDto> list = new List<CertificationDto>();
            foreach (Certification certification in certifications)
            {
                list.Add(certification.AsDto());

            };
            return list;
        }
        ///////////////////////////////////////
        public static FacultyDto AsDto(this Faculty faculty)


        {
            return new FacultyDto
            {
                facultyId= faculty.facultyId,
                title = faculty.title,
                faculty = faculty.faculty,
                university = faculty.university,
                field = faculty.field,
                enroll = faculty.enroll


            };

        }
        ////////////////////////////////////////    
        public static List<FacultyDto> AsDto(this List<Faculty> faculties)


        {    var list=new List<FacultyDto>();
            foreach (Faculty faculty in faculties)
            {
                list.Add(faculty.AsDto());
            }
            return list;
        }
        ///////////////////////////////

        public static ProjectDto AsDto(this Project project)


        {
            return new ProjectDto
            {
                projectId= project.projectId,
                title = project.title,
                github = project.github,
                description = project.description,
                usedSkills = project.usedSkills,
                date = project.date,
                vedioPath = project.vedioPath,



            };

        }
        ////////////////////////////////////////    

        public static List<ProjectDto> AsDto(this List<Project> projects)


        {
            var list=new List<ProjectDto>();
            foreach(var project in projects)
            {
                list.Add(project.AsDto());
            }
            return list;

        }
        ////////////////////////////////////////    

        public static SkillDto AsDto(this Skill skill)


        {
            return new SkillDto
            {
                skillId= skill.skillId,
                title = skill.title,
                description = skill.description,
                rate = skill.rate,



            };

        }
        ////////////////////////////////////////    
        public static StudyDto AsDto(this Study study)


        {
            return new StudyDto
            {
                
                faculties = study.faculties.AsDto(),
                certifications = study.certifications.AsDto(),

            };

        }
        ////////////////////////////////////////    

        /////////////////////////////    invese from Dto to Model ////////////////////////

        public static Admin AsModel(this AdminDto admin)


        {
            return new Admin
            {
                username = admin.username,
                birth = admin.birth,
                password = admin.password,
                phone = admin.phone,
                verificationCode = admin.verificationCode,
                isVerified = admin.isVerified,
                email = admin.email

            };


        }

        ////////////////////////////////////////



        public static Profile AsModel(this ProfileDto profile)


        {
            return new Profile
            {
                name = profile.name,
                preferedName = profile.preferedName,
                imageUrl = profile.imageUrl,
                leetcode = profile.leetcode,
                linkedin = profile.linkedin,
                hackerRank = profile.hackerRank,
                description = profile.description,
                email=  profile.email,
            };



        }
        ////////////////////////////////////////    
        public static Certification AsModel(this CertificationDto certification)


        {
            return new Certification
            {
                title = certification.title,
                description = certification.description,
                link = certification.link,
                source = certification.source,
                expiration = certification.expiration

            };

        }
        ////////////////////////////////////////    

        public static Faculty AsModel(this FacultyDto faculty)


        {
            return new Faculty
            {
                title = faculty.title,
                faculty = faculty.faculty,
                university = faculty.university,
                field = faculty.field,
                enroll = faculty.enroll


            };

        }
        ////////////////////////////////////////    


        public static Project AsModel(this ProjectDto project)


        {
            return new Project
            {
                title = project.title,
                github = project.github,
                description = project.description,
                usedSkills = project.usedSkills,
                date = project.date,
                vedioPath = project.vedioPath,



            };

        }
        ////////////////////////////////////////    

        public static Skill AsModel(this SkillDto skill)


        {


            return new Skill
            {
                title = skill.title,
                description = skill.description,
                rate = skill.rate,



            };

        }
        ////////////////////////////////////////    
        public static Study AsModel(this StudyDto study)


        {
            return new Study
            {
                faculties = study.faculties,
                certifications = study.certifications,

            };

        }
        ////////////////////////////////////////   

 


    }

}