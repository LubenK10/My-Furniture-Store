using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFurnitureShop.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurnitureShop.Infrastructure.Data.Configure
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
      public void Configure(EntityTypeBuilder<User> builder)
      {
          builder
              .Property(p => p.IsActive)
              .HasDefaultValue(true);
     
          builder.HasData(CreateUsers());
      }
     
      private List<User> CreateUsers()
      {
          var users = new List<User>();
          var hasher = new PasswordHasher<User>();
     
          var user = new User()
          {
              Id = "3ccf3f38-c3da-44c2-b658-a2030620bd8e",
              UserName = "Ivan2020",
              NormalizedUserName = "IVAN2020",
              Email = "manager@gmail.com",
              NormalizedEmail = "MANAGER@GMAIL.COM"
          };
     
          user.PasswordHash =
               hasher.HashPassword(user, "123456");
     
          users.Add(user);
     
          user = new User()
          {
              Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
              UserName = "DimitarK10",
              NormalizedUserName = "DIMITARK10",
              Email = "user@gmail.com",
              NormalizedEmail = "USER@GMAIL.COM"
          };
     
          user.PasswordHash =
          hasher.HashPassword(user, "123456");
     
          users.Add(user);
     
          return users;
      }
    }
}
