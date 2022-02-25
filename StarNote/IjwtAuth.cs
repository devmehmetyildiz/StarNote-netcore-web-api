using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote
{
    public interface IjwtAuth
    {
        string Authentication(string username, string password);
    }
}
