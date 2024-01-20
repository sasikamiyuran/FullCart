using FullCart.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCart.Application.Repositories.IdentityRepository
{
    public class IdentityRepository : IIdentityRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public IdentityRepository(UserManager<ApplicationUser> userManager) 
        { 
            _userManager = userManager;
        }
        //public async Task<bool> CheckPasswordAsync(string user, string password)
        //{
        //    //var appUser = _userManager.Users.Select(x => x.UserName == user).FirstOrDefault();
        //    //return await _userManager.CheckPasswordAsync(appUser, password);
        //}

        public Task<bool> CheckPasswordAsync(ApplicationUser user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EmailExistsAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExistsAsync(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
