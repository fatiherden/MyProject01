using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyProject01.Models;

namespace MyProject01.Controllers;

public class PersonController : Controller
{

    IList<PersonViewModel> personList;
    public PersonController()
    {
        
    }

    [HttpPost]
    public IActionResult Index(int personId)
    {
        IList<PersonViewModel> personList = new List<PersonViewModel>(){
            new PersonViewModel(){ Id = 1, Name ="Fatih"},
            new PersonViewModel(){ Id = 2, Name ="Serhat"},  
            new PersonViewModel(){ Id = 3, Name ="M Fatih 1"},
            new PersonViewModel(){ Id = 4, Name ="M Fatih 3"}
        };

        ViewData["personList"] = personList;
        return View();
    }

    [HttpGet]
    public IActionResult Index()
    {
        IList<PersonViewModel> personList = new List<PersonViewModel>(){
            new PersonViewModel(){ Id = 1, Name ="Fatih"},
            new PersonViewModel(){ Id = 2, Name ="Serhat"},  
            new PersonViewModel(){ Id = 3, Name ="M Fatih 1"},
            new PersonViewModel(){ Id = 4, Name ="M Fatih 4"}
        };
        
        //studentList.Add(new Student(){ Id=4, Name = "Veli" });

        ViewData["personList"] = personList;
    
        return View();
    }

        public IActionResult List()
    {
            IList<PersonViewModel> personList = new List<PersonViewModel>(){
            new PersonViewModel(){ Id = 1, Name ="Fatih"},
            new PersonViewModel(){ Id = 2, Name ="Serhat"},  
            new PersonViewModel(){ Id = 3, Name ="M Fatih 1"},
            new PersonViewModel(){ Id = 3, Name ="M Fatih 2"}
        };
        
        //studentList.Add(new Student(){ Id=4, Name = "Veli" });

        ViewData["personList"] = personList;
    
        return View();
    }

    public IActionResult Update(int personId)
    {
        //var Id = HttpRequest["personId"];
        //var Id = Request["personId"];

        var Id = Request.QueryString.Value + Request.Query["veri1"] + Request.Query["veri2"];
        var getPerson = personList.Where(p => p.Id == personId);
        return View(getPerson);
    }

    public string Test1(int personId)
    {
        var bilgi = Request.QueryString.Value + Request.Query["veri1"] + Request.Query["veri2"];
        return bilgi;
    }

    public string Test11(int personId)
    {

        var Id = Request.QueryString.Value + Request.Query["veri1"] + Request.Query["veri2"];
        return Id;
    }


    public IActionResult Test()
    {
        return View();
    }

}
