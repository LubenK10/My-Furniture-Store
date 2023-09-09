using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFurnitureShop.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MyFurnitureShop.Infrastructure.Data.Configure
{
    internal class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
       public void Configure(EntityTypeBuilder<Manager> builder)
       {
           builder.HasData(AllManagers());
       }
       
       private List<Manager> AllManagers()
       {
           var managers = new List<Manager>();
       
           var manager = new Manager()
           {
               Id = 1,
               UserId = "3ccf3f38-c3da-44c2-b658-a2030620bd8e"
           };

            managers.Add(manager);

            return managers;
       }
    }
}
