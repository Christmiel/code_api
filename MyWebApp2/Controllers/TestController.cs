using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using MyWebApp2.Model;


namespace MyWebApp2.Controllers 

{
    public class TestController : Controller
{
    public IActionResult Index()
    {
        IList<string> items = new List<string>();
        items.Add("Alida");
        items.Add("Fifame");
        items.Add("Gloria");
        items.Add("Mondukpe");
        ViewData["email"] = "alida@gmail.com";
         ViewBag.contact = "ESF@contact";
          return View(items);
    }

         public IActionResult List()
    {
        IList<Student> students = new List<Student>();
        students.Add(new Student{Id=1, Name="Alida", Score=59});
        students.Add(new Student{Id=2, Name="Fifame", Score=45});
        students.Add(new Student{Id=3, Name="Hassan", Score=66});
        return View( students);
    }

    public IActionResult A()
    {
        return View();
    }

   

     public IActionResult B()
    {
        return View("BB");
    }
}
}