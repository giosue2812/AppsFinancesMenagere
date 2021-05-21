using A = AppsFinancesMenagere.Models;
using S = ServiceLayer.Models;

namespace AppsFinancesMenagere.Mappers
{
    public static class MapperUser
    {
        /// <summary>
        /// Convert ServiceLayer VUser To Dal VUser
        /// </summary>
        /// <param name="user">ServiceLayer User</param>
        /// <returns>Api VUser</returns>
        public static A.VUser ToApiUser(this S.Views.VUser user)
        {
            if (user == null) return null;
            return new A.VUser
            {
                BirthDate = user.BirthDate,
                Email = user.Email,
                FirstName = user.FirstName,
                Id = user.Id,
                IdRole = user.IdRole,
                IdSensibleData = user.IdSensibleData,
                IsActive = user.IsActive,
                LastName = user.LastName,
                Tel = user.Tel
            };
        }
        /// <summary>
        /// Convert a Api UserForm to ServiceLayer UserForm
        /// </summary>
        /// <param name="form">Api UserForm</param>
        /// <returns>ServiceLayer UserForm</returns>
        public static S.Form.User.UserForm ToServiceLayerUserForm(this A.Form.User.UserFormInsert form)
        {
            if (form == null) return null;
            return new S.Form.User.UserForm
            {
                BirthDate = form.BirthDate,
                Email = form.Email,
                FirstName = form.FirstName,
                IdSensibleData = form.IdSensibleData,
                LastName = form.LastName,
                Tel = form.Tel,
                UPassword = form.UPassword
            };
        }
        /// <summary>
        /// Convert Api UserForm to ServiceLayer UserForm
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public static S.Form.User.UserForm ToServiceLayerUserFormUpdate(this A.Form.User.UserForm form)
        {
            if (form == null) return null;
            return new S.Form.User.UserForm
            {
                Id = form.Id,
                BirthDate = form.BirthDate,
                Email = form.Email,
                FirstName = form.FirstName,
                IdSensibleData = form.IdSensibleData,
                LastName = form.LastName,
                Tel = form.Tel
            };
        }
        /// <summary>
        /// Convert Api LoginForm to ServiceLayer LoginForm
        /// </summary>
        /// <param name="form">Api LoginForm</param>
        /// <returns>ServiceLayer LoginForm</returns>
        public static S.Form.User.LoginForm ToServiceLayerLogin(this A.Form.User.LoginForm form)
        {
            if (form == null) return null;
            return new S.Form.User.LoginForm
            {
                Email = form.Email,
                Password = form.Password
            };
        }
        /// <summary>
        /// Convert Api ResetPassword to ServiceLayer ResetPassword
        /// </summary>
        /// <param name="form">Api ResetPassword</param>
        /// <returns>ServiceLayer ResetPassword</returns>
        public static S.Form.User.ResetPassword ToServiceLayerResetPassword(this A.Form.User.ResetPassword form)
        {
            if (form == null) return null;
            return new S.Form.User.ResetPassword
            {
                Email = form.Email,
                Id = form.Id,
                Password = form.Password
            };
        }
    }
}
