using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNet.Data;

namespace EntityFrameworkAllInOne
{
    public class Stock
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class News
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Data { get; set; }
    }

    public class StockMap : EntityTypeConfiguration<Stock>
    {
        public StockMap()
        {
            ToTable("Stock");
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }

    //http://www.cnblogs.com/lsxqw2004/p/4701979.html 不错的讲解ef映射关系的文章 强烈推荐
    public class NewsMap : EntityTypeConfiguration<News>
    {
        public NewsMap()
        {
            ToTable("News");
            //ToTable("News","newdbo") 指定schema，不实用默认的dbo
            HasKey(p => p.Id);//普通主键
            //HasKey(p=>new {p.Id,p.Name}) 联合主键（关联主键）
            //Property(p=>p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)//不让主键作为Identity自动生成
            //Property(p => p.Name).IsRequired().HasMaxLength(20).HasColumnName("ProductName").IsUnicode(false);//非空 最大长度20 自定义列名 列类型为varchar而非nvarchar
            //Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //Ignore(p=>p.Data) 从模型中排除某个属性 不映射到数据库上
        }
    }

    public class StockRepository : EntityFrameworkRepository<Stock>
    {
        public StockRepository(IDbContext context, bool isNoTracking) : base(context, isNoTracking)
        {
        }
    }

    public class NewRepository : EntityFrameworkRepository<News>
    {
        public NewRepository(IDbContext context, bool isNoTracking) : base(context, isNoTracking)
        {

        }
    }
}
