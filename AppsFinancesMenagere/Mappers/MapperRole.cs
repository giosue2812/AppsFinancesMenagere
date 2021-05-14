using A = AppsFinancesMenagere.Models;
using S = ServiceLayer.Models;

namespace AppsFinancesMenagere.Mappers
{
    public static class MapperRole
    {
        /// <summary>
        /// Convert a Api Role to Service Layer Role
        /// </summary>
        /// <param name="role">Service Layer Role</param>
        /// <returns>Api Role</returns>
        public static A.Role ToApiRole(this S.Role role)
        {
            if (role == null) return null;
            return new A.Role
            {
                Id = role.Id,
                RLabel = role.RLabel
            };
        }
        /// <summary>
        /// Convert to Api Form Role to Service layer Role
        /// </summary>
        /// <param name="form">Api Form Role</param>
        /// <returns>ServiceLayer Role</returns>
        public static S.Role ToServiceLayerRoleInsert(this A.Form.Role.RoleForm form)
        {
            if (form == null) return null;
            return new S.Role
            {
                RLabel = form.RLabel
            };
        }
        /// <summary>
        /// Convert to Api Role to Service layer Role 
        /// </summary>
        /// <param name="form">Api Role</param>
        /// <returns>ServiceLayer Role</returns>
        public static S.Role ToServiceLayerRoleUpdate(this A.Role form)
        {
            if (form == null) return null;
            return new S.Role
            {
                Id = form.Id,
                RLabel = form.RLabel
            };
        }
    }
}
