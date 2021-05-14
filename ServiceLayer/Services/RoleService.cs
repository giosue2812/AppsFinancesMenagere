using DAL.Repository.Interfaces;
using ServiceLayer.Mappers;
using ServiceLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class RoleService:IRoleService
    {
        private IRoleRepository _repository;
        public RoleService(IRoleRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Role> GetAll()
        {
            return _repository.GetAll().Select((r) => r.ToServiceLayerRole());
        }
        public Role Get(int Id)
        {
            return _repository.Get(Id).ToServiceLayerRole();
        }
        public int Create(Role body)
        {
            return _repository.Create(body.ToDalRoleInsert());
        }
        public Role Update(Role body)
        {
            return _repository.Update(body.ToDalRoleUpdate()).ToServiceLayerRole();
        }
        public bool Delete(int Id)
        {
            return _repository.Delete(Id);
        }
    }
}
