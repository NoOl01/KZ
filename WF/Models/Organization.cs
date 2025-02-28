namespace WF.Models
{
    // Модель организации
    public class Organization
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        // Организация имеет список "подорганизаций"
        public List<SubOrganization>? SubOrganizations { get; set; }
    }
}
