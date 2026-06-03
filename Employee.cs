using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        string baseDir = AppContext.BaseDirectory;
        string fileName = "employeeDocument.txt";
        Document userDocument = new Document();

        private void Employee_Load(object sender, EventArgs e)
        {


            try
            {
                // Ищет точное совпадение
                string foundFile = Directory.EnumerateFiles(baseDir, fileName, SearchOption.AllDirectories)
                                            .FirstOrDefault();

                if (foundFile != null)
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(baseDir + "\\employeeDocument.txt");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ошибка чтения файла: " + ex.Message);
                    }
                }
                else
                {
                    File.WriteAllText(baseDir + "\\employeeDocument.txt", "");
                }
            }
            catch (UnauthorizedAccessException)
            {
                /*Console.WriteLine("Нет доступа к некоторым папкам.");*/
            }
        }

        private void btnRequestDoc_Click(object sender, EventArgs e)
        {
            ExNullInName();
            if(TypeDocument.Text == "Другое")
            {
                userDocument.SetDocument(textFullName.Text, otherTypeDoc.Text, (int)QuantityDocument.Value, textReasonRequest.Text, "Новый документ");

            }
            else
            {
                userDocument.SetDocument(textFullName.Text, TypeDocument.Text, (int)QuantityDocument.Value, textReasonRequest.Text, "Новый документ");
                
            }
            string textToAppend = userDocument.GetDocument();
            File.AppendAllText(baseDir + "\\employeeDocument.txt", textToAppend);
        }
        private void ExNullInName()
        {
            string fullName = textFullName.Text;

            if (!FullNameValidation.IsValid(fullName))
            {
                errorProvider.SetError(textFullName, "Введите ФИО: Фамилия Имя [Отчество], 2–3 части, только буквы и дефисы/апострофы.");
                textFullName.Focus();
                return;
            }

            errorProvider.SetError(textFullName, "");
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
