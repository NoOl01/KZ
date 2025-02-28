namespace WF.Models
{
    // Модель "Подорганизаций"
    public class SubOrganization
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        // Подключение к организации
        public Organization? Organization { get; set; }
        // "подорганизация" имеет свой список сотрудников
        public List<Employee>? Employees { get; set; }
    }
}
