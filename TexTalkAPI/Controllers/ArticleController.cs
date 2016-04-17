using System.Collections.Generic;
using System.Web.Http;
using TexTalkAPI.Classes;

namespace TexTalkAPI.Controllers
{
    public class ArticleController
    {
        [Route("GetArticles")]
        public List<Article> GetArticles()
        {
            var articles = GetArticlesFromXML();

            return articles;
        }

        private List<Article> GetArticlesFromXML()
        {
            return new List<Article>();
        }
    }
}