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
            // Полная инициализация данных чтобы
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
            // провераям что Тег ветки является нашей "подорганиз"
            if (e.Node!.Tag is SubOrganization subOrg)
            {
                EmployeePanel.Controls.Clear();
                LoadEmployees(subOrg.Id);
                _subOrganization = subOrg;
            }
            else
            {
                EmployeePanel.Controls.Clear(); //
            }
        }
        private void LoadEmployees(long subOrgId)
        {
            var employees = _context.Employees
                .Where(emp => emp.SubOrganization!.Id == subOrgId)
                .ToList();

            foreach (var employee in employees)
            {
                Button empCard = new Button
                {
                    Text = $"{employee.Name} \n {employee.PhoneNumber}",
                    Width = 200,
                    Height = 100,
                    Tag = employee
                };

                empCard.Click += EmpCard_Click!;
                EmployeePanel.Controls.Add(empCard);
            }
        }
        private void EmpCard_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Employee emp)
            {
                using (var editForm = new EditEmployeeForm(emp, _context))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        EmployeePanel.Controls.Clear();
                        LoadEmployees(emp.SubOrganization!.Id);
                    }
                }
            }
        }

        private void AddEmoployee_Click(object sender, EventArgs e)
        {
            using (var createForm = new CreateEmployee(_subOrganization, _context))
            {
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    EmployeePanel.Controls.Clear();
                    LoadEmployees(_subOrganization.Id);
                }
            }
        }
    }
}