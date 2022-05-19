using Blog.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Service
{
    public interface IArticeService
    {

        List<Article>  GetArticles();

        string GetTest();
    }
}
