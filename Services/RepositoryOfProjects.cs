using P1_ASP.Models;
namespace P1_ASP.Services { 
public class RepositoryOfProjects
{
    public List<ClassStudiedCourses> GetProjects()
    {
        return new List<ClassStudiedCourses>() {
            new ClassStudiedCourses {
                Title = "Flowers",
                Description = "Beauty flowers",
                Link = "https://amazon.com",
                ImageURL = "/images/flower.png"
            },
            new ClassStudiedCourses {
                Title = "Java Script",
                Description = "Animación realizado en JS",
                Link = "https://Monlau.com",
                ImageURL = "/images/js.png"
            }, new ClassStudiedCourses {
                Title = "ASP.net",
                Description = "WEB realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImageURL = "/images/asp.jfif"
            }, new ClassStudiedCourses {
                Title = "Java",
                Description = "Java Projects",
                Link = "https://amazon.com",
                ImageURL = "/images/java.png"
            }, new ClassStudiedCourses {
                Title = "ASP.net",
                Description = "Desc",
                Link = "https://amazon.com",
                ImageURL = "/images/flower.png"
            }, new ClassStudiedCourses {
                Title = "React",
                Description = "WEB realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImageURL = "/images/react.png"
            },
        };
    }
  }
}