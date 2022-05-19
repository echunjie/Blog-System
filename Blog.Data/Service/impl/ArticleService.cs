using Blog.Data.Entity;
using Blog.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Service.impl
{
    public class ArticleService : Repository<Article>, IArticeService
    {
        public List<Article> GetArticles()
        {
            return base.GetList();
        }

        public string GetTest()
        {
            return "这是测试";
        }
    }
}
