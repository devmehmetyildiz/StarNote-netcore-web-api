using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarNote.DataAccess;
using StarNote.Models.DBModels;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace StarNote.Controllers
{
    [Authorize]
    [Route("api/")]
    [ApiController]
    public class GlobalController : ControllerBase
    {
        private readonly ILogger<AdisyonmenusController> _logger;
        private readonly Starnoteapicontext _context;
        UnitOfWork unitOfWork;
        public GlobalController(ILogger<AdisyonmenusController> logger, Starnoteapicontext context)
        {
            _logger = logger;
            _context = context;
            unitOfWork = new UnitOfWork(context);
        }

        #region Users
        [Route("GLUser/GetAll")]
        [HttpGet]
        public IEnumerable<GLUsers> GetAllUser()
        {
            IEnumerable<GLUsers> response = new List<GLUsers>();
            response = unitOfWork.GLUsersRepository.GetAll();
            return response;
        }

        [Route("GLUser/Add")]
        [HttpPost]
        public bool AddUser(GLUsers obj)
        {
            bool IsAdded = false;
            Guid newguid = Guid.NewGuid();
            obj.Guid = newguid.ToString();
            obj.Isactive = true;
            obj.Createdtime = DateTime.Now;
            unitOfWork.GLUsersRepository.Add(obj);
            if (unitOfWork.Complate() > 0)
                IsAdded = true;
            return IsAdded;
        }
        [Route("GLUser/Update")]
        [HttpPost]
        public bool UpdateUser(GLUsers obj)
        {
            bool Isupdated = false;
            obj.Modifiedtime = DateTime.Now;
            unitOfWork.GLUsersRepository.update(unitOfWork.GLUsersRepository.Getbyid(obj.Id), obj);
            if (unitOfWork.Complate() > 0)
            {
                Isupdated = true;
            }
            return Isupdated;
        }
        [Route("GLUser/Delete")]
        [HttpPost]
        public bool DeleteUser(GLUsers obj)
        {
            bool Isupdated = false;
            obj.Deletetime = DateTime.Now;
            obj.Isactive = false;
            unitOfWork.GLUsersRepository.update(unitOfWork.GLUsersRepository.Getbyid(obj.Id), obj);
            return Isupdated;
        }
        [Route("GLUser/Pwchange")]
        [HttpPost]
        public bool PwchangeUser(GLUsers objuser)
        {
            bool IsAdded = false;
            GLUsers olditem = unitOfWork.GLUsersRepository.Getbyid(objuser.Id);
            olditem.Password = objuser.Password;
            if (unitOfWork.Complate() > 0)
            {
                IsAdded = true;
            }
            return IsAdded;
        }

        [Route("GLUser/GetRoles")]
        [HttpGet]
        public IEnumerable<GLRoles> GetRoleSource()
        {
            IEnumerable<GLRoles> response = new List<GLRoles>();
            response = unitOfWork.GLRolesRepository.GetAll();
            return response;
        }

        #endregion

        #region Tax
        [Route("GLTax/GetAll")]
        [HttpGet]
        public IEnumerable<GLTax> GetAllTax()
        {
            IEnumerable<GLTax> response = new List<GLTax>();
            response = unitOfWork.GLTaxRepository.GetAll();
            return response;
        }
        [Route("GLTax/Add")]
        [HttpPost]
        public bool AddTax(GLTax obj)
        {
            bool IsAdded = false;
            Guid newguid = Guid.NewGuid();
            obj.Guid = newguid.ToString();
            obj.Isactive = true;
            obj.Createdtime = DateTime.Now;
            unitOfWork.GLTaxRepository.Add(obj);
            if (unitOfWork.Complate() > 0)
                IsAdded = true;
            return IsAdded;
        }
        [Route("GLTax/Update")]
        [HttpPost]
        public bool UpdateTax(GLTax obj)
        {
            bool Isupdated = false;
            obj.Modifiedtime = DateTime.Now;
            unitOfWork.GLTaxRepository.update(unitOfWork.GLTaxRepository.Getbyid(obj.Id), obj);
            if (unitOfWork.Complate() > 0)
            {
                Isupdated = true;
            }
            return Isupdated;
        }
        [Route("GLTax/Delete")]
        [HttpPost]
        public bool DeleteTax(GLTax obj)
        {
            bool Isupdated = false;
            obj.Deletetime = DateTime.Now;
            obj.Isactive = false;
            unitOfWork.GLTaxRepository.update(unitOfWork.GLTaxRepository.Getbyid(obj.Id), obj);
            return Isupdated;
        }
        #endregion

        #region Roles

        [Route("GLRoles/GetAll")]
        [HttpGet]
        public IEnumerable<GLRoles> GetAllRoles()
        {
            IEnumerable<GLRoles> response = new List<GLRoles>();
            response = unitOfWork.GLRolesRepository.GetAll();
            return response;
        }

        [Route("GLRoles/Add")]
        [HttpPost]
        public bool AddRoles(GLRoles obj)
        {
            bool IsAdded = false;
            Guid newguid = Guid.NewGuid();
            obj.Guid = newguid.ToString();
            obj.Isactive = true;
            obj.Createdtime = DateTime.Now;
            unitOfWork.GLRolesRepository.Add(obj);
            if (unitOfWork.Complate() > 0)
                IsAdded = true;
            return IsAdded;
        }
        [Route("GLRoles/Update")]
        [HttpPost]
        public bool UpdateRoles(GLRoles obj)
        {
            bool Isupdated = false;
            obj.Modifiedtime = DateTime.Now;
            unitOfWork.GLRolesRepository.update(unitOfWork.GLRolesRepository.Getbyid(obj.Id), obj);
            if (unitOfWork.Complate() > 0)
            {
                Isupdated = true;
            }
            return Isupdated;
        }
        [Route("GLRoles/Delete")]
        [HttpPost]
        public bool DeleteRoles(GLRoles obj)
        {
            bool Isupdated = false;
            obj.Deletetime = DateTime.Now;
            obj.Isactive = false;
            unitOfWork.GLRolesRepository.update(unitOfWork.GLRolesRepository.Getbyid(obj.Id), obj);
            return Isupdated;
        }
        #endregion
    }
}
