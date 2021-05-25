namespace ServiceLayer.Models.Form.Organizations
{
    /// <summary>
    /// Class to describe ORganization Update
    /// </summary>
    public class OrganizationUpdate
    {
        public int Id { get; set;}
        public string OrName { get; set; }
        public string Organization { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Email { get; set; }
        public string NameContact { get; set; }
        public int? IdSensibleData { get; set; }
    }
}
