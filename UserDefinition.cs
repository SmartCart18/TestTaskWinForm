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
            InitializeComponent();
        }

        private void UserIdentification_Load(object sender, EventArgs e)
        {
            string baseDir = AppContext.BaseDirectory;
            string fileName = "employeeDocument.txt";

            try
            {
                // Ищет точное совпадение
                string foundFile = Directory.EnumerateFiles(baseDir, fileName, SearchOption.AllDirectories)
                                            .FirstOrDefault();

                if (foundFile != null)
                {
                    /*Console.WriteLine($"Файл найден: {foundFile}");*/
                }
                else
                {
                    /*Console.WriteLine("Файл не найден.");*/
                    File.WriteAllText(baseDir + "\\employeeDocument.txt", "");
                }
            }
            catch (UnauthorizedAccessException)
            {
                /*Console.WriteLine("Нет доступа к некоторым папкам.");*/
            }

            try
            {
                string[] lines = File.ReadAllLines(baseDir + "\\employeeDocument.txt");
               /* Console.WriteLine($"Прочитано строк: {lines.Length}");
                foreach (var line in lines) Console.WriteLine(line); */
            }
            catch (Exception ex) { Console.WriteLine("Ошибка чтения файла: " + ex.Message); }
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
