using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRouting_Prj.Models;

namespace AttributeRouting_Prj.Controllers
{
    [RoutePrefix("students")]
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>()
        {
            new Student{ID = 1, Name = "Pranav"},
              new Student{ID = 2, Name = "Vibhav"},
                new Student{ID = 3, Name = "Abhinav"},
                  new Student{ID = 4, Name = "gaurav"},
                   new Student{ID = 5, Name = "Gaurav"},
        };

        [HttpGet]
        [Route]
        public ActionResult GetAllStudents()
        {
            return View(students);
        }

        //one student by Id
        [HttpGet]
        [Route("{studentID:int:min(1):max(3)}")] // this can be replaced with range as belows
        //[Route("studentID:int:range(1,3)}"]
        public ActionResult GetStudentDetails(int studentID)
        {
            Student studentdetails = students.FirstOrDefault(s => s.ID == studentID);
            return View(studentdetails);
        }

        //student by the name
        [HttpGet]
        [Route("{studentname:alpha}")]
        public ActionResult GetStudentDetails(string studentname)
        {
            Student stddetails = students.FirstOrDefault(s => s.Name == studentname);
            return View(stddetails);
        }
        
        //get student course
        [HttpGet]
        [Route("{studentID}/courses")]
        public ActionResult GetStudentCourses(int studentID)
        {
            List<string> CourseList = new List<string>();
            if (studentID == 1)
                CourseList = new List<string>() { "ASP.Net", "C#.Net", "SQL" };
            else if(studentID == 2)
                CourseList = new List<string>() { "ASP.Net MVC", "C#.Net", "ADO.Net" };
            else if (studentID == 3)
                CourseList = new List<string>() { "ASP WEB API", "C#.Net", "Javascript" };
            else 
                CourseList = new List<string>() { "Bootstrap", "JQuery", "React" };

            ViewBag.CourseList = CourseList;
            return View();
        }

        //populating second model object
        [Route("~/technical/trainers")] //~ is to override a routeprefix
        public ActionResult GetTrainers()
        {
            List<Trainer> trainers = new List<Trainer>()
            {
                new Trainer{Id =100, Name="Monisha"},
                   new Trainer{Id =101, Name="BanuRekha"},
                      new Trainer{Id =102, Name="John Williams"},
            };
            return View(trainers);
        }
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
    }
}