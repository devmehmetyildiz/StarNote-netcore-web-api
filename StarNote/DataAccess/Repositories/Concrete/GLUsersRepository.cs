using StarNote.DataAccess.Repositories.Abstract;
using StarNote.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.DataAccess.Repositories.Concrete
{
    public class GLUsersRepository : Repository<GLUsers>, IGLUsersRepository
    {
        public Starnoteapicontext starnoteapicontext { get { return _context as Starnoteapicontext; } }
        public GLUsersRepository(Starnoteapicontext context) : base(context)
        {

        }

        public GLUsers FindUser(string username, string password)
        {
           return starnoteapicontext.GLUser.FirstOrDefault(o => o.Username.ToLower() == username.ToLower() && o.Password == password);
        }
    }
}
