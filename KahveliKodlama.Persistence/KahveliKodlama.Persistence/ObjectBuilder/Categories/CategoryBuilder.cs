
using KahveliKodlama.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Persistence.ObjectBuilder.Categories
{
    public class CategoryBuilder : EntityBuilder<Category>
    {
        public override void MapEntity(ModelBuilder builder)
        {

            builder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                CategoryName = ".Net Core",
                Status = true,
                LastModifyTime = DateTime.UtcNow,
                CategoryActive = true,
                CreatedTime = DateTime.UtcNow,
                CategoryDesc = "C# | MVC | WEB API | BLAZOR",
                CategoryImage = "https://okankaradag.com/wp-content/uploads/2021/06/asp.net-core-logo.png",
                CategoryCode = "001",


            }); ;
            builder.Entity<Category>().HasData(new Category
            {
                Id = 2,
                CategoryName = "Angular",
                Status = true,
                LastModifyTime = DateTime.UtcNow,
                CategoryActive = true,
                CreatedTime = DateTime.UtcNow,
                CategoryDesc= "Angular JS | TypeScript | JavaScript | HTML | CSS",
                CategoryImage= "https://wikiimg.tojsiabtv.com/wikipedia/commons/thumb/c/cf/Angular_full_color_logo.svg/1200px-Angular_full_color_logo.svg.png",
                CategoryCode = "002",


            });
            builder.Entity<Category>().HasData(new Category
            {
                Id = 3,
                CategoryName = "Nesneye Yönelimli Programlama",
                Status = true,
                LastModifyTime = DateTime.UtcNow,
                CategoryActive = true,
                CreatedTime = DateTime.UtcNow,
                CategoryDesc= "SOLID | OOP | CLEAN CODE",
                CategoryImage= "https://www.educative.io/v2api/editorpage/4792707659595776/image/5909454286487552",
                CategoryCode = "003",


            });
        }
    }
}
