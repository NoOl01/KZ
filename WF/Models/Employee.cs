namespace WF.Models
{
    // Модель сотрудников
    public class Employee
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        // Подключение к "подорганизациям"
        public SubOrganization? SubOrganization { get; set; }
        // Сотрудник имеет свой список пропусков
        public List<Absence>? Absences { get; set; }
    }
}
