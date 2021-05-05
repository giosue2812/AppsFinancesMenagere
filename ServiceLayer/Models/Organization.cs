
namespace ServiceLayer.Models
{
    /// <summary>
    /// Class to describe a Organization
    /// </summary>
    public class Organization
    {
        public int Id { get; set; }
        public string OrName { get; set; }
        public string TypeOrganization { get; set; }
        public bool IsActive { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Email { get; set; }
        public string NameContact { get; set; }
        public int? IdSensibleData { get; set; }
    }
}
