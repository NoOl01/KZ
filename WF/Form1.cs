using Microsoft.EntityFrameworkCore;
using WF.Components;
using WF.Components.EmployeeForm;
using WF.Connect;
using WF.Models;

namespace WF
{
    public partial class MainForm : Form
    {
        // Инициализация глобальных данных (чтобы с ними могли работать абсолютно все функции)
        private readonly DbConnect _context;
        private SubOrganization _subOrganization;
        // Инициализация самой формы (окна)
        public MainForm()
        {
            // Инициализация базовых компонентов по умолчанию
            InitializeComponent();
            // Полная инициализация данных
            _context = new DbConnect();
            _subOrganization = new SubOrganization();
            // Запуск функции сразу при открытии окна
            LoadOrganizations();
            OrgTree.AfterSelect += TreeViewOrganizations_AfterSelect!;
        }

        // Функция для загрузки всех организаций и "подорганизаций" из БД
        private void LoadOrganizations()
        {
            // Загрузка всех данных об организациях в переменную organizations
            var organizations = _context.Organizations
                .Include(o => o.SubOrganizations) // Так же в переменную добавляется информация об их дочерних "подорганизаций"
                .ToList(); // Перевод данных в список

            OrgTree.Nodes.Clear(); // Очищаем дерево чтобы при повторном запуске функции избежать клонирования информации

            // Проходим циклом по нашему списку организаций
            foreach (var org in organizations)
            {
                // Создание новой ветки для дерева
                TreeNode orgNode = new TreeNode(org.Name)
                {
                    Tag = org // Задаем ветке тег который будет хранить информацию о текущей организации
                };
                // проверяем есть в нашей организации дочерние "подорганизации"
                if (org.SubOrganizations != null)
                {
                    // в случае если "подорганизации" есть выполняем еще 1 цикл внутри предыдущего
                    foreach (var subOrg in org.SubOrganizations)
                    {
                        // Создаем еще 1 ветку для дерева
                        TreeNode subOrgNode = new TreeNode(subOrg.Name)
                        {
                            Tag = subOrg // Ставим в качестве тега "подорганизацию"
                        };
                        orgNode.Nodes.Add(subOrgNode); // Добавляем в дерево наши созданные ветки
                    }
                }
                OrgTree.Nodes.Add(orgNode); // Добавляем в дерево наши созданные ветки
            }
        }

        // Функция выбора из ветки "подорганизаций"
        private void TreeViewOrganizations_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // провераям что Тег ветки является "подорганизцией"
            if (e.Node!.Tag is SubOrganization subOrg)
            {
                EmployeePanel.Controls.Clear(); // Очищаем панель сотрудников
                                                // для избежание дублирования или вывод лишних данных при повторном использовании функции
                LoadEmployees(subOrg.Id); // Вызываем функцию LoadEmployees и передаем в нее Id "подорганизации"
                _subOrganization = subOrg; // Записываем в нашу глобальную переменную нашу "подорганизацию"
            }
            else
            {
                // В случае если условие выше не выполняется просто очищаем панель от лишних данных
                EmployeePanel.Controls.Clear();
            }
        }

        // Функция загрузки сотрудников которая принимает Id "Под организации"
        private void LoadEmployees(long subOrgId)
        {
            // создаем переменную employees куда загружаем список наших сотрудников
            var employees = _context.Employees
                .Where(emp => emp.SubOrganization!.Id == subOrgId) // С помощью Where выполняем условие
                                                                   // по которому ищем наших сотрудников
                .ToList(); // Переводим в список

            // Выполняем цикл который перебирает список сотрудников
            foreach (var employee in employees)
            {
                // Создаем нашу кнопку
                Button empCard = new Button
                {
                    Text = $"{employee.Name} \n {employee.PhoneNumber}",
                    Width = 200,
                    Height = 100,
                    Tag = employee
                };

                // При нажатии на кнопку (empCard.Click) вызываем функцию EmpCard_Click
                empCard.Click += EmpCard_Click!;
                EmployeePanel.Controls.Add(empCard);
            }
        }

        // Функция открывающая окно для редактирования информации о сотруднике
        private void EmpCard_Click(object sender, EventArgs e)
        {
            // выполняем проверку что наш объект который вызывает функцию является кнопкой
            // и что тег кнопки является сотрудником
            if (sender is Button button && button.Tag is Employee emp)
            {
                // Запускаем наше вторую форму (окно) и передаем в нее необходимые данные:
                // (сотрудник: emp, и база данных: _context)
                using (var editForm = new EditEmployeeForm(emp, _context))
                {
                    // Делаем проверку на результат выполнения нашего окна
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        //В случае если наше новое окно возвращает результат "OK" то обнавляем панель
                        EmployeePanel.Controls.Clear();
                        LoadEmployees(emp.SubOrganization!.Id);
                    }
                }
            }
        }

        // Функция для добавления нового сотрудника
        private void AddEmoployee_Click(object sender, EventArgs e)
        {
            // Открывает новое окно CreateEmployee и передаем туда данные из глобальных переменных
            // (_subOrganization, _context)
            using (var createForm = new CreateEmployee(_subOrganization, _context))
            {
                // Делаем проверку на результат выполнения нашего окна
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    //В случае если наше новое окно возвращает результат "OK" то обнавляем панель
                    EmployeePanel.Controls.Clear();
                    LoadEmployees(_subOrganization.Id);
                }
            }
        }
    }
}