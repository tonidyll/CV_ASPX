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
                Dates="nov. 2020 - nov 2021 · 1 Año 1 Mes",
                Link = "https://www.sosmatic.es/",
                Description="Asistencia vía telefonica a empresas y usuarios, resolucion de incidencias L1 y L2",
                ImageURL = "/images/sosmatic.jfif"
            },
            new ClassExperiences {
                Job = "Web Developer",
                EnterpriseName = "NTTData",
                Dates="may. 2022 - Actualmente",
                Link = "https://es.nttdata.com/",
                Description= "Testing de aplicaciones, documentación técnica y desarrollo web",
                ImageURL = "/images/nttdata.jpg"
            }
        };
    }
  }
}