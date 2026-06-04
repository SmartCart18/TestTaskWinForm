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
    public partial class DataPopupForm : Form
    {
        public DataPopupForm()
        {
            InitializeComponent();
        }
        public DataPopupForm(string data)
        {
            InitializeComponent(); lblMessage.Text = data;
        }
    }
}
