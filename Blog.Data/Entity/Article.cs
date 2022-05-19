using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Blog.Data.Entity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_Article")]
    public partial class Article
    {
           public Article(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long Id {get;set;}

           /// <summary>
           /// Desc:文章标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Title {get;set;}

           /// <summary>
           /// Desc:作者名字
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Author {get;set;}

           /// <summary>
           /// Desc:摘要
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Summary {get;set;}

           /// <summary>
           /// Desc:关键字
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Keywords {get;set;}

           /// <summary>
           /// Desc:描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Description {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? State {get;set;}

           /// <summary>
           /// Desc:文章分类ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? CategoryId {get;set;}

           /// <summary>
           /// Desc:缩略图地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Thumbnail {get;set;}

           /// <summary>
           /// Desc:是否置顶0:否,1:是
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int IsTop {get;set;}

           /// <summary>
           /// Desc:浏览数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? ViewCount {get;set;}

           /// <summary>
           /// Desc:是否允许评论
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int IsComment {get;set ; }

           /// <summary>
           /// Desc:评论数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? CommentCount {get;set;}

           /// <summary>
           /// Desc:自定义链接
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UrlAddress {get;set;}

           /// <summary>
           /// Desc:创建人ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long UserId {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateTime {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdateTime {get;set;}

    }
}
