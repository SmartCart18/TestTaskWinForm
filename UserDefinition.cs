using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTaskWinForm
{
    public partial class UserIdentification : Form



    {
        public UserIdentification()
        {
            InitializeComponent();
        }

        private void UserIdentification_Load(object sender, EventArgs e)
        {

        }
        private void btnOpenEmployeeForm(object sender, EventArgs e)
        {
            OpenEmployeeForm();
        }

        private void OpenEmployeeForm()
        {
            var f = new Employee();
            // скрыть текущее окно и показать новое; после закрытия вернуться и обновить статус
            this.Hide();
            f.FormClosed += (s, e) =>
            {
                this.Show();
            };
            f.Show();
        }

        private void btnOpenAccountantForm(object sender, EventArgs e)
        {
            OpenAccountantForm();
        }

        private void OpenAccountantForm()
        {
            var f = new Accountant();
            this.Hide();
            f.FormClosed += (s, e) =>
            {
                this.Show();

            };
            f.Show();
        }

    }
}
