using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Entity
{

    [SugarTable("t_article_content")]
    public partial class ArticleContent
    {


        public ArticleContent()
        {

        }
        /// <summary>
        /// Desc:文章表主键
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true)]
        public long Id { get; set; }

        /// <summary>
        /// Desc:文章详情
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Content { get; set; }

    }
}
