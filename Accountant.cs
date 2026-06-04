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
        public Accountant()
        {
            InitializeComponent();
            
        }

        private void Accountant_Load(object sender, EventArgs e)
        {
            List<string> list = FileBase.LisenFiles(baseDir, fileName);
            textAllEmployee.Text = TextAllEmp();
            ComboBoxFillingEmp();
        }

        private void btnApplyChange_Click(object sender, EventArgs e)
        {
            
        }

        private string TextAllEmp()
        {
            List<string> list = FileBase.LisenFiles(baseDir, fileName);
            list = FileBase.LisenFiles(baseDir, fileName);
            StringBuilder sb = new StringBuilder();
            foreach (string item in list)
            {
                sb.AppendLine(item.Replace(";", " "));
            }
            return sb.ToString();
        }
        private void ComboBoxFillingEmp()
        {
            List<string> list = FileBase.LisenFiles(baseDir, fileName);
            foreach (string item in list)
                comboEnterEmployee.Items.Add(item.Replace(";", " "));
        }
    }
}
