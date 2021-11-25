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
    public partial class FormStudentCreate : Form
    {
        public const int CREATE = 12, CHANGE = 13;

        public int Action = CREATE, CurSel = 0;
        public string[] BufferArray = new string[30];
        public string GroupCaption;
        public Student TempStudent;
        public UniversalList<Student> TempTempGroup, TempGroup; //КостыльКостыльович x2
        public UniversalList<UniversalList<Student>> GroupListRef;
        public bool flag = false;

        public string FirName; // Почему-то нельзя подписать как Name
        public string SecName;
        public string MidName;
        public int BirthYear;
        public int MidMark;

        public FormStudentCreate()
        {
            InitializeComponent();
        }

        public void FormStudentCreate_Load(object sender, EventArgs e) // каждий раз, когда мы показываем окно вызывается этот метод
        {
            IdComboBoxInStudInfChooseGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            if (Action == CREATE)
            {
                AcceptButton = IdButtonInStudInfNEXT;
                ActiveControl = IdButtonInStudInfNEXT;
                IdButtonInStudInfNEXT.Visible = true;
                IdComboBoxInStudInfChooseGroup.Enabled = true;
            }
            else
            {
                AcceptButton = IdButtonInStudInfOK;
                ActiveControl = IdButtonInStudInfOK;
                IdButtonInStudInfNEXT.Visible = false;
                IdComboBoxInStudInfChooseGroup.Enabled = false;
            }
            ResetFields();
            //SetActive(IdTextBoxInStudInfSecondName); // ? UPD Не работает потому, что надо вызывать ActiveControl, а не это
            IdComboBoxInStudInfChooseGroup.Items.Clear();
            foreach (string str in BufferArray)
                if (str != null)
                    IdComboBoxInStudInfChooseGroup.Items.Add(str);
            IdComboBoxInStudInfChooseGroup.SelectedIndex = CurSel;
            flag = false;
            this.ActiveControl = IdTextBoxInStudInfSecondName;
            SetActive(IdTextBoxInStudInfSecondName);
        }

        void ResetFields()
        {
            if (Action == CREATE)
            {
                IdTextBoxInStudInfName.Clear();
                IdTextBoxInStudInfSecondName.Clear();
                IdTextBoxInStudInfMiddleName.Clear();
                IdTextBoxInStudInfBirthYear.Clear();
                IdTextBoxInStudInfAvMark.Clear();
            }
            else
            {
                IdTextBoxInStudInfName.Text = TempStudent.name;
                IdTextBoxInStudInfSecondName.Text = TempStudent.secName;
                IdTextBoxInStudInfMiddleName.Text = TempStudent.midName;
                IdTextBoxInStudInfBirthYear.Text = TempStudent.birthYear.ToString();
                IdTextBoxInStudInfAvMark.Text = TempStudent.midMark.ToString();
            }
        }

        void SetActive(TextBoxBase Edit)
        {
            Edit.Focus();
            Edit.SelectAll();
        }

        bool FillStudInfo()
        {
            SecName = IdTextBoxInStudInfSecondName.Text.Trim();
            if (SecName.Length <= 0)
            {
                MessageBox.Show("Student surname is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetActive(IdTextBoxInStudInfSecondName);
                return false;
            }

            FirName = IdTextBoxInStudInfName.Text.Trim();
            if (FirName.Length <= 0)
            {
                MessageBox.Show("Student name is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetActive(IdTextBoxInStudInfName);
                return false;
            }

            MidName = IdTextBoxInStudInfMiddleName.Text.Trim();

            if (!System.Int32.TryParse(IdTextBoxInStudInfBirthYear.Text, out BirthYear) || BirthYear < 1900 || BirthYear > 2020) // хе-хе, поговариваю, за не использование константных переменн можно получить лопатой по голове в темном-темном переулке 
            {
                MessageBox.Show("Birth year is wrong! \nIt must be from 1900 to 2020", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetActive(IdTextBoxInStudInfBirthYear);
                return false;
            }

            if (!System.Int32.TryParse(IdTextBoxInStudInfAvMark.Text, out MidMark) || MidMark < 0 || MidMark > 100)
            {
                MessageBox.Show("Average Mark is wrong!\nIt must be from 0 to 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetActive(IdTextBoxInStudInfAvMark);
                return false;
            }
            return true;
        }

        public bool AddStudent()
        {
            TempGroup = new UniversalList<Student>(GroupCaption);// блоооо, ну не знаю, при каждом добавлении вызывается new...
            if (GroupListRef.Find(TempGroup) == true)
            {
                GroupListRef.GetCurInf(ref TempGroup);
                foreach (Student st in TempGroup)
                    if (st.name == FirName && st.secName == SecName && st.midName == MidName)
                    {
                        MessageBox.Show("It cannot be, that we have 2 similar students", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SetActive(IdTextBoxInStudInfSecondName);
                        return false;
                    }
                TempStudent = new Student(FirName, SecName, MidName, BirthYear, MidMark);
                TempGroup.AddBeginElem(TempStudent);
                return true;
            }
            MessageBox.Show("Not found selected group", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            SetActive(IdTextBoxInStudInfSecondName);
            return false;
        }

        bool ChangeStudent()
        {
            foreach (Student st in TempTempGroup)
                if (st.name == FirName && st.secName == SecName && st.midName == MidName)
                {
                    MessageBox.Show("It cannot be, that we have 2 similar students", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SetActive(IdTextBoxInStudInfSecondName);
                    return false;
                }

            TempStudent.name = FirName;
            TempStudent.secName = SecName;
            TempStudent.midName = MidName;
            TempStudent.birthYear = BirthYear;
            TempStudent.midMark = MidMark;
            return true;
        }

        private void IdButtonInStudInfOK_Click(object sender, EventArgs e)
        {
            if (FillStudInfo() == true)
            {
                bool status;
                IdComboBoxInStudInfChooseGroup.Focus();
                GroupCaption = IdComboBoxInStudInfChooseGroup.SelectedItem.ToString();
                //Action == CREATE ? status = AddStudent() : status = ChangeStudent();
                if (Action == CREATE)
                    status = AddStudent();
                else
                    status = ChangeStudent();
                if (status)
                {
                    CurSel = IdComboBoxInStudInfChooseGroup.SelectedIndex;
                    DialogResult = DialogResult.OK;
                    flag = true;
                    Close();
                }
            }
        }

        private void IdButtonInStudInfCANCEL_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void IdButtonInStudInfNEXT_Click(object sender, EventArgs e)
        {
            if (FillStudInfo() == true)
            {
                IdComboBoxInStudInfChooseGroup.Focus();
                GroupCaption = IdComboBoxInStudInfChooseGroup.SelectedItem.ToString();
                AddStudent();
                SetActive(IdTextBoxInStudInfName); // Ето все чтобы при табуляции выделялись строки во всех текст боксах
                SetActive(IdTextBoxInStudInfMiddleName);
                SetActive(IdTextBoxInStudInfBirthYear);
                SetActive(IdTextBoxInStudInfAvMark);
                SetActive(IdTextBoxInStudInfSecondName);
                flag = true;
            }
        }
    }
}
