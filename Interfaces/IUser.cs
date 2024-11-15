using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assesment.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string Email { get; set; }
    }
}