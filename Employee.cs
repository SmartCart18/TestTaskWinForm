using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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
        string baseDir = AppContext.BaseDirectory;
        string fileName = "employeeDocument.txt";
        Document userDocument = new Document();
        List<string> list = new List<string>();

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            list = FileBase.LisenFiles(baseDir, fileName);
        }

        private void btnRequestDoc_Click(object sender, EventArgs e) //обработка кнопки по отправки запроса справки
        {
            ExNullInName(); 
            ExNullInReasonRec();
            ExNullInTypeDoc();
            ExNullInOtherReasonRec();
            if (textReasonRequest.Text != "" || textTypeDocument.Text != "")
            {
                if (textTypeDocument.Text == "Другое") // в зависимости от выбранного вида документа обрабатываются разные поля
                {
                    userDocument.SetDocument(textFullName.Text, otherTypeDoc.Text, (int)QuantityDocument.Value, textReasonRequest.Text, "Новый документ");
                }
                else
                {
                    userDocument.SetDocument(textFullName.Text, textTypeDocument.Text, (int)QuantityDocument.Value, textReasonRequest.Text, "Новый документ");
                }

                if (!list.Any(w => w.Contains(userDocument.ForСompareDocument())))
                {
                    FileBase.AppendlTextToFile(baseDir, fileName, userDocument.GetDocument() + "\n");     // запись в документ
                    list = FileBase.LisenFiles(baseDir, fileName);
                    MessageBox.Show("Данные успешно отправлены!", "Успех");
                    otherTypeDoc.Text = "";
                    QuantityDocument.Value = 1;
                    textReasonRequest.Text = "";
                    textTypeDocument.SelectedIndex = -1;
                }
            }
        }

        private void ExNullInName() // проверка на пустое поле ФИО
        {
            if (!FullNameValidation.IsValid(textFullName.Text))
            {
                errorProvider.SetError(textFullName, "Введите ФИО: Фамилия Имя [Отчество], 2–3 части, только буквы и дефисы/апострофы.");
                textFullName.Focus();
                return;
            }

            errorProvider.SetError(textFullName, "");
        }
        private void ExNullInTypeDoc()
        {
            if (textTypeDocument.Text =="")
            {
                errorTypeDocument.SetError(textTypeDocument, "Выберите вид справки.");
                textTypeDocument.Focus();
                return;
            }
            errorTypeDocument.SetError(textTypeDocument, "");
        }
        private void ExNullInReasonRec()
        {
            if (textReasonRequest.Text == "")
            {
                errorReasonRequest.SetError(textReasonRequest, "Укажите причину запроса.");
                textReasonRequest.Focus();
                return;
            }
            errorReasonRequest.SetError(textReasonRequest, "");
        }

        private void ExNullInOtherReasonRec()
        {
            if (otherTypeDoc.Text == "")
            {
                errorOtherTypeDoc.SetError(otherTypeDoc, "Укажите другую причину запроса.");
                otherTypeDoc.Focus();
                return;
            }
            errorOtherTypeDoc.SetError(otherTypeDoc, "");
        }


        private void TypeDocument_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(textTypeDocument.Text != "Другое")
            {
                otherTypeDoc.Visible = false;
            }
            else
            {
                otherTypeDoc.Visible= true;
            }
        }

        private void btnStatusRequestDoc_Click(object sender, EventArgs e)
        {
            ExNullInName();
            list = FileBase.LisenFiles(baseDir, fileName);
            if (FullNameValidation.IsValid(textFullName.Text))
            {
                List<string> dataSend = new List<string>();
                StringBuilder sb = new StringBuilder();
                string data = "";

                foreach (string item in list)
                {
                    if (item.Contains(textFullName.Text))
                    {
                        dataSend.Add(item);
                    }
                }

                if (dataSend.Count != 0)
                {
                    foreach (string item in dataSend)
                    {
                        sb.AppendLine(item.Replace(";", " "));
                    }
                    data = sb.ToString();

                    using (var popup = new DataPopupForm(data))
                    {
                        popup.ShowDialog(this);
                    }
                }
                else
                {
                    MessageBox.Show("На данного пользователя справок необнаружино!", "Ошибка");
                }
                
            }
                
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
