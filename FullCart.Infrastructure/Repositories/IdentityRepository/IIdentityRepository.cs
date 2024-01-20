using FullCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCart.Application.Repositories.IdentityRepository
{
    public interface IIdentityRepository
    {
        Task<bool> CheckPasswordAsync(ApplicationUser user, string password);
        Task<bool> UserExistsAsync(string userId);
        Task<bool> EmailExistsAsync(string email);
    }
}
