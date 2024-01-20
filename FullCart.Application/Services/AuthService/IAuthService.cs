using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCart.Application.Services.AuthService
{
    public interface IAuthService
    {
        Task<string?> GenerateToken(string username, string password);
    }
}
