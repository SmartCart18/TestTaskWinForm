using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TestTaskWinForm
{
    public partial class UserIdentification : Form
    {

        public UserIdentification()
        {
            string baseDir = AppContext.BaseDirectory;
            string fileName = "employeeDocument.txt";
            if(!FileBase.SearchFiles(baseDir, fileName))
                FileBase.CreateFiles(baseDir, fileName);
            InitializeComponent();

        }
        private void btnOpenEmployeeForm(object sender, EventArgs e)
        {
            OpenEmployeeForm();
        }
        private void btnOpenAccountantForm(object sender, EventArgs e)
        {
            OpenAccountantForm();
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
