using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF.Models
{ 
    // Модель пропусков
    public class Absence
    {
        public long Id { get; set; }
        public string? Type { get; set; }
        // DateTime используется для хранения даты и времени в БД
        public DateTime Date { get; set; }
        // Подключеник к сотрудникам
        public Employee? Employee { get; set; }
    }
}
