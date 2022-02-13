
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
                Status =  true ,
                LastModifyTime = DateTime.UtcNow,
                CategoryActive = true ,
                CreatedTime = DateTime.UtcNow,
                CategoryClick = 54,
                CategoryCode ="001",
               

            });
            builder.Entity<Category>().HasData(new Category
            {
                Id = 2,
                CategoryName = "Angular",
                Status = true,
                LastModifyTime = DateTime.UtcNow,
                CategoryActive = true,
                CreatedTime = DateTime.UtcNow,
                CategoryClick = 20,
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
                CategoryClick = 4,
                CategoryCode = "003",


            });
        }
    }
}
