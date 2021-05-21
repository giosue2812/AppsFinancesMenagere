using S = ServiceLayer.Models;
using D = DAL.Models;

namespace ServiceLayer.Mappers
{
    public static class MapperUser
    {
        /// <summary>
        /// Convert a Dal User to ServiceLayer User
        /// </summary>
        /// <param name="user">Dal User</param>
        /// <returns>ServiceLayer User</returns>
        public static S.Views.VUser ToServiceLayerUser(this D.Views.VUser user)
        {
            if (user == null) return null;
            return new S.Views.VUser
            {
                Id = user.Id,
                BirthDate = user.BirthDate,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                IdRole = user.IdRole,
                IdSensibleData = user.IdSensibleData,
                IsActive = user.IsActive,
                Tel = user.Tel
            };
        }
        /// <summary>
        /// Convert to ServiceLayer UserForm to Dal UserForm
        /// </summary>
        /// <param name="form">ServiceLayer UserForm</param>
        /// <returns>Dal UserForm</returns>
        public static D.Form.UserForm ToDalUserForm(this S.Form.User.UserForm form)
        {
            if (form == null) return null;
            return new D.Form.UserForm
            {
                BirthDate = form.BirthDate,
                Email = form.Email,
                FirstName = form.FirstName,
                LastName = form.LastName,
                IdSensibleData = form.IdSensibleData,
                Tel = form.Tel,
                UPassword = form.UPassword
            };
        }
        /// <summary>
        /// Convert ServiceLayer UserForm to Dal UserForm
        /// </summary>
        /// <param name="form">ServiceLayer UserForm</param>
        /// <returns>Dal UserForm</returns>
        public static D.Form.UserForm ToDalUserFormUpdate(this S.Form.User.UserForm form)
        {
            if (form == null) return null;
            return new D.Form.UserForm
            {
                Id = form.Id,
                BirthDate = form.BirthDate,
                Email = form.Email,
                FirstName = form.FirstName,
                LastName = form.LastName,
                IdSensibleData = form.IdSensibleData,
                Tel = form.Tel,
                UPassword = form.UPassword
            };
        }
        /// <summary>
        /// Convert ServiceLayer LoginForm to Dal LoginForm
        /// </summary>
        /// <param name="form">ServiceLayer LoginForm</param>
        /// <returns>Dal LoginForm</returns>
        public static D.Form.LoginForm ToDalLogin(this S.Form.User.LoginForm form)
        {
            if (form == null) return null;
            return new D.Form.LoginForm
            {
                Email = form.Email,
                Password = form.Password
            };
        }
        /// <summary>
        /// Convert ServiceLayer ResetPassword to Dal ResetPassword
        /// </summary>
        /// <param name="form">ServiceLayer ResetPassword</param>
        /// <returns>Dal ResetPassword</returns>
        public static D.Form.ResetPassword ToDalResetPassword(this S.Form.User.ResetPassword form)
        {
            if (form == null) return null;
            return new D.Form.ResetPassword
            {
                Id = form.Id,
                Email = form.Email,
                Password = form.Password
            };
        }
    }
}
