using P1_ASP.Models;
namespace P1_ASP.Services { 
public class RepositoryOfExperiences
{
    public List<ClassExperiences> GetExperiences()
    {
        return new List<ClassExperiences>() {
            new ClassExperiences {
                Title = "Flowers",
                Description = "Beauty flowers",
                Link = "https://amazon.com",
                ImageURL = "/images/flower.png"
            },
            new ClassExperiences {
                Title = "Java Script",
                Description = "Animación realizado en JS",
                Link = "https://Monlau.com",
                ImageURL = "/images/js.png"
            }, new ClassExperiences {
                Title = "ASP.net",
                Description = "WEB realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImageURL = "/images/asp.jfif"
            }, new ClassExperiences {
                Title = "Java",
                Description = "Java Projects",
                Link = "https://amazon.com",
                ImageURL = "/images/java.png"
            }, new ClassExperiences {
                Title = "ASP.net",
                Description = "Desc",
                Link = "https://amazon.com",
                ImageURL = "/images/flower.png"
            }, new ClassExperiences {
                Title = "React",
                Description = "WEB realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImageURL = "/images/react.png"
            },
        };
    }
  }
}