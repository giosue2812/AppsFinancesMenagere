using System.ComponentModel.DataAnnotations;

namespace ServiceLayer.Models.Form.Organizations
{
    /// <summary>
    /// Function to describe a Organization form
    /// </summary>
    public class OrganizationForm
    {
        [MaxLength(50)]
        public string OrName { get;set; }
        [MaxLength(50)]
        public string Organization { get; set; }
        [MaxLength(50)]
        public string Tel1 { get; set; }
        [MaxLength(50)]
        public string Tel2 { get; set; }
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string NameContact { get; set; }
    }
}
