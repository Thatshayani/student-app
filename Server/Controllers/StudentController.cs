using Microsoft.AspNetCore.Mvc;
using StudentApp.Shared;

namespace ForecastApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
      
        
        private static readonly List<Student> students = new List<Student>(){
            new Student(){
                
            BirthOfDate= new DateTime(2005, 10, 30),
            Class="13A",
            Name="Abishek",
            Stream="Physical Science"

            },
            new Student(){
                
            BirthOfDate= new DateTime(2005, 08, 16),
            Class="13D",
            Name="Anne",
            Stream="Commerce"

            },
            new Student(){
                
            BirthOfDate= new DateTime(2005, 10, 04),
            Class="13B",
            Name="Loshiny",
            Stream="Biological Science"

            },
            new Student(){
                
            BirthOfDate= new DateTime(2005, 02, 15),
            Class="13D",
            Name="Pragya",
            Stream="Commerce"

            },
            new Student(){
                
            BirthOfDate= new DateTime(2005, 03, 27),
            Class="13C",
            Name="Laxshiny",
            Stream="Arts"

            },
            new Student(){
                
            BirthOfDate= new DateTime(2005, 04, 23),
            Class="13B",
            Name="Shaliny",
            Stream="Biological Science"

            },
            new Student(){
                
            BirthOfDate= new DateTime(2005, 05, 09),
            Class="13C",
            Name="Gowri",
            Stream="Arts"

            },
            
            new Student(){
                
            BirthOfDate= new DateTime(2005, 05, 17),
            Class="13A",
            Name="Thivya",
            Stream="Physical Science"

            },
            new Student(){
                
            BirthOfDate= new DateTime(2005, 07, 20),
            Class="13D",
            Name="Ramesh",
            Stream="Commerce"

            },
            new Student(){
                
            BirthOfDate= new DateTime(2005, 08, 05),
            Class="13A",
            Name="Zainab",
            Stream="Physical Science"

            },
            
        };

            private readonly ILogger<StudentController> _logger;

            public StudentController(ILogger<StudentController> logger)
            {
                _logger = logger;
            }

            [HttpGet]
            public IEnumerable<Student> Get()
            {
                return students;
            }
        }
    }