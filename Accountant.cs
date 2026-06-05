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
    public partial class Accountant : Form
    {
        string baseDir = AppContext.BaseDirectory;
        string fileName = "employeeDocument.txt";
        Document userDocument = new Document();
        List<string> list = new List<string>();
        public Accountant()
        {
            InitializeComponent();
            
        }

        private void Accountant_Load(object sender, EventArgs e)
        {
            list = FileBase.LisenFiles(baseDir, fileName);
            textAllEmployee.Text = TextAllEmp();
            ComboBoxFillingEmp();
        }

        private void btnApplyChange_Click(object sender, EventArgs e)
        {
            ExNullInComboTypeDoc();
            ExNullInComboEnterEmployee();
            if (comboEnterEmployee.Text != "" & comboStatusDoc.Text != "")
            {
                userDocument.SetDocument(list[comboEnterEmployee.SelectedIndex], ';');  //запись в переменную класса Document выбранную справку
                if (userDocument.StatusDocument == comboStatusDoc.Text)
                {
                    MessageBox.Show("Статусы совподают, измените поле статуса на верное.","Ошибка!");
                }
                else
                {
                    userDocument.StatusDocument = comboStatusDoc.Text;                          //замена статуса в переменной
                    list[comboEnterEmployee.SelectedIndex] = userDocument.GetDocumentText();    //изменение справки в массиве справок
                    FileBase.WriteTextToFile(baseDir, fileName, list.ToArray());                //запись изменённого массива в файл
                    MessageBox.Show("Статус изменён.", "Успешно"); 
                    textAllEmployee.Text = TextAllEmp();
                    ComboBoxFillingEmp();
                }
            }

        }

        private string TextAllEmp()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string item in list)
            {
                sb.AppendLine(item.Replace(";", " "));
            }
            return sb.ToString();
        }

        private void ComboBoxFillingEmp()
        {
            comboEnterEmployee.Items.Clear();
            foreach (string item in list)
                comboEnterEmployee.Items.Add(item);
        }

        private void btnCloseAcc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExNullInComboTypeDoc()
        {
            if (comboStatusDoc.Text == "")
            {
                errorComboStatusDoc.SetError(comboStatusDoc, "Выберите статус справки.");
                comboStatusDoc.Focus();
                return;
            }
            errorComboStatusDoc.SetError(comboStatusDoc, "");
        }

        private void ExNullInComboEnterEmployee()
        {
            if (comboEnterEmployee.Text == "")
            {
                errorComboEmployee.SetError(comboEnterEmployee, "Выберите справку для изменения статуса.");
                comboEnterEmployee.Focus();
                return;
            }
            errorComboEmployee.SetError(comboEnterEmployee, "");
        }
    }
}
