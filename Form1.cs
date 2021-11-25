//Короче, прогер, я это все написал и в благородство играть не буду. Сможешь это все осознать - и мы в расчете. За одно посмотрим, на сколько быстро у тебя голова прояснится после прочитанного.

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
    public partial class Form1 : Form // Главная форма
    {
        FormSetUniversalName FSUN = new FormSetUniversalName(); //Сразу же создаем екз окна для ввода названий групп/факультета
        FormStudentCreate FSC = new FormStudentCreate(); // ии окно студена (в обоих случая тут вызывается конструктор без метода *_Load)
        StudentStipuha FSS = new StudentStipuha();
       
        UniversalList<UniversalList<Student>> Faculty = new UniversalList<UniversalList<Student>>(); //Указатели на текущий факультет
        UniversalList<Student> Group; //группу
        Student Stud; // и студента (очевидно, не правда ли)

        int MaxGroupString = 0, MaxStudString = 0; // для скролов (максимальный размер)
        public const int CREATE = 12, CHANGE = 13, ADD_PIXEL = 85; // аналог #define в плюсах

        public Form1()
        {
            InitializeComponent(); //инициализация окна (чтото тип конструктора для WF)
            DisableFaculty(); 
        }

        //Безполезные методы и хрен его пойми откуда они взялись, но удалять не стал, малоли что
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //----------------------------------------------- Methods ---------------------------------------------------------
        private void DeleteAllGroups() // на самом деле не знаю, зачем в отдельный метод засунул...
        {
            Faculty.DelAll();
            IdListBoxGroups.ResetText();
            MessageBox.Show("Deletion success!", "Success!");
        }

        private string GetUniversalName(string caption)
        {
            FSUN.Caption = caption;
            if (FSUN.ShowDialog() == DialogResult.OK)
            {
                SetFacultyBtnsEnable(true);
            }
            return FSUN.SetName;
        }

        bool ChekSimilarName()
        {
            int count = IdListBoxGroups.Items.Count;
            foreach (UniversalList<Student> gr in Faculty)
                if (gr.Caption == FSUN.SetName)
                    return false;
            return true;
        }

        //----------------------------------------SetEnable-----------------------------------------------------------------

        bool SetFacultyBtnsEnable(bool State) //для инверсии кнопки добавления студента и вкл/выкл кнопок изменить факультет, удалить факультет, имени факультета и добавления групп а также активация лист бокта и текст бокса групп
        {
            IdButtonMainAddFaculty.Enabled = !State;
            IdButtonMainChangeFaculty.Enabled = IdButtonMainDeleteFaculty.Enabled = IdButtonMainGetFacultyName.Enabled = IdButtonMainAddGroup.Enabled = IdListBoxGroups.Enabled = IdTextBoxGroups.Enabled = State;
            IdListBoxGroups.Items.Clear();
            return State;
        }

        bool SetGroupBtnsEnable(bool State) // для вкл/выкл кнопок добавления студента и удаления всех групп
        {
            IdButtonMainAddStudent.Enabled = IdButtonMainDeleteAllGroups.Enabled = individualTaskToolStripMenuItem.Enabled = State;
            return State;
        }
        // верхняя и нижняя функции обычно идут вместе (Но это не точно)
        bool SetSelectedGroupBtnsEnable(bool State) // для вкл/выкл кнопок изменения группы, удаления группы и активация ист бокта и текст бокса студентов
        {
            IdButtonMainChangeGroup.Enabled = IdButtonMainDeleteGroup.Enabled = IdListBoxStudents.Enabled = IdTextBoxStudents.Enabled = State;
            IdTextBoxStudents.Text = "";
            return State;
        }

        bool SetSelectedStudentBtnsEnable(bool State) // бла, бла, много букав, из названий ид и так понятно
        {
            IdButtonMainChangeStudent.Enabled = IdButtonMainDeleteStudent.Enabled = IdListBoxStudentInfo.Enabled = IdButtonMainDeleteAllStudents.Enabled = State;
            return State;
        }

        void SetEnableStudInf(bool State)
        {
            IdListBoxStudentInfo.Items.Clear();
            IdListBoxStudentInfo.HorizontalExtent = 0;
            SetSelectedStudentBtnsEnable(State);
        }

        void SetEnableStudents(bool State)
        {
            IdListBoxStudents.Items.Clear();
            IdListBoxStudents.HorizontalExtent = 0;
            SetSelectedGroupBtnsEnable(State);
            SetEnableStudInf(State);
        }

        void SetEnableGroups(bool State)
        {
            IdListBoxGroups.Items.Clear();
            IdListBoxGroups.HorizontalExtent = 0;
            SetGroupBtnsEnable(State);
            SetEnableStudents(State);
        }

        void DisableFaculty()
        {
            SetFacultyBtnsEnable(false);
            SetEnableGroups(false);
        }

        //-----------------------------Work with faculty----------------------------------------

        private void IdButtonMainAddFaculty_Click(object sender, EventArgs e)
        {
            Faculty.Caption = GetUniversalName("Input faculty name");
        }
        private void IdButtonMainChangeFaculty_Click(object sender, EventArgs e)
        {
            Faculty.Caption = GetUniversalName("Input new faculty name");
        }

        private void IdButtonMainGetFacultyName_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Faculty.Caption, "Faculty name", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void IdButtonMainDeleteFaculty_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you realy want to DELETE the faculty?", "Deletion confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeleteAllGroups();
                Faculty.Caption = null;
                DisableFaculty();
            }
        }

        //----------------------------------------Exit------------------------------------------

        private void IdButtonMainExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void individualTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSS.GroupListRef = Faculty;
            FSS.ShowDialog();
        }

        //-----------------------------Work with Groups---------------------------------------------

        private void IdButtonMainAddGroup_Click(object sender, EventArgs e) // При нажатии на кнопку добавления студента
        {
            FSUN.Caption = "Input group name:"; //До вызова загрузки окна передаем переменные
            FSUN.Action = CREATE;
            
            if (FSUN.ShowDialog() == DialogResult.OK) // если результат ок
            {
                SetGroupBtnsEnable(false);
                if (ChekSimilarName()) //Проверяем, нет ли групп с таким же названием
                {
                    UniversalList<Student> TempStudentList = new UniversalList<Student>(FSUN.SetName); // Создаем переменную группы (опять же, выходит Костыль Костыльович, тут я создаю переменную (УУУУ, ТРУДОЕМКАЯ ОПЕРАЦИ, УУУУ) а потом передаю в метод добавления в список, и там опять new вызывается, а как по другому сделать - я еще не придумал)
                    Faculty.AddBeginElem(TempStudentList);
                    Faculty.Sort();

                    IdListBoxGroups.Items.Clear(); // Очищаем лист бок от всех строк
                    foreach (UniversalList<Student> gr in Faculty)
                        IdListBoxGroups.Items.Add(gr.Caption); // и снова выводим в лист бокс, но уже с новым элементом

                    IdButtonMainDeleteAllGroups.Enabled = individualTaskToolStripMenuItem.Enabled = true; // Активируем кнопку удаления всех групп
                    HScrlCorrect(IdListBoxGroups, ref MaxGroupString); // и корректируем скролл-бар
                }
                else // если все же есть такаяже группа, то по новой
                {
                    MessageBox.Show("This group already exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IdButtonMainAddGroup_Click(IdListBoxGroups, e); // Рекурсия
                }

                SetEnableStudInf(false);
                SetEnableStudents(false);
            }
        }

        private void IdButtonMainChangeGroup_Click(object sender, EventArgs e) // при нажати на кнопку изменения студента
        {
            FSUN.Caption = "Input new group name:"; //До вызова загрузки окна передаем переменные
            FSUN.TempTempGroup = Group;
            FSUN.Action = CHANGE;

            if (FSUN.ShowDialog() == DialogResult.OK) // если результат ок
            {
                if (ChekSimilarName()) //Проверяем, нет ли групп с таким же названием
                {
                    IdListBoxGroups.Items.Clear();// Очищаем лист бок от всех строк
                    Group.Caption = FSUN.SetName;
                    Faculty.Sort();
                    Faculty.SetHead(); // Устанавливаем значение текущего елемента на начало, чтоб далее в форич от начала пойти (UPD Неееет, херня полная, там в любом случае от начала пойдет, смысла в строке нет)

                    int CurSel = 0;
                    foreach (UniversalList<Student> gr in Faculty) // обходим все элементы и выводим их в лист бокс
                    {
                        IdListBoxGroups.Items.Add(gr.Caption);
                        if (gr.Caption == FSUN.SetName) // проверка для установления текущего елемента
                            IdListBoxGroups.SetSelected(CurSel, true); //Аналогично можно сделать (и так везде в похожих ситуациях) IdListBoxGroups.Selected = CurSel;
                        CurSel++;
                    }

                    HScrlCorrect(IdListBoxGroups, ref MaxGroupString);
                    IdListBoxGroups_SelectedIndexChanged(IdListBoxGroups, e);

                }
                else // если все же есть такаяже группа, то по новой
                {
                    MessageBox.Show("This group already exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IdButtonMainChangeGroup_Click(IdListBoxGroups, e);
                }
            }
        }

        private void IdButtonMainDeleteGroup_Click(object sender, EventArgs e) // при нажати на кнопку удаления студента
        {
            int Sel = IdListBoxGroups.SelectedIndex; // Находим на лист боксе выделенную группу
            IdListBoxGroups.Items.RemoveAt(Sel); // убираем ее от туда
            Faculty.DelElem(Group); // удаляем из списка
            HScrlCorrect(IdListBoxGroups, ref MaxGroupString); // корректируем скролл

            if (Sel - 1 >= 0) // есть ли выше по списку (от текущего) элементы?
            {
                Sel--; // передвигаем текущий элемент выше
                IdListBoxGroups.SetSelected(Sel, true);
                IdListBoxGroups_SelectedIndexChanged(IdListBoxGroups, e);
                SetEnableStudInf(false);
            }
            else if (Sel == 0 && IdListBoxGroups.Items.Count != 0) // а ниже по списку? ( почему так а не наоборот? ПОТОМУ ЧТО)
            {
                IdListBoxGroups.SetSelected(Sel, true); // передвигаем текущий элемент ниже 
                IdListBoxGroups_SelectedIndexChanged(IdListBoxGroups, e);
                SetEnableStudInf(false);
            }
            else // если список стал пустым
            {
                SetGroupBtnsEnable(false);
                SetEnableStudents(false);
            }

            if (IdListBoxGroups.Items.Count > 0)
                IdButtonMainDeleteAllGroups.Enabled = true;
        }

        private void IdListBoxGroups_SelectedIndexChanged(object sender, EventArgs e) // Реакция на кликанье мышью в лист боксе
        {
            int Sel = IdListBoxGroups.SelectedIndex, x = 0;
            if (Sel != -1)  //Если кликнули по пустому месту в ЛистБокс (0 - нулевой элемент, 1 - первый, ... , -1 - не выделен никакой элемент)
            {
                SetEnableStudInf(false); //кучка активаций
                SetGroupBtnsEnable(true);
                SetSelectedGroupBtnsEnable(true);

                object SelectedSrud = IdListBoxStudents.SelectedItem; // сохраняем текущий выделенный элемент (Потому что мы список удаляем, а потом создаем, и вдруг мы нажали на ту же группу, а нам надо, чтоб студен остался выделенным)
                IdListBoxStudents.Items.Clear();
                IdListBoxStudents.HorizontalExtent = 0;
                Faculty.Sort(); // Всегда лучше сортировать чтоб синхронизировать содержимое списка и то что показывается в ЛистБоксе (По порядку)
                Faculty.SetHead();
                foreach (UniversalList<Student> gr in Faculty) // проходим по всем элементам (элементам-спискам) и находим в списке тот, на который нажали
                {
                    if (x == Sel)
                    {
                        if(Group != gr) 
                        {
                            Group = gr;
                        }
                        break;
                    }
                    x++;
                }
                IdListBoxStudentInfo.HorizontalExtent = 0;
                if (Group.GetTail()) // существутвуют ли элементы в найденом списке (нету хвоста - нету списка)
                {
                    IdButtonMainDeleteAllStudents.Enabled = true;
                    Group.Sort(); // И тут лучше сортировать
                    foreach (Student st in Group) // И выводим все элементы даного списка
                        IdListBoxStudents.Items.Add(st.secName);

                    IdListBoxStudents.HorizontalExtent = MaxStudString;
                    HScrlCorrect(IdListBoxStudents, ref MaxStudString);

                    IdListBoxStudents.SelectedItem = SelectedSrud; //и выделяем текущий элемент (если такого нет, то ничего страшного, передастя -1 и ничего не выделится)
                }
            }

        }

        //---------------------------------Work with student-------------------------------------------------------------------------------------------------------

        private void IdButtonMainAddStudent_Click(object sender, EventArgs e)
        {
            FSC.Action = CREATE;
            FSC.CurSel = IdListBoxGroups.SelectedIndex;
            FSC.GroupListRef = Faculty;
            int i = 0;

            for (int j = 0; j < FSC.BufferArray.GetLength(0); j++) // КОСТЫЫЫЫЫЫЛЬ (Как Сделать чере форич не знаю). Так для чего же это нужно - если у нас был список, а его потом удалили то чтоб в спике они больше не появлялись
                FSC.BufferArray[j] = null;

            foreach (UniversalList<Student> gr in Faculty)
                FSC.BufferArray.SetValue(gr.Caption, i++);

            FSC.ShowDialog();
            if (FSC.flag) // Тот самый флажек, если мы просто нажали Cancel, то ничего не происходит (Это не значит, что после нажатия Next а потом Cancel тоже ничего не должно происходить, поэто и нужен флаг)
            {
                //Group = FSC.TempGroup;
                
                IdListBoxGroups.SelectedIndex = FSC.CurSel;
                IdListBoxGroups_SelectedIndexChanged(IdListBoxGroups, e);
            }
        }

        private void IdButtonMainChangeStudent_Click(object sender, EventArgs e)
        {
            FSC.Action = CHANGE;
            FSC.TempStudent = Stud;
            FSC.TempTempGroup = Group;
            int CurSel = 0;

            for (int j = 0; j < FSC.BufferArray.GetLength(0); j++)
                FSC.BufferArray[j] = null;

            foreach (UniversalList<Student> gr in Faculty)
                FSC.BufferArray.SetValue(gr.Caption, CurSel++);

            if (FSC.ShowDialog() == DialogResult.OK)
            {
                Group.Sort();
                IdListBoxStudents.Items.Clear();
                CurSel = 0;
                foreach (Student st in Group)
                {
                    IdListBoxStudents.Items.Add(st.secName); //Сколько же боли в этой строке... (UPD Уже и не помню что было не так, но просидел я тут гдет пол часа)
                    if (st.secName == FSC.SecName)
                        IdListBoxStudents.SetSelected(CurSel, true);
                    CurSel++;
                }
                SetEnableStudInf(false);

                HScrlCorrect(IdListBoxStudents, ref MaxStudString);
                IdListBoxStudents_SelectedIndexChanged(IdListBoxStudents, e);
            }
        }

        private void IdButtonMainDeleteStudent_Click(object sender, EventArgs e)
        {
            int Sel = IdListBoxStudents.SelectedIndex;
            IdListBoxStudents.Items.RemoveAt(Sel);
            Group.DelElem(Stud);
            HScrlCorrect(IdListBoxStudents, ref MaxStudString);
            if (Sel - 1 >= 0)
            {
                Sel--;
                IdListBoxStudents.SetSelected(Sel, true);
                IdListBoxStudents_SelectedIndexChanged(IdListBoxStudents, e);
            }
            else if (Sel == 0 && IdListBoxStudents.Items.Count != 0)
            {
                IdListBoxStudents.SetSelected(Sel, true);
                IdListBoxStudents_SelectedIndexChanged(IdListBoxStudents, e);
            }
            else
                SetEnableStudInf(false);
        }

        private void IdListBoxStudents_SelectedIndexChanged(object sender, EventArgs e)  // Реакция на кликанье мышью в лист боксе
        { 
            int Sel = IdListBoxStudents.SelectedIndex, x = 0;
            if (Sel != -1)
            {
                SetSelectedStudentBtnsEnable(true);

                Group.Sort();
                Group.SetHead();
                foreach (Student st in Group)
                {
                    if (x == Sel)
                    {
                        Stud = st;
                        break;
                    }
                    x++;
                }
                OutStudInfo(Stud);
            }
        }

        void OutStudInfo(Student S) // ддя корректног вывода студентов в лист бокс (Да, да, можно использовать форматированный вывод, но кому какое дело о этого?)
        {
            IdListBoxStudentInfo.HorizontalExtent = 0;
            int MaxStudInfoString = 0;
            string Buf;
            IdListBoxStudentInfo.Items.Clear();

            Buf = "SecondName:     " + S.secName;
            IdListBoxStudentInfo.Items.Add(Buf);
            HScrlAdd(IdListBoxStudentInfo, S.secName, ref MaxStudInfoString, ADD_PIXEL);

            Buf = "Name:                 " + S.name;
            IdListBoxStudentInfo.Items.Add(Buf);
            HScrlAdd(IdListBoxStudentInfo, S.name, ref MaxStudInfoString, ADD_PIXEL);

            Buf = "MidleName:         " + S.midName;
            IdListBoxStudentInfo.Items.Add(Buf);
            HScrlAdd(IdListBoxStudentInfo, S.midName, ref MaxStudInfoString, ADD_PIXEL);

            Buf = "Birth Year:           " + S.birthYear;
            IdListBoxStudentInfo.Items.Add(Buf);

            Buf = "Average Mark:    " + S.midMark;
            IdListBoxStudentInfo.Items.Add(Buf);

            IdListBoxStudentInfo.HorizontalExtent = MaxStudInfoString;
        }

        //-------------------------------------Delete all------------------------------------------------

        private void IdButtonMainDeleteAllGroups_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you realy want to DELETE all GROUPS?", "Deletion confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SetEnableGroups(false);
                DeleteAllGroups();
                IdTextBoxGroups.Clear();
            }
        }

        private void IdButtonMainDeleteAllStudents_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you realy want to DELETE all STUDENTS in selected group?", "Deletion confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Group.DelAll();
                SetEnableStudents(false);
                IdTextBoxStudents.Clear();
                MessageBox.Show("Deletion success!", "Success!", MessageBoxButtons.OK);
            }
        }

        //---------------------------------------Text Box-----------------------------------------------------
        // Просто скопированно. Зачем придумывать то, что уже умные дядки придумали до нас, ммм? ИД только поменть и все работает

        private void IdTextBoxGroups_TextChanged(object sender, EventArgs e)
        {
            int index = IdListBoxGroups.FindString(((TextBox)(sender)).Text);
            if (index != ListBox.NoMatches && ((TextBox)(sender)).TextLength > 0)
            {
                IdListBoxGroups.SetSelected(index, true);
                IdListBoxGroups_SelectedIndexChanged(IdListBoxGroups, e);
            }
        }



        private void IdTextBoxStudents_TextChanged(object sender, EventArgs e)
        {
            int index = IdListBoxStudents.FindString(((TextBox)(sender)).Text);
            if (index != ListBox.NoMatches && ((TextBox)(sender)).TextLength > 0)
            {
                IdListBoxStudents.SetSelected(index, true);
                IdListBoxStudents_SelectedIndexChanged(IdListBoxStudents, e);
            }
        }

        //---------------------------------------ScrollBAR-----------------------------------------------------
        // Можно было обойтись одним HScrlCorrect, но раз уж мы с эффективность заигрываем...(ну и факт того, что это тупо скопированно никто не отменял)

        private void HScrlAdd(ListBox List, string CurString, ref int MaxString, int Bonus = 0)
        {
            int CurExt = TextRenderer.MeasureText(CurString, List.Font).Width + Bonus;
            if (CurExt > MaxString)
                MaxString = CurExt;
        }

        private void HScrlCorrect(ListBox List, ref int MaxString)
        {
            int CurExt;
            MaxString = 0;
            foreach (object Elem in List.Items)
                if ((CurExt = TextRenderer.MeasureText(Elem.ToString(), List.Font).Width) > MaxString) // интерестный метод для нахождения кол-ва занимаемых пикселей на экране.
                    MaxString = CurExt;
            List.HorizontalExtent = MaxString;
        }
    }
}
