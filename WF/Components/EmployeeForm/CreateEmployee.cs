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
        private readonly DbConnect _context;
        private readonly SubOrganization _subOrganization;
        public CreateEmployee(SubOrganization subOrganization, DbConnect context)
        {
            InitializeComponent();
            _context = context;
            _subOrganization = subOrganization;
        }

        private void NewPhoneInput_TextChanged(object sender, EventArgs e)
        {
            string validChars = "0123456789+() -#";
            string newText = "";

            foreach (char c in NewPhoneInput.Text)
            {
                if (validChars.Contains(c) && newText.Length < 20)
                {
                    newText += c;
                }
            }

            if (NewPhoneInput.Text != newText)
            {
                int cursorPosition = NewPhoneInput.SelectionStart - (NewPhoneInput.Text.Length - newText.Length);
                NewPhoneInput.Text = newText;
                NewPhoneInput.SelectionStart = Math.Max(0, cursorPosition);
            }
        }

        private void NewSaveButton_Click(object sender, EventArgs e)
        {
            if (NewPhoneInput.Text != "" && NewFioInput.Text != "")
            {
                Employee emp = new Employee
                {
                    Name = NewFioInput.Text,
                    PhoneNumber = NewPhoneInput.Text,
                    SubOrganization = _subOrganization
                };
                _context.Add(emp);
                _context.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
