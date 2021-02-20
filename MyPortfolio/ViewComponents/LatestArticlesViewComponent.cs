using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Collections.Generic;


namespace MyPortfolio.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(id:1 , title:" Asp.net core Mvc",description:"بهترین ها را از ما بخواهید",image:"blog-post-thumb-1.jpg"),
                new Article(id:1 , title:" Asp.net core Mvc",description:"بهترین ها را از ما بخواهید",image:"blog-post-thumb-1.jpg"),
                new Article(id:1 , title:" Asp.net core Mvc",description:"بهترین ها را از ما بخواهید",image:"blog-post-thumb-1.jpg"),
                new Article(id:1 , title:" Asp.net core Mvc",description:"بهترین ها را از ما بخواهید",image:"blog-post-thumb-1.jpg")
            };

            return View("_LatestArticles", articles);
        }
    }
}
