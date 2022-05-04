using portfolio.Dtos;
using portfolio.Models;

namespace portfolio.Data
{
    public class Extentions
    {

        public static AdminDto AsDto(this Admin admin)
        
        
        {
            return new AdminDto {
                username = admin.username,
                birth = admin.birth,
                password = admin.password,
                phone = admin.phone,
                verificationCode = admin.verificationCode,
                isVerified=admin.isVerified
            }
            
        }

        ////////////////////////////////////////
        
        
        
        public static ProfileDto AsDto(this Profile profile)


        {
            return new ProfileDto
            {
                name =profile.name,
                preferedName=profile.preferedName, 
                imageUrl = profile.imageUrl,
                leetcode =profile.leetcode,
                linkedin=profile.linkedin,
                hackerRank=profile.hackerRank,
                description= profile.description,
             }

                
        }
        ////////////////////////////////////////    
        public static CertificationDto AsDto(this Certification certification)


        {
            return new CertificationDto
            {
                title=certification.title,
                description=certification.description,
                link=certification.link,
                source=certification.source,
                expiration=certification.expiration

            }

        }
        ////////////////////////////////////////    

        public static FacultyDto AsDto(this Faculty faculty)


        {
            return new FacultyDto
            {
                title = faculty.title,
                faculty = faculty.faculty,
                university = faculty.university,
                field = faculty.field,
                enroll = faculty.enroll


            }

        }
        ////////////////////////////////////////    


        public static ProjectDto AsDto(this Project project)


        {
            return new ProjectDto
            {
                title = project.title,
                github = project.github,
                description = project.description,
                usedSkills = project.usedSkills,
                date = project.date,
                vedioPath=project.vedioPath,



            }

        }
        ////////////////////////////////////////    

        public static SkillDto AsDto(this Skill skill)


        {
            return new SkillDto
            {
                title = skill.title,
                description = skill.description,
                rate = skill.rate,



            }

        }
        ////////////////////////////////////////    
        public static StudyDto AsDto(this Study study)


        {
            return new StudyDto
            {
                faculties=study.faculties,
                certifications=study.certification,

            }

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
                isVerified = admin.isVerified
            }


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
            }



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

            }

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


            }

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



            }

        }
        ////////////////////////////////////////    

        public static Skill AsModel(this SkillDto skill)


        {
            return new Skill
            {
                title = skill.title,
                description = skill.description,
                rate = skill.rate,



            }

        }
        ////////////////////////////////////////    
        public static Study AsModel(this StudyDto study)


        {
            return new Study
            {
                faculties = study.faculties,
                certifications = study.certification,

            }

        }
        ////////////////////////////////////////   




    }
}
