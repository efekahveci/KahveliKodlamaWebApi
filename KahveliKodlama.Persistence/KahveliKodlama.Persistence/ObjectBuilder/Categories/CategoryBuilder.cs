
using KahveliKodlama.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace KahveliKodlama.Persistence.ObjectBuilder.Categories;

public class CategoryBuilder : EntityBuilder<Category>
{
    public override void MapEntity(ModelBuilder builder)
    {

        builder.Entity<Category>().HasData(new Category
        {
            Id = Guid.Parse("1ebf1452-3bdc-4618-a25a-c31575c89074"),
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
            Id = Guid.Parse("2ebf1452-3bdc-4618-a25a-c31575c89074"),
            CategoryName = "Angular",
            Status = true,
            LastModifyTime = DateTime.UtcNow,
            CategoryActive = true,
            CreatedTime = DateTime.UtcNow,
            CategoryDesc = "Angular JS | TypeScript | JavaScript | HTML | CSS",
            CategoryImage = "https://wikiimg.tojsiabtv.com/wikipedia/commons/thumb/c/cf/Angular_full_color_logo.svg/1200px-Angular_full_color_logo.svg.png",
            CategoryCode = "002",


        });
        builder.Entity<Category>().HasData(new Category
        {
            Id = Guid.Parse("3ebf1452-3bdc-4618-a25a-c31575c89074"),
            CategoryName = "Nesneye Yönelimli Programlama",
            Status = true,
            LastModifyTime = DateTime.UtcNow,
            CategoryActive = true,
            CreatedTime = DateTime.UtcNow,
            CategoryDesc = "SOLID | OOP | CLEAN CODE",
            CategoryImage = "https://www.educative.io/v2api/editorpage/4792707659595776/image/5909454286487552",
            CategoryCode = "003",


        });
        builder.Entity<Category>().HasData(new Category
        {
            Id = Guid.Parse("D5D89327-8E72-4C06-BEA3-BC47EBCD05A7"),
            CategoryName = "Software Engineering",
            Status = true,
            LastModifyTime = DateTime.UtcNow,
            CategoryActive = true,
            CreatedTime = DateTime.UtcNow,
            CategoryDesc = "ARCHITECTURE | DESIGN PATTERN",
            CategoryImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQhkxtBPjz_cFRYFHzR6XmfCIVFPEAZwpOlaA&usqp=CAU",
            CategoryCode = "004",


        });
    }
}
