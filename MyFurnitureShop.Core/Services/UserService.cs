using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyFurnitureShop.Core.Models.Users;
using MyFurnitureShop.Data;
using MyFurnitureShop.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurnitureShop.Core.Services
{
    public class UserService
    {
        private readonly UserManager<User> userManager;

        private readonly ApplicationDbContext data;


        public UserService(
            ApplicationDbContext _data,
            UserManager<User> _userManager)
        {
            data = _data;
            userManager = _userManager;
        }


        public async Task<IEnumerable<UserModel>> All()
        {
            List<UserModel> result;

            result = await data.Managers
                .Where(a => a.User.IsActive)
                .Select(a => new UserModel()
                {
                    UserId = a.UserId,
                    Email = a.User.Email
                })
                .ToListAsync();

            string[] managerIds = result.Select(a => a.UserId).ToArray();

            result.AddRange(await data.Users
                .Where(u => managerIds.Contains(u.Id) == false)
                .Select(u => new UserModel()
                {
                    UserId = u.Id,
                    Email = u.Email
                }).ToListAsync());

            return result;
        }


    }
}
