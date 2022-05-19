using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repository
{
    public class Repository<T> : SimpleClient<T> where T : class, new()
    {
        public Repository(ISqlSugarClient context = null) : base(context)
        {
            if (context == null)
            {
                base.Context = new SqlSugarClient(new ConnectionConfig()
                {
                    DbType = SqlSugar.DbType.MySql,
                    InitKeyType = InitKeyType.Attribute,
                    IsAutoCloseConnection = true,
                    ConnectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString
                });

                base.Context.Aop.OnLogExecuting = (s, p) =>
                {
                    Console.WriteLine(s);
                };
            }
        }
        /// <summary>
        /// 扩展方法，自带方法不能满足的时候可以添加新方法
        /// </summary>
        /// <returns></returns>
        public List<T> CommQuery(string json)
        {
            T t = Context.Utilities.DeserializeObject<T>(json);
            var list = base.Context.Queryable<T>().WhereClass(t).ToList();
            return list;
        }
    }
}
