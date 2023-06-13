using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {

                Id = Guid.NewGuid(),
                Title = "Title",
                Content = "default article",
                ViewCount = 15,
                CategoryId = Guid.Parse("339A5D56-707B-41B4-97A2-C0F5498CEDBA"),
                ImageId = Guid.Parse("096B47D9-5EC6-4013-8F2C-F956A56A5BC6"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Title 2",
                Content = "default article 2",
                ViewCount = 15,
                CategoryId = Guid.Parse("660FF4ED-76A3-466B-85D5-A9FFAD174446"),
                ImageId = Guid.Parse("CE9F3478-5F88-4250-B1CB-A38282CD3875"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,

            }
            
            
            );

        }
    }
}
