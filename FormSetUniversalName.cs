using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentList2
{
    public partial class FormSetUniversalName : Form
    {
        public string SetName, Caption;
        public const int CREATE = 12, CHANGE = 13;
        public int Action;
        public UniversalList<Student> TempTempGroup;
        public FormSetUniversalName()
        {
            InitializeComponent();
        }

        private void FormSetUniversalName_Load(object sender, EventArgs e) // каждий раз, когда мы показываем окно вызывается этот метод
        {
            Text = Caption;
            if (Action == CHANGE)
                IdTextBoxInputUniversalName.Text = TempTempGroup.Caption;
            else
                IdTextBoxInputUniversalName.Text = "";
            IdTextBoxInputUniversalName.Focus();
        }

        private void IdButonInputUniversalOK_Click(object sender, EventArgs e)
        {
            SetName = IdTextBoxInputUniversalName.Text;
            if (SetName != "")
            {
                DialogResult = DialogResult.OK;
                IdTextBoxInputUniversalName.Focus();
                Close();
            }
            else
            {
                MessageBox.Show("You must enter the name!", "Error", MessageBoxButtons.OK);
                IdTextBoxInputUniversalName.Focus();
            }
        }

        private void IdButonInputUniversalCANCEL_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            IdTextBoxInputUniversalName.Focus();
            Close();
        }
    }
}
