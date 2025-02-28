using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF.Connect;
using WF.Models;

namespace WF.Components
{
    public partial class CreateEmployee : Form
    {
        // Ининициализируем глобальные переменные
        private readonly DbConnect _context;
        private readonly SubOrganization _subOrganization;

        // Инициализация формы (окна), форма получает данные о "подорганизациях" и о базе данныз
        public CreateEmployee(SubOrganization subOrganization, DbConnect context)
        {
            // Инициализация базовых компонентов по умолчанию
            InitializeComponent();
            // Заполняем наши глобальные переменные получаемыми данными
            _context = context;
            _subOrganization = subOrganization;
        }

        // Функция добавляющая нового сотрудника
        private void NewSaveButton_Click(object sender, EventArgs e)
        {
            // Проверяем что наши поля не пустые
            if (NewPhoneInput.Text != "" && NewFioInput.Text != "")
            {
                // Инициализируем новую форму Employee и записываем внутрь нужные данные
                Employee emp = new Employee
                {
                    Name = NewFioInput.Text,
                    PhoneNumber = NewPhoneInput.Text,
                    SubOrganization = _subOrganization
                };
                _context.Add(emp); // Добавляем в БД нового сотрудника
                _context.SaveChanges(); // Сохраняем изменения в БД
                DialogResult = DialogResult.OK; // Возвращаем статус окна OK
                Close(); // Закрываем окно
            }
        }
    }
}
