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
        private readonly Employee _employee;
        private readonly DbConnect _context;
        private List<Absence> _absences;
        private bool _absencePrev = false;
        private bool _absenceCurrent = true;
        private bool _absenceNext = true;
        private bool _absenceSort = true;

        public EditEmployeeForm(Employee employee, DbConnect context)
        {
            InitializeComponent();
            _employee = employee;
            _context = context;
            _absences = new List<Absence>();
            LoadEmployeeData();
            CheckAbsences();
        }
        private void LoadEmployeeData()
        {
            FioInput.Text = _employee.Name;
            PhoneInput.Text = _employee.PhoneNumber;
        }

        private void CheckAbsences()
        {
            _absences.Clear();
            AbsPrev.BackColor = Color.White;
            AbsCurrent.BackColor = Color.White;
            AbsNext.BackColor = Color.White;
            if (_absencePrev)
            {
                _absences.AddRange(_context.Absences
                    .Where(e => e.Employee!.Id == _employee.Id)
                    .Where(a => a.Date < DateTime.Today));
                AbsPrev.BackColor = Color.Green;
            }
            if (_absenceCurrent)
            {
                _absences.AddRange(_context.Absences
                    .Where(e => e.Employee!.Id == _employee.Id)
                    .Where(a => a.Date == DateTime.Today));
                AbsCurrent.BackColor = Color.Green;
            }
            if (_absenceNext)
            {
                _absences.AddRange(_context.Absences
                    .Where(e => e.Employee!.Id == _employee.Id)
                    .Where(a => a.Date > DateTime.Today));
                AbsNext.BackColor = Color.Green;
            }
            LoadAbsences();
        }

        private void LoadAbsences()
        {
            AbsencesPanel.Controls.Clear();
            int y = 10;

            List<string> types = new List<string>();

            foreach (var absence in _absences)
            {
                if (!types.Contains(absence.Type!))
                {
                    types.Add(absence.Type!);
                }
            }
            foreach (string type in types)
            {
                Label label = new Label
                {
                    Text = type,
                    Location = new Point(10, y),
                    AutoSize = true
                };
                AbsencesPanel.Controls.Add(label);
                y += 15;

                foreach (var absence in _absences)
                {
                    if (absence.Type == type)
                    {
                        TextBox textBox = new TextBox
                        {
                            Text = absence.Date.ToString("dd-MM-yyyy"),
                            Location = new Point(10, y),
                            Width = 150,
                        };
                        AbsencesPanel.Controls.Add(textBox);
                        y += 20;
                    }
                }
                y += 10;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _employee.Name = FioInput.Text;
            _employee.PhoneNumber = PhoneInput.Text;

            _context.Employees.Update(_employee);
            _context.SaveChanges();

            DialogResult = DialogResult.OK;
        }

        private void AbsPrev_Click(object sender, EventArgs e)
        {
            _absencePrev = !_absencePrev;
            CheckAbsences();
        }

        private void AbsCurrent_Click(object sender, EventArgs e)
        {
            _absenceCurrent = !_absenceCurrent;
            CheckAbsences();
        }

        private void AbsNext_Click(object sender, EventArgs e)
        {
            _absenceNext = !_absenceNext;
            CheckAbsences();
        }

        private void AbsSort_Click(object sender, EventArgs e)
        {
            _absenceSort = !_absenceSort;
            if (_absenceSort)
            {
                _absences = _absences.OrderBy(a => a.Date).ToList();
                LoadAbsences();
            }
            else
            {
                _absences = _absences.OrderByDescending(a => a.Date).ToList();
                LoadAbsences();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _context.Remove(_employee);
            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void PhoneInput_TextChanged(object sender, EventArgs e)
        {
            string validChars = "0123456789+() -#";
            string newText = "";

            foreach (char c in PhoneInput.Text)
            {
                if (validChars.Contains(c) && newText.Length < 20)
                {
                    newText += c;
                }
            }

            if (PhoneInput.Text != newText)
            {
                int cursorPosition = PhoneInput.SelectionStart - (PhoneInput.Text.Length - newText.Length);
                PhoneInput.Text = newText;
                PhoneInput.SelectionStart = Math.Max(0, cursorPosition);
            }
        }
    }
}
