using FullCart.Application.Repositories.IdentityRepository;
using FullCart.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCart.Application
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UnitOfWork(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IIdentityRepository ComplaintsRepository => new IdentityRepository(_userManager);
    }
}
