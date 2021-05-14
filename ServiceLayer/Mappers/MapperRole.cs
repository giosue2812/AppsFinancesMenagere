using D = DAL.Models;
using S = ServiceLayer.Models;

namespace ServiceLayer.Mappers
{
    public static class MapperRole
    {
        /// <summary>
        /// Converto a Dal Role to ServiceLayer Role
        /// </summary>
        /// <param name="role">Dal Role</param>
        /// <returns>Service Layer Role</returns>
        public static S.Role ToServiceLayerRole(this D.Role role)
        {
            if (role == null) return null;
            return new S.Role
            {
                Id = role.Id,
                RLabel = role.RLabel
            };
        }
        /// <summary>
        /// Convert a ServiceLayer Role to Dal Role for insert function
        /// </summary>
        /// <param name="role">ServiceLayer Role</param>
        /// <returns>Dal Role</returns>
        public static D.Role ToDalRoleInsert(this S.Role role)
        {
            if (role == null) return null;
            return new D.Role
            {
                RLabel = role.RLabel
            };
        }
        /// <summary>
        /// Convert a ServiceLayer Role to Dal Role for update
        /// </summary>
        /// <param name="role">ServiceLayer Role</param>
        /// <returns>Dal Role</returns>
        public static D.Role ToDalRoleUpdate(this S.Role role)
        {
            if (role == null) return null;
            return new D.Role
            {
                Id = role.Id,
                RLabel = role.RLabel
            };
        }
    }
}
