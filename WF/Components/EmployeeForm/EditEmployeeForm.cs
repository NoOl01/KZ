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

namespace WF.Components.EmployeeForm
{
    public partial class EditEmployeeForm : Form
    {
        // Инициализация глобальных переменных
        private readonly Employee _employee;
        private readonly DbConnect _context;
        private List<Absence> _absences;
        // // Инициализация глобальных переменных (флаги)
        private bool _absencePrev = false;
        private bool _absenceCurrent = true;
        private bool _absenceNext = true;
        private bool _absenceSort = true;
        // Инициализация самой формы (окна)
        public EditEmployeeForm(Employee employee, DbConnect context)
        {
            // Инициализация базовых компонентов по умолчанию
            InitializeComponent();
            // Заполняем наши глобальные переменные получаемыми данными
            _employee = employee;
            _context = context;
            // Полная инициализация листа
            _absences = new List<Absence>();
            // Запуск нужных функций сразу при открытии окна
            LoadEmployeeData();
            CheckAbsences();
        }

        // Функция заполняющая поля данными о сотрудниках
        private void LoadEmployeeData()
        {
            FioInput.Text = _employee.Name;
            PhoneInput.Text = _employee.PhoneNumber;
        }

        // Функция проверяющая наши пропуски
        private void CheckAbsences()
        {
            _absences.Clear(); // Очищаем наш список на случай повторного вызова функции

            // Устанавливаем цвета по умолчанию на случай повторного вызова функции
            AbsPrev.BackColor = Color.White;
            AbsCurrent.BackColor = Color.White;
            AbsNext.BackColor = Color.White;

            // Делаем проверку что флаг _absencePrev активен (равен true)
            if (_absencePrev)
            {
                // Добавляем в список пропусков данные из БД
                _absences.AddRange(_context.Absences
                    .Where(e => e.Employee!.Id == _employee.Id) // Условие на поиска по сотруднику
                    .Where(a => a.Date < DateTime.Today)); // Условие на поиск по дате
                AbsPrev.BackColor = Color.Green; // Устанавливаем кнопке зеленый цвет так как кнопка активна
            }
            // Делаем проверку что флаг _absenceCurrent активен (равен true)
            if (_absenceCurrent)
            {
                // Добавляем в список пропусков данные из БД
                _absences.AddRange(_context.Absences
                    .Where(e => e.Employee!.Id == _employee.Id) // Условие на поиска по сотруднику
                    .Where(a => a.Date == DateTime.Today)); // Условие на поиск по дате
                AbsCurrent.BackColor = Color.Green; // Устанавливаем кнопке зеленый цвет так как кнопка активна
            }
            // Делаем проверку что флаг _absenceNext активен (равен true)
            if (_absenceNext)
            {
                // Добавляем в список пропусков данные из БД
                _absences.AddRange(_context.Absences
                    .Where(e => e.Employee!.Id == _employee.Id) // Условие на поиска по сотруднику
                    .Where(a => a.Date > DateTime.Today)); // Условие на поиск по дате
                AbsNext.BackColor = Color.Green; // Устанавливаем кнопке зеленый цвет так как кнопка активна
            }
            // Вызываем функцию на загрузку данных о пропусках в интерфейсе
            LoadAbsences();
        }

        //Функция на загрузку данных о пропусках в интерфейсе
        private void LoadAbsences()
        {
            AbsencesPanel.Controls.Clear(); // Очищаем панель на случай повторного запуска функции
            int y = 10; // Создаем переменную которая хранит Y координату

            List<string> types = new List<string>(); // Создаем новый список с типами пропусков

            // Проходимся циклом по списку типов пропусков
            foreach (var absence in _absences)
            {
                // Выполняем проверку на то если в нашем списке типов список из листа пропусков
                if (!types.Contains(absence.Type!))
                {
                    types.Add(absence.Type!); // Если текущего пропуска нету в списке добавляем его
                }
            }
            
            // Проходимся по списку типов
            foreach (string type in types)
            {
                // Создаем новый label
                Label label = new Label
                {
                    Text = type,
                    Location = new Point(10, y),
                    AutoSize = true
                };
                AbsencesPanel.Controls.Add(label); // Добавляем label в панель
                y += 15; // Увеличиваем Y координату чтобы элементы не накладывались друг на друга

                // Внутри прошлого цикла делаем еще 1 который перебирает список наших пропусков
                foreach (var absence in _absences)
                {
                    // проверяем что наш пропуск сходится с типом пропуска из другого списка
                    if (absence.Type == type)
                    {
                        // Создаем textBox
                        TextBox textBox = new TextBox
                        {
                            Text = absence.Date.ToString("dd-MM-yyyy"), // В текст записываем дату пропуска
                                                                        // форматировав его в строку через .ToString()
                            Location = new Point(10, y),
                            Width = 150,
                        };
                        AbsencesPanel.Controls.Add(textBox); // Добавляем textBox в панель
                        y += 20; // Увеличиваем Y координату чтобы элементы не накладывались друг на друга
                    }
                }
                y += 10; // Увеличиваем Y координату чтобы элементы не накладывались друг на друга
            }
        }

        // Функция сохраняющая изменения о сотруднике
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Записываем данные из TextBox в нашу глобальную переменную
            _employee.Name = FioInput.Text;
            _employee.PhoneNumber = PhoneInput.Text;

            _context.Employees.Update(_employee); // Обновляем данные в БД
            _context.SaveChanges(); // Сохраняем данные в БД

            DialogResult = DialogResult.OK; // Возвращаем результат OK для обновления данных в основном окне
        }

        // Функция фильтрации по прошедшим пропускам
        private void AbsPrev_Click(object sender, EventArgs e)
        {
            _absencePrev = !_absencePrev; // Переключаем флаг на противоположное значение
            CheckAbsences(); // Вызываем функцию CheckAbsences
        }

        // Функция фильтрации по текущим пропускам
        private void AbsCurrent_Click(object sender, EventArgs e)
        {
            _absenceCurrent = !_absenceCurrent; // Переключаем флаг на противоположное значение
            CheckAbsences(); // Вызываем функцию CheckAbsences
        }

        // Функция фильтрации по будущим пропускам
        private void AbsNext_Click(object sender, EventArgs e)
        {
            _absenceNext = !_absenceNext; // Переключаем флаг на противоположное значение
            CheckAbsences(); // Вызываем функцию CheckAbsences
        }

        // Функция сортировки даты
        private void AbsSort_Click(object sender, EventArgs e)
        {
            _absenceSort = !_absenceSort; // Переключаем флаг на противоположное значение
            if (_absenceSort)
            {
                _absences = _absences.OrderBy(a => a.Date).ToList(); // перезаписываем данные в списке
                                                                     // отсортировав дату по возрастанию
                LoadAbsences(); // Вызываем функцию LoadAbsences
            }
            else
            {
                _absences = _absences.OrderByDescending(a => a.Date).ToList(); // перезаписываем данные в списке
                                                                               // отсортировав дату по убыванию
                LoadAbsences(); // Вызываем функцию LoadAbsences
            }
        }

        // Функция удаляющая текущего сотрудника
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _context.Remove(_employee); // Удаляем данные из БД
            _context.SaveChanges(); // Сохраняем изменения в БД
            DialogResult = DialogResult.OK; // Вовращаем результат окна OK
            Close(); // Закрываем окно
        }
    }
}
