using Microsoft.EntityFrameworkCore;
using WF.Components;
using WF.Components.EmployeeForm;
using WF.Connect;
using WF.Models;

namespace WF
{
    public partial class MainForm : Form
    {
        // ������������� ���������� ������ (����� � ���� ����� �������� ��������� ��� �������)
        private readonly DbConnect _context;
        private SubOrganization _subOrganization;
        // ������������� ����� ����� (����)
        public MainForm()
        {
            // ������������� ������� ����������� �� ���������
            InitializeComponent();
            // ������ ������������� ������
            _context = new DbConnect();
            _subOrganization = new SubOrganization();
            // ������ ������� ����� ��� �������� ����
            LoadOrganizations();
            OrgTree.AfterSelect += TreeViewOrganizations_AfterSelect!;
        }

        // ������� ��� �������� ���� ����������� � "��������������" �� ��
        private void LoadOrganizations()
        {
            // �������� ���� ������ �� ������������ � ���������� organizations
            var organizations = _context.Organizations
                .Include(o => o.SubOrganizations) // ��� �� � ���������� ����������� ���������� �� �� �������� "��������������"
                .ToList(); // ������� ������ � ������

            OrgTree.Nodes.Clear(); // ������� ������ ����� ��� ��������� ������� ������� �������� ������������ ����������

            // �������� ������ �� ������ ������ �����������
            foreach (var org in organizations)
            {
                // �������� ����� ����� ��� ������
                TreeNode orgNode = new TreeNode(org.Name)
                {
                    Tag = org // ������ ����� ��� ������� ����� ������� ���������� � ������� �����������
                };
                // ��������� ���� � ����� ����������� �������� "��������������"
                if (org.SubOrganizations != null)
                {
                    // � ������ ���� "��������������" ���� ��������� ��� 1 ���� ������ �����������
                    foreach (var subOrg in org.SubOrganizations)
                    {
                        // ������� ��� 1 ����� ��� ������
                        TreeNode subOrgNode = new TreeNode(subOrg.Name)
                        {
                            Tag = subOrg // ������ � �������� ���� "��������������"
                        };
                        orgNode.Nodes.Add(subOrgNode); // ��������� � ������ ���� ��������� �����
                    }
                }
                OrgTree.Nodes.Add(orgNode); // ��������� � ������ ���� ��������� �����
            }
        }

        // ������� ������ �� ����� "��������������"
        private void TreeViewOrganizations_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // ��������� ��� ��� ����� �������� "��������������"
            if (e.Node!.Tag is SubOrganization subOrg)
            {
                EmployeePanel.Controls.Clear(); // ������� ������ �����������
                                                // ��� ��������� ������������ ��� ����� ������ ������ ��� ��������� ������������� �������
                LoadEmployees(subOrg.Id); // �������� ������� LoadEmployees � �������� � ��� Id "��������������"
                _subOrganization = subOrg; // ���������� � ���� ���������� ���������� ���� "��������������"
            }
            else
            {
                // � ������ ���� ������� ���� �� ����������� ������ ������� ������ �� ������ ������
                EmployeePanel.Controls.Clear();
            }
        }

        // ������� �������� ����������� ������� ��������� Id "��� �����������"
        private void LoadEmployees(long subOrgId)
        {
            // ������� ���������� employees ���� ��������� ������ ����� �����������
            var employees = _context.Employees
                .Where(emp => emp.SubOrganization!.Id == subOrgId) // � ������� Where ��������� �������
                                                                   // �� �������� ���� ����� �����������
                .ToList(); // ��������� � ������

            // ��������� ���� ������� ���������� ������ �����������
            foreach (var employee in employees)
            {
                // ������� ���� ������
                Button empCard = new Button
                {
                    Text = $"{employee.Name} \n {employee.PhoneNumber}",
                    Width = 200,
                    Height = 100,
                    Tag = employee
                };

                // ��� ������� �� ������ (empCard.Click) �������� ������� EmpCard_Click
                empCard.Click += EmpCard_Click!;
                EmployeePanel.Controls.Add(empCard);
            }
        }

        // ������� ����������� ���� ��� �������������� ���������� � ����������
        private void EmpCard_Click(object sender, EventArgs e)
        {
            // ��������� �������� ��� ��� ������ ������� �������� ������� �������� �������
            // � ��� ��� ������ �������� �����������
            if (sender is Button button && button.Tag is Employee emp)
            {
                // ��������� ���� ������ ����� (����) � �������� � ��� ����������� ������:
                // (���������: emp, � ���� ������: _context)
                using (var editForm = new EditEmployeeForm(emp, _context))
                {
                    // ������ �������� �� ��������� ���������� ������ ����
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        //� ������ ���� ���� ����� ���� ���������� ��������� "OK" �� ��������� ������
                        EmployeePanel.Controls.Clear();
                        LoadEmployees(emp.SubOrganization!.Id);
                    }
                }
            }
        }

        // ������� ��� ���������� ������ ����������
        private void AddEmoployee_Click(object sender, EventArgs e)
        {
            // ��������� ����� ���� CreateEmployee � �������� ���� ������ �� ���������� ����������
            // (_subOrganization, _context)
            using (var createForm = new CreateEmployee(_subOrganization, _context))
            {
                // ������ �������� �� ��������� ���������� ������ ����
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    //� ������ ���� ���� ����� ���� ���������� ��������� "OK" �� ��������� ������
                    EmployeePanel.Controls.Clear();
                    LoadEmployees(_subOrganization.Id);
                }
            }
        }
    }
}