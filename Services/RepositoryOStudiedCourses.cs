using Microsoft.AspNetCore.Components.Forms;
using P1_ASP.Models;
namespace P1_ASP.Services { 
public class RepositoryOStudiedCourses
    {
    public List<ClassStudiedCourses> GetStudiesCourses()
    {
            return new List<ClassStudiedCourses>() {
            new ClassStudiedCourses {
                Title = "Medium Grade - Microcomputer Systems (SMX)",
                Link = "https://monlau.com",
                Dates="Sept. 2018 - jun.2021",
                Location="Barcelona",
                ImageURL = "/images/smx.png"
            },
            new ClassStudiedCourses {
                Title = "Superior Grade - Web App Development (DAW)",
                Link = "https://monlau.com",
                Dates="Sept. 2022 - Current",
                Location="Barcelona",
                ImageURL = "/images/react.png"
            },
        };
    }
  }
}