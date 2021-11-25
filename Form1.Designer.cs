
namespace StudentList2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTextBoxStudents = new System.Windows.Forms.TextBox();
            this.IdListBoxStudents = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.IdTextBoxGroups = new System.Windows.Forms.TextBox();
            this.IdListBoxGroups = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.IdButtonMainDeleteStudent = new System.Windows.Forms.Button();
            this.IdButtonMainDeleteGroup = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.IdButtonMainChangeStudent = new System.Windows.Forms.Button();
            this.IdButtonMainChangeGroup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.IdButtonMainAddStudent = new System.Windows.Forms.Button();
            this.IdButtonMainAddGroup = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.IdButtonMainDeleteAllStudents = new System.Windows.Forms.Button();
            this.IdButtonMainDeleteAllGroups = new System.Windows.Forms.Button();
            this.IdButtonMainExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.IdListBoxStudentInfo = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.IdButtonMainAddFaculty = new System.Windows.Forms.Button();
            this.IdButtonMainChangeFaculty = new System.Windows.Forms.Button();
            this.IdButtonMainGetFacultyName = new System.Windows.Forms.Button();
            this.IdButtonMainDeleteFaculty = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.individualTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 634F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1069, 654);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.IdTextBoxStudents, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.IdListBoxStudents, 0, 2);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(537, 13);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(256, 628);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Students list:";
            // 
            // IdTextBoxStudents
            // 
            this.IdTextBoxStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdTextBoxStudents.Location = new System.Drawing.Point(8, 21);
            this.IdTextBoxStudents.Name = "IdTextBoxStudents";
            this.IdTextBoxStudents.Size = new System.Drawing.Size(235, 20);
            this.IdTextBoxStudents.TabIndex = 1;
            this.IdTextBoxStudents.TextChanged += new System.EventHandler(this.IdTextBoxStudents_TextChanged);
            // 
            // IdListBoxStudents
            // 
            this.IdListBoxStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdListBoxStudents.FormattingEnabled = true;
            this.IdListBoxStudents.HorizontalScrollbar = true;
            this.IdListBoxStudents.Location = new System.Drawing.Point(8, 64);
            this.IdListBoxStudents.Name = "IdListBoxStudents";
            this.IdListBoxStudents.Size = new System.Drawing.Size(235, 561);
            this.IdListBoxStudents.TabIndex = 2;
            this.IdListBoxStudents.SelectedIndexChanged += new System.EventHandler(this.IdListBoxStudents_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.IdTextBoxGroups, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.IdListBoxGroups, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(275, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(256, 628);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Groups list:";
            // 
            // IdTextBoxGroups
            // 
            this.IdTextBoxGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdTextBoxGroups.Location = new System.Drawing.Point(13, 21);
            this.IdTextBoxGroups.Name = "IdTextBoxGroups";
            this.IdTextBoxGroups.Size = new System.Drawing.Size(235, 20);
            this.IdTextBoxGroups.TabIndex = 1;
            this.IdTextBoxGroups.TextChanged += new System.EventHandler(this.IdTextBoxGroups_TextChanged);
            // 
            // IdListBoxGroups
            // 
            this.IdListBoxGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdListBoxGroups.FormattingEnabled = true;
            this.IdListBoxGroups.HorizontalScrollbar = true;
            this.IdListBoxGroups.Location = new System.Drawing.Point(13, 64);
            this.IdListBoxGroups.Name = "IdListBoxGroups";
            this.IdListBoxGroups.Size = new System.Drawing.Size(235, 561);
            this.IdListBoxGroups.TabIndex = 2;
            this.IdListBoxGroups.SelectedIndexChanged += new System.EventHandler(this.IdListBoxGroups_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.IdButtonMainExit, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(256, 628);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 135);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete seleted";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.IdButtonMainDeleteStudent, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.IdButtonMainDeleteGroup, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(244, 116);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // IdButtonMainDeleteStudent
            // 
            this.IdButtonMainDeleteStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdButtonMainDeleteStudent.Location = new System.Drawing.Point(10, 10);
            this.IdButtonMainDeleteStudent.Margin = new System.Windows.Forms.Padding(10);
            this.IdButtonMainDeleteStudent.Name = "IdButtonMainDeleteStudent";
            this.IdButtonMainDeleteStudent.Size = new System.Drawing.Size(224, 38);
            this.IdButtonMainDeleteStudent.TabIndex = 0;
            this.IdButtonMainDeleteStudent.Text = "Stude&nt";
            this.IdButtonMainDeleteStudent.UseVisualStyleBackColor = true;
            this.IdButtonMainDeleteStudent.Click += new System.EventHandler(this.IdButtonMainDeleteStudent_Click);
            // 
            // IdButtonMainDeleteGroup
            // 
            this.IdButtonMainDeleteGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdButtonMainDeleteGroup.Location = new System.Drawing.Point(10, 68);
            this.IdButtonMainDeleteGroup.Margin = new System.Windows.Forms.Padding(10);
            this.IdButtonMainDeleteGroup.Name = "IdButtonMainDeleteGroup";
            this.IdButtonMainDeleteGroup.Size = new System.Drawing.Size(224, 38);
            this.IdButtonMainDeleteGroup.TabIndex = 1;
            this.IdButtonMainDeleteGroup.Text = "Gro&up";
            this.IdButtonMainDeleteGroup.UseVisualStyleBackColor = true;
            this.IdButtonMainDeleteGroup.Click += new System.EventHandler(this.IdButtonMainDeleteGroup_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change selected";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.IdButtonMainChangeStudent, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.IdButtonMainChangeGroup, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(244, 116);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // IdButtonMainChangeStudent
            // 
            this.IdButtonMainChangeStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdButtonMainChangeStudent.Location = new System.Drawing.Point(10, 10);
            this.IdButtonMainChangeStudent.Margin = new System.Windows.Forms.Padding(10);
            this.IdButtonMainChangeStudent.Name = "IdButtonMainChangeStudent";
            this.IdButtonMainChangeStudent.Size = new System.Drawing.Size(224, 38);
            this.IdButtonMainChangeStudent.TabIndex = 0;
            this.IdButtonMainChangeStudent.Text = "S&tudent...";
            this.IdButtonMainChangeStudent.UseVisualStyleBackColor = true;
            this.IdButtonMainChangeStudent.Click += new System.EventHandler(this.IdButtonMainChangeStudent_Click);
            // 
            // IdButtonMainChangeGroup
            // 
            this.IdButtonMainChangeGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdButtonMainChangeGroup.Location = new System.Drawing.Point(10, 68);
            this.IdButtonMainChangeGroup.Margin = new System.Windows.Forms.Padding(10);
            this.IdButtonMainChangeGroup.Name = "IdButtonMainChangeGroup";
            this.IdButtonMainChangeGroup.Size = new System.Drawing.Size(224, 38);
            this.IdButtonMainChangeGroup.TabIndex = 1;
            this.IdButtonMainChangeGroup.Text = "G&roup...";
            this.IdButtonMainChangeGroup.UseVisualStyleBackColor = true;
            this.IdButtonMainChangeGroup.Click += new System.EventHandler(this.IdButtonMainChangeGroup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.IdButtonMainAddStudent, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.IdButtonMainAddGroup, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(244, 116);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // IdButtonMainAddStudent
            // 
            this.IdButtonMainAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdButtonMainAddStudent.Location = new System.Drawing.Point(10, 10);
            this.IdButtonMainAddStudent.Margin = new System.Windows.Forms.Padding(10);
            this.IdButtonMainAddStudent.Name = "IdButtonMainAddStudent";
            this.IdButtonMainAddStudent.Size = new System.Drawing.Size(224, 38);
            this.IdButtonMainAddStudent.TabIndex = 0;
            this.IdButtonMainAddStudent.Text = "&Student...";
            this.IdButtonMainAddStudent.UseVisualStyleBackColor = true;
            this.IdButtonMainAddStudent.Click += new System.EventHandler(this.IdButtonMainAddStudent_Click);
            // 
            // IdButtonMainAddGroup
            // 
            this.IdButtonMainAddGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdButtonMainAddGroup.Location = new System.Drawing.Point(10, 68);
            this.IdButtonMainAddGroup.Margin = new System.Windows.Forms.Padding(10);
            this.IdButtonMainAddGroup.Name = "IdButtonMainAddGroup";
            this.IdButtonMainAddGroup.Size = new System.Drawing.Size(224, 38);
            this.IdButtonMainAddGroup.TabIndex = 1;
            this.IdButtonMainAddGroup.Text = "&Group...";
            this.IdButtonMainAddGroup.UseVisualStyleBackColor = true;
            this.IdButtonMainAddGroup.Click += new System.EventHandler(this.IdButtonMainAddGroup_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.IdButtonMainDeleteAllStudents, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.IdButtonMainDeleteAllGroups, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 426);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(250, 119);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // IdButtonMainDeleteAllStudents
            // 
            this.IdButtonMainDeleteAllStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdButtonMainDeleteAllStudents.Location = new System.Drawing.Point(13, 9);
            this.IdButtonMainDeleteAllStudents.Margin = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.IdButtonMainDeleteAllStudents.Name = "IdButtonMainDeleteAllStudents";
            this.IdButtonMainDeleteAllStudents.Size = new System.Drawing.Size(224, 41);
            this.IdButtonMainDeleteAllStudents.TabIndex = 0;
            this.IdButtonMainDeleteAllStudents.Text = "De&lete All Students In Group";
            this.IdButtonMainDeleteAllStudents.UseVisualStyleBackColor = true;
            this.IdButtonMainDeleteAllStudents.Click += new System.EventHandler(this.IdButtonMainDeleteAllStudents_Click);
            // 
            // IdButtonMainDeleteAllGroups
            // 
            this.IdButtonMainDeleteAllGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdButtonMainDeleteAllGroups.Location = new System.Drawing.Point(13, 68);
            this.IdButtonMainDeleteAllGroups.Margin = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.IdButtonMainDeleteAllGroups.Name = "IdButtonMainDeleteAllGroups";
            this.IdButtonMainDeleteAllGroups.Size = new System.Drawing.Size(224, 42);
            this.IdButtonMainDeleteAllGroups.TabIndex = 1;
            this.IdButtonMainDeleteAllGroups.Text = "Delete &All Groups";
            this.IdButtonMainDeleteAllGroups.UseVisualStyleBackColor = true;
            this.IdButtonMainDeleteAllGroups.Click += new System.EventHandler(this.IdButtonMainDeleteAllGroups_Click);
            // 
            // IdButtonMainExit
            // 
            this.IdButtonMainExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.IdButtonMainExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdButtonMainExit.Location = new System.Drawing.Point(15, 571);
            this.IdButtonMainExit.Margin = new System.Windows.Forms.Padding(15, 23, 15, 15);
            this.IdButtonMainExit.Name = "IdButtonMainExit";
            this.IdButtonMainExit.Size = new System.Drawing.Size(226, 42);
            this.IdButtonMainExit.TabIndex = 4;
            this.IdButtonMainExit.Text = "E&xit";
            this.IdButtonMainExit.UseVisualStyleBackColor = true;
            this.IdButtonMainExit.Click += new System.EventHandler(this.IdButtonMainExit_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.IdListBoxStudentInfo, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(799, 13);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.970297F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.52475F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.50495F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(257, 628);
            this.tableLayoutPanel9.TabIndex = 3;
            // 
            // IdListBoxStudentInfo
            // 
            this.IdListBoxStudentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdListBoxStudentInfo.FormattingEnabled = true;
            this.IdListBoxStudentInfo.HorizontalScrollbar = true;
            this.IdListBoxStudentInfo.Location = new System.Drawing.Point(3, 21);
            this.IdListBoxStudentInfo.Name = "IdListBoxStudentInfo";
            this.IdListBoxStudentInfo.Size = new System.Drawing.Size(251, 292);
            this.IdListBoxStudentInfo.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel10);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 306);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Faculty actions";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.IdButtonMainAddFaculty, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.IdButtonMainChangeFaculty, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.IdButtonMainGetFacultyName, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.IdButtonMainDeleteFaculty, 0, 3);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 4;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(245, 287);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // IdButtonMainAddFaculty
            // 
            this.IdButtonMainAddFaculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdButtonMainAddFaculty.Location = new System.Drawing.Point(13, 13);
            this.IdButtonMainAddFaculty.Margin = new System.Windows.Forms.Padding(13);
            this.IdButtonMainAddFaculty.Name = "IdButtonMainAddFaculty";
            this.IdButtonMainAddFaculty.Size = new System.Drawing.Size(219, 45);
            this.IdButtonMainAddFaculty.TabIndex = 0;
            this.IdButtonMainAddFaculty.Text = "&Create Faculty...";
            this.IdButtonMainAddFaculty.UseVisualStyleBackColor = true;
            this.IdButtonMainAddFaculty.Click += new System.EventHandler(this.IdButtonMainAddFaculty_Click);
            // 
            // IdButtonMainChangeFaculty
            // 
            this.IdButtonMainChangeFaculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdButtonMainChangeFaculty.Location = new System.Drawing.Point(13, 84);
            this.IdButtonMainChangeFaculty.Margin = new System.Windows.Forms.Padding(13);
            this.IdButtonMainChangeFaculty.Name = "IdButtonMainChangeFaculty";
            this.IdButtonMainChangeFaculty.Size = new System.Drawing.Size(219, 45);
            this.IdButtonMainChangeFaculty.TabIndex = 1;
            this.IdButtonMainChangeFaculty.Text = "C&hange Faculty Name...";
            this.IdButtonMainChangeFaculty.UseVisualStyleBackColor = true;
            this.IdButtonMainChangeFaculty.Click += new System.EventHandler(this.IdButtonMainChangeFaculty_Click);
            // 
            // IdButtonMainGetFacultyName
            // 
            this.IdButtonMainGetFacultyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdButtonMainGetFacultyName.Location = new System.Drawing.Point(13, 155);
            this.IdButtonMainGetFacultyName.Margin = new System.Windows.Forms.Padding(13);
            this.IdButtonMainGetFacultyName.Name = "IdButtonMainGetFacultyName";
            this.IdButtonMainGetFacultyName.Size = new System.Drawing.Size(219, 45);
            this.IdButtonMainGetFacultyName.TabIndex = 2;
            this.IdButtonMainGetFacultyName.Text = "G&et Faculty Name...";
            this.IdButtonMainGetFacultyName.UseVisualStyleBackColor = true;
            this.IdButtonMainGetFacultyName.Click += new System.EventHandler(this.IdButtonMainGetFacultyName_Click);
            // 
            // IdButtonMainDeleteFaculty
            // 
            this.IdButtonMainDeleteFaculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdButtonMainDeleteFaculty.Location = new System.Drawing.Point(13, 226);
            this.IdButtonMainDeleteFaculty.Margin = new System.Windows.Forms.Padding(13);
            this.IdButtonMainDeleteFaculty.Name = "IdButtonMainDeleteFaculty";
            this.IdButtonMainDeleteFaculty.Size = new System.Drawing.Size(219, 48);
            this.IdButtonMainDeleteFaculty.TabIndex = 3;
            this.IdButtonMainDeleteFaculty.Text = "&Delete Faculty";
            this.IdButtonMainDeleteFaculty.UseVisualStyleBackColor = true;
            this.IdButtonMainDeleteFaculty.Click += new System.EventHandler(this.IdButtonMainDeleteFaculty_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Student info:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualTaskToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // individualTaskToolStripMenuItem
            // 
            this.individualTaskToolStripMenuItem.Name = "individualTaskToolStripMenuItem";
            this.individualTaskToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.individualTaskToolStripMenuItem.Text = "&Individual task";
            this.individualTaskToolStripMenuItem.Click += new System.EventHandler(this.individualTaskToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.IdButtonMainExit;
            this.ClientSize = new System.Drawing.Size(1069, 678);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Faculty list";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdTextBoxGroups;
        private System.Windows.Forms.ListBox IdListBoxGroups;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button IdButtonMainAddStudent;
        private System.Windows.Forms.Button IdButtonMainAddGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button IdButtonMainDeleteStudent;
        private System.Windows.Forms.Button IdButtonMainDeleteGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button IdButtonMainChangeStudent;
        private System.Windows.Forms.Button IdButtonMainChangeGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button IdButtonMainDeleteAllStudents;
        private System.Windows.Forms.Button IdButtonMainDeleteAllGroups;
        private System.Windows.Forms.Button IdButtonMainExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdTextBoxStudents;
        private System.Windows.Forms.ListBox IdListBoxStudents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.ListBox IdListBoxStudentInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button IdButtonMainAddFaculty;
        private System.Windows.Forms.Button IdButtonMainChangeFaculty;
        private System.Windows.Forms.Button IdButtonMainGetFacultyName;
        private System.Windows.Forms.Button IdButtonMainDeleteFaculty;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem individualTaskToolStripMenuItem;
    }
}

