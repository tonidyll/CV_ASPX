﻿using P1_ASP.Models;
namespace P1_ASP.Services { 
public class RepositoryOfProjects
{
    public List<ClassProjects> GetProjects()
    {
        return new List<ClassProjects>() {
            new ClassProjects {
                Title = "PMemory",
                Description = "Memory Game",
                Link = "https://github.com/tonidyll/Pmemory",
                ImageURL = "/images/pmemory.png"
            },
            new ClassProjects {
                Title = "RaspberryApacheProject - ONG",
                Description = "ONG website located into an raspberry apache srv",
                Link = "https://github.com/tonidyll/RaspberryApacheProject",
                ImageURL = "/images/webBuild.jpg"
            }, new ClassProjects {
                Title = "Driving School",
                Description = "Created with Java, this project is a platform where to register and manage a driving school",
                Link = "https://github.com/tonidyll/DrivingSchool",
                ImageURL = "/images/java.png"
            }, new ClassProjects {
                Title = "InteractiveTimeZoneChanger",
                Description = "This is an interactive map where , clicking into the different enabled zones you can see its actual day and hour",
                Link = "https://github.com/tonidyll/InteractiveTimeZoneChanger",
                ImageURL = "/images/js.png"
            }, new ClassProjects {
                Title = "ASP.net",
                Description = "Desc",
                Link = "https://desarrolloweb.com/home/asp",
                ImageURL = "/images/asp.jfif"
            }, new ClassProjects {
                Title = "React",
                Description = "WEB realized with React framework",
                Link = "https://es.reactjs.org/",
                ImageURL = "/images/react.png"
            },
        };
    }
  }
}