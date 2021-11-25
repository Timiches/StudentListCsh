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
    public partial class StudentStipuha : Form
    {
        public UniversalList<UniversalList<Student>> GroupListRef;
        int MidMarkStandart;
        public StudentStipuha()
        {
            InitializeComponent();
        }

        void SetActive(TextBoxBase Edit)
        {
            Edit.Focus();
            Edit.SelectAll();
        }

        private void StudentStipuha_Load(object sender, EventArgs e)
        {
            IDLVStudentsStepuha.Items.Clear();
            IDTBMidMark.Clear();
            IDBCheck.Enabled = false;
            ActiveControl = IDTBMidMark;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IDBCheck_Click(object sender, EventArgs e)
        {
            IDLVStudentsStepuha.Items.Clear();
            if (System.Int32.TryParse(IDTBMidMark.Text, out MidMarkStandart) && MidMarkStandart <= 100 && MidMarkStandart >= 0)
            {
                foreach (UniversalList<Student> gr in GroupListRef)
                    foreach (Student st in gr)
                        if (MidMarkStandart > st.midMark)
                        {
                            ListViewItem item = new ListViewItem(st.secName);
                            item.SubItems.Add(st.name);
                            item.SubItems.Add(gr.Caption);
                            item.SubItems.Add(st.midMark.ToString());
                            IDLVStudentsStepuha.Items.Add(item);
                        }
                SetActive(IDTBMidMark);
            }
            else
            {
                MessageBox.Show("Average Mark is wrong!\nIt must be from 0 to 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetActive(IDTBMidMark);
            }
        }

        private void IDTBMidMark_TextChanged(object sender, EventArgs e)
        {
            IDBCheck.Enabled = IDTBMidMark.Text != "" ?  true : false;
        }

        private void IDBClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
