namespace Coursework
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Name_student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Record_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu = new System.Windows.Forms.TabControl();
            this.Create = new System.Windows.Forms.TabPage();
            this.button_password = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.button_grid = new System.Windows.Forms.Button();
            this.numeric_course = new System.Windows.Forms.NumericUpDown();
            this.button_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_faculty = new System.Windows.Forms.TextBox();
            this.textBox_record = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.password = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numeric_mark1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_teacher1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_subject1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox_search = new System.Windows.Forms.RichTextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button_discipline = new System.Windows.Forms.Button();
            this.button_dupes = new System.Windows.Forms.Button();
            this.button_thebest = new System.Windows.Forms.Button();
            this.richTextInformation = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.Menu.SuspendLayout();
            this.Create.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_course)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_mark1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_student,
            this.Record_number,
            this.name_faculty,
            this.number_course,
            this.subject1,
            this.Teacher1,
            this.Mark1,
            this.Subject2,
            this.Teacher2,
            this.Mark2,
            this.Subject3,
            this.Teacher3,
            this.Mark3,
            this.Subject4,
            this.Teacher4,
            this.Mark4,
            this.Subject5,
            this.Teacher5,
            this.Mark5});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1000, 384);
            this.dataGridView.TabIndex = 0;
            // 
            // Name_student
            // 
            this.Name_student.HeaderText = "Name";
            this.Name_student.Name = "Name_student";
            this.Name_student.Width = 120;
            // 
            // Record_number
            // 
            this.Record_number.HeaderText = "Record Number";
            this.Record_number.Name = "Record_number";
            this.Record_number.Width = 50;
            // 
            // name_faculty
            // 
            this.name_faculty.HeaderText = "Name Faculty";
            this.name_faculty.Name = "name_faculty";
            // 
            // number_course
            // 
            this.number_course.HeaderText = "Course ";
            this.number_course.Name = "number_course";
            this.number_course.Width = 50;
            // 
            // subject1
            // 
            this.subject1.HeaderText = "Subject 1";
            this.subject1.Name = "subject1";
            // 
            // Teacher1
            // 
            this.Teacher1.HeaderText = "Teacher";
            this.Teacher1.Name = "Teacher1";
            // 
            // Mark1
            // 
            this.Mark1.HeaderText = "Mark";
            this.Mark1.Name = "Mark1";
            this.Mark1.Width = 40;
            // 
            // Subject2
            // 
            this.Subject2.HeaderText = "Subject 2";
            this.Subject2.Name = "Subject2";
            // 
            // Teacher2
            // 
            this.Teacher2.HeaderText = "Teacher";
            this.Teacher2.Name = "Teacher2";
            // 
            // Mark2
            // 
            this.Mark2.HeaderText = "Mark";
            this.Mark2.Name = "Mark2";
            this.Mark2.Width = 40;
            // 
            // Subject3
            // 
            this.Subject3.HeaderText = "Subject 3";
            this.Subject3.Name = "Subject3";
            // 
            // Teacher3
            // 
            this.Teacher3.HeaderText = "Teacher";
            this.Teacher3.Name = "Teacher3";
            // 
            // Mark3
            // 
            this.Mark3.HeaderText = "Mark";
            this.Mark3.Name = "Mark3";
            this.Mark3.Width = 40;
            // 
            // Subject4
            // 
            this.Subject4.HeaderText = "Subject 4";
            this.Subject4.Name = "Subject4";
            // 
            // Teacher4
            // 
            this.Teacher4.HeaderText = "Teacher";
            this.Teacher4.Name = "Teacher4";
            // 
            // Mark4
            // 
            this.Mark4.HeaderText = "Mark";
            this.Mark4.Name = "Mark4";
            this.Mark4.Width = 40;
            // 
            // Subject5
            // 
            this.Subject5.HeaderText = "Subject 5";
            this.Subject5.Name = "Subject5";
            // 
            // Teacher5
            // 
            this.Teacher5.HeaderText = "Teacher";
            this.Teacher5.Name = "Teacher5";
            // 
            // Mark5
            // 
            this.Mark5.HeaderText = "Mark";
            this.Mark5.Name = "Mark5";
            this.Mark5.Width = 40;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.Create);
            this.Menu.Controls.Add(this.tabPage2);
            this.Menu.Controls.Add(this.tabPage1);
            this.Menu.Controls.Add(this.tabPage3);
            this.Menu.Controls.Add(this.tabPage5);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(1014, 419);
            this.Menu.TabIndex = 1;
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.Gainsboro;
            this.Create.Controls.Add(this.button_password);
            this.Create.Controls.Add(this.textBox_password);
            this.Create.Controls.Add(this.richText);
            this.Create.Controls.Add(this.button_grid);
            this.Create.Controls.Add(this.numeric_course);
            this.Create.Controls.Add(this.button_add);
            this.Create.Controls.Add(this.label4);
            this.Create.Controls.Add(this.label3);
            this.Create.Controls.Add(this.label2);
            this.Create.Controls.Add(this.textBox_faculty);
            this.Create.Controls.Add(this.textBox_record);
            this.Create.Controls.Add(this.label1);
            this.Create.Controls.Add(this.textBox_name);
            this.Create.Controls.Add(this.menuStrip1);
            this.Create.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Create.Location = new System.Drawing.Point(4, 25);
            this.Create.Name = "Create";
            this.Create.Padding = new System.Windows.Forms.Padding(3);
            this.Create.Size = new System.Drawing.Size(1006, 390);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            // 
            // button_password
            // 
            this.button_password.Location = new System.Drawing.Point(29, 332);
            this.button_password.Name = "button_password";
            this.button_password.Size = new System.Drawing.Size(143, 31);
            this.button_password.TabIndex = 34;
            this.button_password.Text = "Generate password";
            this.button_password.UseVisualStyleBackColor = true;
            this.button_password.Click += new System.EventHandler(this.button_password_Click_1);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(189, 336);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(103, 22);
            this.textBox_password.TabIndex = 33;
            // 
            // richText
            // 
            this.richText.Location = new System.Drawing.Point(391, 59);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(607, 258);
            this.richText.TabIndex = 32;
            this.richText.Text = "";
            // 
            // button_grid
            // 
            this.button_grid.Location = new System.Drawing.Point(79, 267);
            this.button_grid.Name = "button_grid";
            this.button_grid.Size = new System.Drawing.Size(159, 29);
            this.button_grid.TabIndex = 31;
            this.button_grid.Text = "Add to DataGrid";
            this.button_grid.UseVisualStyleBackColor = true;
            this.button_grid.Click += new System.EventHandler(this.button_grid_Click);
            // 
            // numeric_course
            // 
            this.numeric_course.Location = new System.Drawing.Point(148, 174);
            this.numeric_course.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_course.Name = "numeric_course";
            this.numeric_course.Size = new System.Drawing.Size(193, 22);
            this.numeric_course.TabIndex = 16;
            this.numeric_course.ThousandsSeparator = true;
            this.numeric_course.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(95, 217);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(121, 30);
            this.button_add.TabIndex = 14;
            this.button_add.Text = "Add student";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name Faculty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Record number";
            // 
            // textBox_faculty
            // 
            this.textBox_faculty.Location = new System.Drawing.Point(148, 136);
            this.textBox_faculty.Name = "textBox_faculty";
            this.textBox_faculty.Size = new System.Drawing.Size(193, 22);
            this.textBox_faculty.TabIndex = 3;
            // 
            // textBox_record
            // 
            this.textBox_record.Location = new System.Drawing.Point(148, 97);
            this.textBox_record.Name = "textBox_record";
            this.textBox_record.Size = new System.Drawing.Size(193, 22);
            this.textBox_record.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name and initials";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(148, 59);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(193, 22);
            this.textBox_name.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutTheProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.saveToolStripMenuItem.Text = "Save ";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // aboutTheProgramToolStripMenuItem
            // 
            this.aboutTheProgramToolStripMenuItem.Name = "aboutTheProgramToolStripMenuItem";
            this.aboutTheProgramToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.aboutTheProgramToolStripMenuItem.Text = "About the program";
            this.aboutTheProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutTheProgramToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1006, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View data";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.password);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.numeric_mark1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.textBox_teacher1);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.textBox_subject1);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1006, 390);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Edit";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(410, 18);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 33);
            this.password.TabIndex = 45;
            this.password.Text = "Enter";
            this.password.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(232, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 22);
            this.textBox4.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 17);
            this.label13.TabIndex = 43;
            this.label13.Text = "For edit data, input password";
            // 
            // numeric_mark1
            // 
            this.numeric_mark1.DecimalPlaces = 1;
            this.numeric_mark1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numeric_mark1.Location = new System.Drawing.Point(605, 224);
            this.numeric_mark1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_mark1.Name = "numeric_mark1";
            this.numeric_mark1.Size = new System.Drawing.Size(193, 22);
            this.numeric_mark1.TabIndex = 42;
            this.numeric_mark1.ThousandsSeparator = true;
            this.numeric_mark1.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(484, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Average marks";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(484, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Teachers";
            // 
            // textBox_teacher1
            // 
            this.textBox_teacher1.Location = new System.Drawing.Point(605, 184);
            this.textBox_teacher1.Name = "textBox_teacher1";
            this.textBox_teacher1.Size = new System.Drawing.Size(193, 22);
            this.textBox_teacher1.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(484, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "Subjects";
            // 
            // textBox_subject1
            // 
            this.textBox_subject1.Location = new System.Drawing.Point(605, 146);
            this.textBox_subject1.Name = "textBox_subject1";
            this.textBox_subject1.Size = new System.Drawing.Size(193, 22);
            this.textBox_subject1.TabIndex = 37;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(146, 263);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(193, 22);
            this.numericUpDown1.TabIndex = 24;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Number course";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Name Faculty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Record number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 22);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 22);
            this.textBox2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Name and initials";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(193, 22);
            this.textBox3.TabIndex = 17;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.richTextBox_search);
            this.tabPage3.Controls.Add(this.button_search);
            this.tabPage3.Controls.Add(this.textBox_search);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1006, 390);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Search";
            // 
            // richTextBox_search
            // 
            this.richTextBox_search.Location = new System.Drawing.Point(27, 73);
            this.richTextBox_search.Name = "richTextBox_search";
            this.richTextBox_search.Size = new System.Drawing.Size(590, 309);
            this.richTextBox_search.TabIndex = 3;
            this.richTextBox_search.Text = "";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(515, 17);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(102, 29);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(352, 20);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(144, 22);
            this.textBox_search.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "For search, please enter number record student";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage5.Controls.Add(this.button_discipline);
            this.tabPage5.Controls.Add(this.button_dupes);
            this.tabPage5.Controls.Add(this.button_thebest);
            this.tabPage5.Controls.Add(this.richTextInformation);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1006, 390);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Show information";
            // 
            // button_discipline
            // 
            this.button_discipline.Location = new System.Drawing.Point(28, 113);
            this.button_discipline.Name = "button_discipline";
            this.button_discipline.Size = new System.Drawing.Size(242, 31);
            this.button_discipline.TabIndex = 3;
            this.button_discipline.Text = "Discipline on which more twos";
            this.button_discipline.UseVisualStyleBackColor = true;
            // 
            // button_dupes
            // 
            this.button_dupes.Location = new System.Drawing.Point(28, 65);
            this.button_dupes.Name = "button_dupes";
            this.button_dupes.Size = new System.Drawing.Size(242, 31);
            this.button_dupes.TabIndex = 2;
            this.button_dupes.Text = "View dupes";
            this.button_dupes.UseVisualStyleBackColor = true;
            this.button_dupes.Click += new System.EventHandler(this.button_dupes_Click);
            // 
            // button_thebest
            // 
            this.button_thebest.Location = new System.Drawing.Point(28, 15);
            this.button_thebest.Name = "button_thebest";
            this.button_thebest.Size = new System.Drawing.Size(242, 31);
            this.button_thebest.TabIndex = 1;
            this.button_thebest.Text = "See the best students ";
            this.button_thebest.UseVisualStyleBackColor = true;
            this.button_thebest.Click += new System.EventHandler(this.button_thebest_Click);
            // 
            // richTextInformation
            // 
            this.richTextInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextInformation.Location = new System.Drawing.Point(3, 164);
            this.richTextInformation.Name = "richTextInformation";
            this.richTextInformation.Size = new System.Drawing.Size(1000, 223);
            this.richTextInformation.TabIndex = 0;
            this.richTextInformation.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.txt)|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 419);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Database students";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Create.ResumeLayout(false);
            this.Create.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_course)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_mark1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage Create;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox_faculty;
        private System.Windows.Forms.TextBox textBox_record;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Record_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_course;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark5;
        private System.Windows.Forms.NumericUpDown numeric_course;
        private System.Windows.Forms.RichTextBox richTextInformation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button button_grid;
        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.RichTextBox richTextBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button password;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numeric_mark1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_teacher1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_subject1;
        private System.Windows.Forms.Button button_discipline;
        private System.Windows.Forms.Button button_dupes;
        private System.Windows.Forms.Button button_thebest;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgramToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

