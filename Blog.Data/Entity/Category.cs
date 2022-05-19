using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Entity
{

    [SugarTable("t_category")]
    public partial class Category
    {

        public Category()
        {

        }

        /// <summary>
        /// Desc:主键
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public long Id { get; set; }

        /// <summary>
        /// Desc:分类名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Name { get; set; }

        /// <summary>
        /// Desc:类型  1目录，2菜单，3页面
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? Type { get; set; }

        /// <summary>
        /// Desc:关键字
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Keywords { get; set; }

        /// <summary>
        /// Desc:简介
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Summary { get; set; }

        /// <summary>
        /// Desc:父ID
        /// Default:
        /// Nullable:True
        /// </summary>           
        public long? ParentId { get; set; }

        /// <summary>
        /// Desc:图标
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Icon { get; set; }

        /// <summary>
        /// Desc:状态1 可用 0禁用
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? State { get; set; }

        /// <summary>
        /// Desc:顺序
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? SortNum { get; set; }

        /// <summary>
        /// Desc:创建时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Desc:修改时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Desc:创建人
        /// Default:
        /// Nullable:True
        /// </summary>           
        public long? Creater { get; set; }

    }
}
