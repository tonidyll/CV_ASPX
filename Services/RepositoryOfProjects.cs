using P1_ASP.Models;
namespace P1_ASP.Services { 
public class RepositoryOfProjects
{
    public List<ClassProjects> GetProjects()
    {
        return new List<ClassProjects>() {
            new ClassProjects {
                Title = "Flowers",
                Description = "Beauty flowers",
                Link = "https://amazon.com",
                ImageURL = "/images/flower.png"
            },
            new ClassProjects {
                Title = "Java Script",
                Description = "Animación realizado en JS",
                Link = "https://Monlau.com",
                ImageURL = "/images/js.png"
            }, new ClassProjects {
                Title = "ASP.net",
                Description = "WEB realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImageURL = "/images/asp.jfif"
            }, new ClassProjects {
                Title = "Java",
                Description = "Java Projects",
                Link = "https://amazon.com",
                ImageURL = "/images/java.png"
            }, new ClassProjects {
                Title = "ASP.net",
                Description = "Desc",
                Link = "https://amazon.com",
                ImageURL = "/images/flower.png"
            }, new ClassProjects {
                Title = "React",
                Description = "WEB realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImageURL = "/images/react.png"
            },
        };
    }
  }
}