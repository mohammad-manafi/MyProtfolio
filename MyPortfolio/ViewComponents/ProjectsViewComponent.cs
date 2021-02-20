using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Collections.Generic;

namespace MyPortfolio.ViewComponents
{
    public class ProjectsViewComponent: ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            var Projects = new List<Project>
            {
                new Project(id:1,name:"پروژه بانک تجارت",description:"طراحی صفحه اول پروژه بانک تجارت در سال 1398",image:"project-1.jpg",client:"Manafi's Project"),
                new Project(id:2,name:"پروژه طراحی سایت شرکت مدار گسترش فناوری اطلاعات ",image:"project-2.jpg",description:" طراحی صفحات اول تا سوم سایت به صورت فرانت اند به صورت پروژه محور در سال 1399 توسط تیم دانت نت مدار گسترش و بنده به قبت رسید ",client:"Manafi's Project"),
                new Project(id:3,name:"پروژه طراحی سایت فروشگاه اینترنتی ",image:"project-3.jpg",description:"طراحی فروشگاه اینترنی با امکاناتی همانند دیجی کالا با زبان برنامه نویسی سی شارپ تحت فریم ورک ASP.Net Core 1.11 ",client:"Manafi's Project"),
                new Project(id:4,name:"پروژه مواد شوینده و بهداشتی  ",image:"project-4.jpg",description:"طراحی سایت فروشگاهی در سال 1399-1400",client:"Manafi's Project")
            };

            return View("_Projects", Projects);
        }
    }
}
