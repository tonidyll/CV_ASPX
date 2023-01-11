using P1_ASP.Models;
namespace P1_ASP.Services { 
public class RepositoryOfExperiences
{
    public List<ClassExperiences> GetExperiences()
    {
        return new List<ClassExperiences>() {
            new ClassExperiences {
                Job = "Technical Support Help Desk",
                EnterpriseName = "Sosmatic",
                Dates="nov. 2020 - nov. 2021 · 1 Year 1 Month",
                Link = "https://www.sosmatic.es/",
                Description="Helpdesk Support L1 and L2 from particular costumers to enterprises",
                ImageURL = "/images/sosmatic.jfif"
            },
            new ClassExperiences {
                Job = "Web Developer",
                EnterpriseName = "NTTData",
                Dates="may. 2022 - Current",
                Link = "https://es.nttdata.com/",
                Description= "App Testing, Technical documentation, Web development. Creating a project from 0 to production",
                ImageURL = "/images/nttdata.jpg"
            }
        };
    }
  }
}