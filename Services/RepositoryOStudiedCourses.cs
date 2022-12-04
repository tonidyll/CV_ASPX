﻿using Microsoft.AspNetCore.Components.Forms;
using P1_ASP.Models;
namespace P1_ASP.Services { 
public class RepositoryOStudiedCourses
    {
    public List<ClassStudiedCourses> GetStudiesCourses()
    {
            return new List<ClassStudiedCourses>() {
            new ClassStudiedCourses {
                Title = "Grado Medio - Sistemas Microinformáticos y redes",
                Link = "https://monlau.com",
                InitDate="Setiembre, 2018",
                EndDate="Junio, 2021",
                Location="Barcelona",
                ImageURL = "/images/smx.png"
            },
            new ClassStudiedCourses {
                Title = "Grado Superior - Desarrolo de Aplicaciones Web",
                Link = "https://monlau.com",
                InitDate="Setiembre, 2020",
                EndDate="*Current*",
                Location="Barcelona",
                ImageURL = "/images/react.png"
            },
        };
    }
  }
}