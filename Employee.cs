using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TestTaskWinForm
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void btnRequestDoc_Click(object sender, EventArgs e)
        {
            SaveAndBack();

        }
        private void SaveAndBack()
        {
            string fio = textFullName.Text;

            if (!FullNameValidation.IsValid(fio))
            {
                errorProvider.SetError(textFullName, "Введите ФИО: Фамилия Имя [Отчество], 2–3 части, только буквы и дефисы/апострофы.");
                textFullName.Focus();
                return;
            }

            errorProvider.SetError(textFullName, ""); // очищаем сообщение об ошибке
        }

        private void TypeDocument_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TypeDocument.Text != "Другое")
            {
                otherTypeDoc.Visible = false;
            }
            else
            {
                otherTypeDoc.Visible= true;
            }
        }
    }
}
