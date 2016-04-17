using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Xml.Linq;
using TexTalkAPI.Classes;

namespace TexTalkAPI.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/Article")]
    public class ArticleController : ApiController
    {
        [Route("GetArticles")]
        [AllowAnonymous]
        public List<Article> GetArticles()
        {
            var articles = GetArticlesFromXml();

            return articles;
        }

        private static List<Article> GetArticlesFromXml()
        {
            var xmlArticles = XDocument.Load(HttpContext.Current.Server.MapPath("~/Articles/Articles.xml"));

            var articles = xmlArticles.Element("Articles")?.Elements("Article").
                Select(e => new Article
                {
                    HeaderText = (string)e.Element("Header"),
                    IngressText = (string)e.Element("Ingress"),
                    BodyText = e.Element("BodyText")?.Elements("Paragraph"),
                    DisplayIndex = int.Parse((string)e.Element("DisplayIndex")),
                    ImagePath = (string)e.Element("ImagePath"),
                })
                .ToList();

            return articles;
        }
    }
}