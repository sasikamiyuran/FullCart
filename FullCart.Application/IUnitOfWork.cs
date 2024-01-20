using FullCart.Application.Repositories.IdentityRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCart.Application
{
    public interface IUnitOfWork
    {
        IIdentityRepository ComplaintsRepository { get; }
    }
}
