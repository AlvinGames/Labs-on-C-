namespace Task_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.middleName = new System.Windows.Forms.TextBox();
            this.t_surname = new System.Windows.Forms.Label();
            this.t_name = new System.Windows.Forms.Label();
            this.t_middleName = new System.Windows.Forms.Label();
            this.man = new System.Windows.Forms.RadioButton();
            this.woman = new System.Windows.Forms.RadioButton();
            this.day = new System.Windows.Forms.ComboBox();
            this.month = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.ComboBox();
            this.t_day = new System.Windows.Forms.Label();
            this.t_month = new System.Windows.Forms.Label();
            this.t_year = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.t_address = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.t_email = new System.Windows.Forms.Label();
            this.mobileOperator = new System.Windows.Forms.ComboBox();
            this.t_mobilePhone = new System.Windows.Forms.Label();
            this.mobilePhone = new System.Windows.Forms.TextBox();
            this.st1 = new System.Windows.Forms.RadioButton();
            this.st2 = new System.Windows.Forms.RadioButton();
            this.st3 = new System.Windows.Forms.RadioButton();
            this.st4 = new System.Windows.Forms.RadioButton();
            this.st5 = new System.Windows.Forms.RadioButton();
            this.transport = new System.Windows.Forms.CheckBox();
            this.certificate = new System.Windows.Forms.CheckBox();
            this.categoryA = new System.Windows.Forms.CheckBox();
            this.categoryB = new System.Windows.Forms.CheckBox();
            this.categoryC = new System.Windows.Forms.CheckBox();
            this.categoryD = new System.Windows.Forms.CheckBox();
            this.minSalary = new System.Windows.Forms.NumericUpDown();
            this.maxSalary = new System.Windows.Forms.NumericUpDown();
            this.resume = new System.Windows.Forms.RichTextBox();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.t_gender = new System.Windows.Forms.GroupBox();
            this.t_date = new System.Windows.Forms.GroupBox();
            this.t_experience = new System.Windows.Forms.GroupBox();
            this.t_salary = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t_more = new System.Windows.Forms.GroupBox();
            this.t_category = new System.Windows.Forms.Label();
            this.t_resume = new System.Windows.Forms.Label();
            this.t_graphic = new System.Windows.Forms.GroupBox();
            this.gr4 = new System.Windows.Forms.RadioButton();
            this.gr3 = new System.Windows.Forms.RadioButton();
            this.gr2 = new System.Windows.Forms.RadioButton();
            this.gr1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.minSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSalary)).BeginInit();
            this.t_gender.SuspendLayout();
            this.t_date.SuspendLayout();
            this.t_experience.SuspendLayout();
            this.t_salary.SuspendLayout();
            this.t_more.SuspendLayout();
            this.t_graphic.SuspendLayout();
            this.SuspendLayout();
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(108, 30);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(326, 20);
            this.surname.TabIndex = 0;
            this.surname.TextChanged += new System.EventHandler(this.surname_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(108, 57);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(326, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // middleName
            // 
            this.middleName.Location = new System.Drawing.Point(108, 83);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(326, 20);
            this.middleName.TabIndex = 2;
            this.middleName.TextChanged += new System.EventHandler(this.middleName_TextChanged);
            // 
            // t_surname
            // 
            this.t_surname.AutoSize = true;
            this.t_surname.ForeColor = System.Drawing.Color.Blue;
            this.t_surname.Location = new System.Drawing.Point(43, 33);
            this.t_surname.Name = "t_surname";
            this.t_surname.Size = new System.Drawing.Size(59, 13);
            this.t_surname.TabIndex = 3;
            this.t_surname.Text = "Фамилия:";
            // 
            // t_name
            // 
            this.t_name.AutoSize = true;
            this.t_name.Location = new System.Drawing.Point(70, 60);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(32, 13);
            this.t_name.TabIndex = 4;
            this.t_name.Text = "Имя:";
            // 
            // t_middleName
            // 
            this.t_middleName.AutoSize = true;
            this.t_middleName.Location = new System.Drawing.Point(45, 86);
            this.t_middleName.Name = "t_middleName";
            this.t_middleName.Size = new System.Drawing.Size(57, 13);
            this.t_middleName.TabIndex = 5;
            this.t_middleName.Text = "Отчество:";
            // 
            // man
            // 
            this.man.AutoSize = true;
            this.man.Checked = true;
            this.man.ForeColor = System.Drawing.SystemColors.ControlText;
            this.man.Location = new System.Drawing.Point(6, 27);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(71, 17);
            this.man.TabIndex = 6;
            this.man.TabStop = true;
            this.man.Text = "Мужской";
            this.man.UseVisualStyleBackColor = true;
            // 
            // woman
            // 
            this.woman.AutoSize = true;
            this.woman.ForeColor = System.Drawing.SystemColors.ControlText;
            this.woman.Location = new System.Drawing.Point(6, 50);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(72, 17);
            this.woman.TabIndex = 7;
            this.woman.Text = "Женский";
            this.woman.UseVisualStyleBackColor = true;
            // 
            // day
            // 
            this.day.DropDownHeight = 100;
            this.day.FormattingEnabled = true;
            this.day.IntegralHeight = false;
            this.day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.day.Location = new System.Drawing.Point(24, 35);
            this.day.Name = "day";
            this.day.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.day.Size = new System.Drawing.Size(82, 21);
            this.day.TabIndex = 8;
            this.day.Text = "1";
            // 
            // month
            // 
            this.month.FormattingEnabled = true;
            this.month.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.month.Location = new System.Drawing.Point(112, 35);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(273, 21);
            this.month.TabIndex = 9;
            this.month.Text = "Январь";
            // 
            // year
            // 
            this.year.DropDownHeight = 100;
            this.year.FormattingEnabled = true;
            this.year.IntegralHeight = false;
            this.year.Items.AddRange(new object[] {
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.year.Location = new System.Drawing.Point(391, 35);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(121, 21);
            this.year.TabIndex = 10;
            this.year.Text = "2010";
            // 
            // t_day
            // 
            this.t_day.AutoSize = true;
            this.t_day.ForeColor = System.Drawing.SystemColors.Desktop;
            this.t_day.Location = new System.Drawing.Point(24, 16);
            this.t_day.Name = "t_day";
            this.t_day.Size = new System.Drawing.Size(34, 13);
            this.t_day.TabIndex = 11;
            this.t_day.Text = "День";
            // 
            // t_month
            // 
            this.t_month.AutoSize = true;
            this.t_month.ForeColor = System.Drawing.SystemColors.ControlText;
            this.t_month.Location = new System.Drawing.Point(112, 15);
            this.t_month.Name = "t_month";
            this.t_month.Size = new System.Drawing.Size(40, 13);
            this.t_month.TabIndex = 12;
            this.t_month.Text = "Месяц";
            // 
            // t_year
            // 
            this.t_year.AutoSize = true;
            this.t_year.ForeColor = System.Drawing.SystemColors.ControlText;
            this.t_year.Location = new System.Drawing.Point(391, 16);
            this.t_year.Name = "t_year";
            this.t_year.Size = new System.Drawing.Size(25, 13);
            this.t_year.TabIndex = 13;
            this.t_year.Text = "Год";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(159, 181);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(413, 20);
            this.address.TabIndex = 14;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // t_address
            // 
            this.t_address.AutoSize = true;
            this.t_address.Location = new System.Drawing.Point(46, 184);
            this.t_address.Name = "t_address";
            this.t_address.Size = new System.Drawing.Size(107, 13);
            this.t_address.TabIndex = 15;
            this.t_address.Text = "Место проживания:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(194, 207);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(378, 20);
            this.email.TabIndex = 16;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // t_email
            // 
            this.t_email.AutoSize = true;
            this.t_email.Location = new System.Drawing.Point(46, 210);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(142, 13);
            this.t_email.TabIndex = 17;
            this.t_email.Text = "Адрес электронной почты:";
            // 
            // mobileOperator
            // 
            this.mobileOperator.FormattingEnabled = true;
            this.mobileOperator.Items.AddRange(new object[] {
            "MTS",
            "Velcom"});
            this.mobileOperator.Location = new System.Drawing.Point(167, 233);
            this.mobileOperator.Name = "mobileOperator";
            this.mobileOperator.Size = new System.Drawing.Size(85, 21);
            this.mobileOperator.TabIndex = 18;
            this.mobileOperator.Text = "MTS";
            // 
            // t_mobilePhone
            // 
            this.t_mobilePhone.AutoSize = true;
            this.t_mobilePhone.Location = new System.Drawing.Point(46, 236);
            this.t_mobilePhone.Name = "t_mobilePhone";
            this.t_mobilePhone.Size = new System.Drawing.Size(115, 13);
            this.t_mobilePhone.TabIndex = 19;
            this.t_mobilePhone.Text = "Мобильный телефон:";
            // 
            // mobilePhone
            // 
            this.mobilePhone.Location = new System.Drawing.Point(258, 233);
            this.mobilePhone.Name = "mobilePhone";
            this.mobilePhone.Size = new System.Drawing.Size(314, 20);
            this.mobilePhone.TabIndex = 20;
            this.mobilePhone.TextChanged += new System.EventHandler(this.mobilePhone_TextChanged);
            // 
            // st1
            // 
            this.st1.AutoSize = true;
            this.st1.Checked = true;
            this.st1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.st1.Location = new System.Drawing.Point(19, 19);
            this.st1.Name = "st1";
            this.st1.Size = new System.Drawing.Size(124, 17);
            this.st1.TabIndex = 21;
            this.st1.TabStop = true;
            this.st1.Text = "Прежде не работал";
            this.st1.UseVisualStyleBackColor = true;
            // 
            // st2
            // 
            this.st2.AutoSize = true;
            this.st2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.st2.Location = new System.Drawing.Point(19, 42);
            this.st2.Name = "st2";
            this.st2.Size = new System.Drawing.Size(101, 17);
            this.st2.TabIndex = 22;
            this.st2.Text = "Меньше 1 года";
            this.st2.UseVisualStyleBackColor = true;
            // 
            // st3
            // 
            this.st3.AutoSize = true;
            this.st3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.st3.Location = new System.Drawing.Point(201, 19);
            this.st3.Name = "st3";
            this.st3.Size = new System.Drawing.Size(97, 17);
            this.st3.TabIndex = 23;
            this.st3.Text = "От 1 года до 5";
            this.st3.UseVisualStyleBackColor = true;
            // 
            // st4
            // 
            this.st4.AutoSize = true;
            this.st4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.st4.Location = new System.Drawing.Point(201, 42);
            this.st4.Name = "st4";
            this.st4.Size = new System.Drawing.Size(91, 17);
            this.st4.TabIndex = 24;
            this.st4.Text = "От 5 до 9 лет";
            this.st4.UseVisualStyleBackColor = true;
            // 
            // st5
            // 
            this.st5.AutoSize = true;
            this.st5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.st5.Location = new System.Drawing.Point(361, 19);
            this.st5.Name = "st5";
            this.st5.Size = new System.Drawing.Size(107, 17);
            this.st5.TabIndex = 25;
            this.st5.Text = "10 лет и больше";
            this.st5.UseVisualStyleBackColor = true;
            // 
            // transport
            // 
            this.transport.AutoSize = true;
            this.transport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.transport.Location = new System.Drawing.Point(6, 19);
            this.transport.Name = "transport";
            this.transport.Size = new System.Drawing.Size(138, 17);
            this.transport.TabIndex = 26;
            this.transport.Text = "Наличие личного авто";
            this.transport.UseVisualStyleBackColor = true;
            // 
            // certificate
            // 
            this.certificate.AutoSize = true;
            this.certificate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.certificate.Location = new System.Drawing.Point(6, 42);
            this.certificate.Name = "certificate";
            this.certificate.Size = new System.Drawing.Size(177, 17);
            this.certificate.TabIndex = 27;
            this.certificate.Text = "Водительское удостоверение";
            this.certificate.UseVisualStyleBackColor = true;
            this.certificate.Click += new System.EventHandler(this.certificate_Click);
            // 
            // categoryA
            // 
            this.categoryA.AutoSize = true;
            this.categoryA.Checked = true;
            this.categoryA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.categoryA.Enabled = false;
            this.categoryA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.categoryA.Location = new System.Drawing.Point(6, 82);
            this.categoryA.Name = "categoryA";
            this.categoryA.Size = new System.Drawing.Size(33, 17);
            this.categoryA.TabIndex = 28;
            this.categoryA.Text = "A";
            this.categoryA.UseVisualStyleBackColor = true;
            this.categoryA.CheckedChanged += new System.EventHandler(this.categoryA_CheckedChanged);
            // 
            // categoryB
            // 
            this.categoryB.AutoSize = true;
            this.categoryB.Enabled = false;
            this.categoryB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.categoryB.Location = new System.Drawing.Point(45, 82);
            this.categoryB.Name = "categoryB";
            this.categoryB.Size = new System.Drawing.Size(33, 17);
            this.categoryB.TabIndex = 29;
            this.categoryB.Text = "B";
            this.categoryB.UseVisualStyleBackColor = true;
            this.categoryB.CheckedChanged += new System.EventHandler(this.categoryB_CheckedChanged);
            // 
            // categoryC
            // 
            this.categoryC.AutoSize = true;
            this.categoryC.Enabled = false;
            this.categoryC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.categoryC.Location = new System.Drawing.Point(84, 82);
            this.categoryC.Name = "categoryC";
            this.categoryC.Size = new System.Drawing.Size(33, 17);
            this.categoryC.TabIndex = 30;
            this.categoryC.Text = "C";
            this.categoryC.UseVisualStyleBackColor = true;
            this.categoryC.CheckedChanged += new System.EventHandler(this.categoryC_CheckedChanged);
            // 
            // categoryD
            // 
            this.categoryD.AutoSize = true;
            this.categoryD.Enabled = false;
            this.categoryD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.categoryD.Location = new System.Drawing.Point(123, 82);
            this.categoryD.Name = "categoryD";
            this.categoryD.Size = new System.Drawing.Size(34, 17);
            this.categoryD.TabIndex = 31;
            this.categoryD.Text = "D";
            this.categoryD.UseVisualStyleBackColor = true;
            this.categoryD.CheckedChanged += new System.EventHandler(this.categoryD_CheckedChanged);
            // 
            // minSalary
            // 
            this.minSalary.Location = new System.Drawing.Point(33, 18);
            this.minSalary.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.minSalary.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.minSalary.Name = "minSalary";
            this.minSalary.Size = new System.Drawing.Size(70, 20);
            this.minSalary.TabIndex = 32;
            this.minSalary.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.minSalary.Click += new System.EventHandler(this.minSalary_Click);
            // 
            // maxSalary
            // 
            this.maxSalary.Location = new System.Drawing.Point(137, 18);
            this.maxSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxSalary.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.maxSalary.Name = "maxSalary";
            this.maxSalary.Size = new System.Drawing.Size(75, 20);
            this.maxSalary.TabIndex = 33;
            this.maxSalary.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.maxSalary.Click += new System.EventHandler(this.maxSalary_Click);
            // 
            // resume
            // 
            this.resume.Location = new System.Drawing.Point(49, 542);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(527, 103);
            this.resume.TabIndex = 34;
            this.resume.Text = "";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(259, 651);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(120, 23);
            this.save.TabIndex = 35;
            this.save.Text = "Сохранить данные";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(385, 651);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(110, 23);
            this.clear.TabIndex = 36;
            this.clear.Text = "Очистить форму";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(501, 651);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 37;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // t_gender
            // 
            this.t_gender.Controls.Add(this.man);
            this.t_gender.Controls.Add(this.woman);
            this.t_gender.ForeColor = System.Drawing.Color.Blue;
            this.t_gender.Location = new System.Drawing.Point(440, 30);
            this.t_gender.Name = "t_gender";
            this.t_gender.Size = new System.Drawing.Size(132, 73);
            this.t_gender.TabIndex = 38;
            this.t_gender.TabStop = false;
            this.t_gender.Text = "Пол";
            // 
            // t_date
            // 
            this.t_date.Controls.Add(this.t_year);
            this.t_date.Controls.Add(this.t_month);
            this.t_date.Controls.Add(this.t_day);
            this.t_date.Controls.Add(this.year);
            this.t_date.Controls.Add(this.month);
            this.t_date.Controls.Add(this.day);
            this.t_date.ForeColor = System.Drawing.Color.Blue;
            this.t_date.Location = new System.Drawing.Point(49, 109);
            this.t_date.Name = "t_date";
            this.t_date.Size = new System.Drawing.Size(523, 66);
            this.t_date.TabIndex = 39;
            this.t_date.TabStop = false;
            this.t_date.Text = "Дата рождения";
            // 
            // t_experience
            // 
            this.t_experience.Controls.Add(this.st5);
            this.t_experience.Controls.Add(this.st4);
            this.t_experience.Controls.Add(this.st3);
            this.t_experience.Controls.Add(this.st2);
            this.t_experience.Controls.Add(this.st1);
            this.t_experience.ForeColor = System.Drawing.Color.Blue;
            this.t_experience.Location = new System.Drawing.Point(49, 260);
            this.t_experience.Name = "t_experience";
            this.t_experience.Size = new System.Drawing.Size(523, 68);
            this.t_experience.TabIndex = 40;
            this.t_experience.TabStop = false;
            this.t_experience.Text = "Опыт работы:";
            // 
            // t_salary
            // 
            this.t_salary.Controls.Add(this.label2);
            this.t_salary.Controls.Add(this.label1);
            this.t_salary.Controls.Add(this.minSalary);
            this.t_salary.Controls.Add(this.maxSalary);
            this.t_salary.ForeColor = System.Drawing.Color.Blue;
            this.t_salary.Location = new System.Drawing.Point(250, 409);
            this.t_salary.Name = "t_salary";
            this.t_salary.Size = new System.Drawing.Size(221, 68);
            this.t_salary.TabIndex = 41;
            this.t_salary.TabStop = false;
            this.t_salary.Text = "Объём заработной платы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(109, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "До";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "От";
            // 
            // t_more
            // 
            this.t_more.Controls.Add(this.t_category);
            this.t_more.Controls.Add(this.transport);
            this.t_more.Controls.Add(this.certificate);
            this.t_more.Controls.Add(this.categoryA);
            this.t_more.Controls.Add(this.categoryB);
            this.t_more.Controls.Add(this.categoryC);
            this.t_more.Controls.Add(this.categoryD);
            this.t_more.ForeColor = System.Drawing.Color.Blue;
            this.t_more.Location = new System.Drawing.Point(49, 409);
            this.t_more.Name = "t_more";
            this.t_more.Size = new System.Drawing.Size(195, 105);
            this.t_more.TabIndex = 42;
            this.t_more.TabStop = false;
            this.t_more.Text = "Другие сведения";
            // 
            // t_category
            // 
            this.t_category.AutoSize = true;
            this.t_category.ForeColor = System.Drawing.SystemColors.ControlText;
            this.t_category.Location = new System.Drawing.Point(7, 66);
            this.t_category.Name = "t_category";
            this.t_category.Size = new System.Drawing.Size(90, 13);
            this.t_category.TabIndex = 28;
            this.t_category.Text = "Категория прав:";
            // 
            // t_resume
            // 
            this.t_resume.AutoSize = true;
            this.t_resume.Location = new System.Drawing.Point(46, 526);
            this.t_resume.Name = "t_resume";
            this.t_resume.Size = new System.Drawing.Size(95, 13);
            this.t_resume.TabIndex = 44;
            this.t_resume.Text = "Краткое резюме:";
            // 
            // t_graphic
            // 
            this.t_graphic.Controls.Add(this.gr4);
            this.t_graphic.Controls.Add(this.gr3);
            this.t_graphic.Controls.Add(this.gr2);
            this.t_graphic.Controls.Add(this.gr1);
            this.t_graphic.ForeColor = System.Drawing.Color.Blue;
            this.t_graphic.Location = new System.Drawing.Point(49, 334);
            this.t_graphic.Name = "t_graphic";
            this.t_graphic.Size = new System.Drawing.Size(523, 69);
            this.t_graphic.TabIndex = 45;
            this.t_graphic.TabStop = false;
            this.t_graphic.Text = "Предпочитаемый график работы";
            // 
            // gr4
            // 
            this.gr4.AutoSize = true;
            this.gr4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gr4.Location = new System.Drawing.Point(209, 44);
            this.gr4.Name = "gr4";
            this.gr4.Size = new System.Drawing.Size(121, 17);
            this.gr4.TabIndex = 3;
            this.gr4.Text = "Посменная работа";
            this.gr4.UseVisualStyleBackColor = true;
            // 
            // gr3
            // 
            this.gr3.AutoSize = true;
            this.gr3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gr3.Location = new System.Drawing.Point(209, 20);
            this.gr3.Name = "gr3";
            this.gr3.Size = new System.Drawing.Size(104, 17);
            this.gr3.TabIndex = 2;
            this.gr3.Text = "Работа на дому";
            this.gr3.UseVisualStyleBackColor = true;
            // 
            // gr2
            // 
            this.gr2.AutoSize = true;
            this.gr2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gr2.Location = new System.Drawing.Point(10, 44);
            this.gr2.Name = "gr2";
            this.gr2.Size = new System.Drawing.Size(134, 17);
            this.gr2.TabIndex = 1;
            this.gr2.Text = "Частичная занятость";
            this.gr2.UseVisualStyleBackColor = true;
            // 
            // gr1
            // 
            this.gr1.AutoSize = true;
            this.gr1.Checked = true;
            this.gr1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gr1.Location = new System.Drawing.Point(10, 20);
            this.gr1.Name = "gr1";
            this.gr1.Size = new System.Drawing.Size(118, 17);
            this.gr1.TabIndex = 0;
            this.gr1.TabStop = true;
            this.gr1.Text = "Полная занятость";
            this.gr1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 686);
            this.Controls.Add(this.t_graphic);
            this.Controls.Add(this.t_resume);
            this.Controls.Add(this.t_more);
            this.Controls.Add(this.t_salary);
            this.Controls.Add(this.t_experience);
            this.Controls.Add(this.t_date);
            this.Controls.Add(this.t_gender);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.mobilePhone);
            this.Controls.Add(this.t_mobilePhone);
            this.Controls.Add(this.mobileOperator);
            this.Controls.Add(this.t_email);
            this.Controls.Add(this.email);
            this.Controls.Add(this.t_address);
            this.Controls.Add(this.address);
            this.Controls.Add(this.t_middleName);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.t_surname);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Анкетные данные сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.minSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSalary)).EndInit();
            this.t_gender.ResumeLayout(false);
            this.t_gender.PerformLayout();
            this.t_date.ResumeLayout(false);
            this.t_date.PerformLayout();
            this.t_experience.ResumeLayout(false);
            this.t_experience.PerformLayout();
            this.t_salary.ResumeLayout(false);
            this.t_salary.PerformLayout();
            this.t_more.ResumeLayout(false);
            this.t_more.PerformLayout();
            this.t_graphic.ResumeLayout(false);
            this.t_graphic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox middleName;
        private System.Windows.Forms.Label t_surname;
        private System.Windows.Forms.Label t_name;
        private System.Windows.Forms.Label t_middleName;
        private System.Windows.Forms.RadioButton man;
        private System.Windows.Forms.RadioButton woman;
        private System.Windows.Forms.ComboBox day;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.Label t_day;
        private System.Windows.Forms.Label t_month;
        private System.Windows.Forms.Label t_year;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label t_address;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label t_email;
        private System.Windows.Forms.ComboBox mobileOperator;
        private System.Windows.Forms.Label t_mobilePhone;
        private System.Windows.Forms.TextBox mobilePhone;
        private System.Windows.Forms.RadioButton st1;
        private System.Windows.Forms.RadioButton st2;
        private System.Windows.Forms.RadioButton st3;
        private System.Windows.Forms.RadioButton st4;
        private System.Windows.Forms.RadioButton st5;
        private System.Windows.Forms.CheckBox transport;
        private System.Windows.Forms.CheckBox certificate;
        private System.Windows.Forms.CheckBox categoryA;
        private System.Windows.Forms.CheckBox categoryB;
        private System.Windows.Forms.CheckBox categoryC;
        private System.Windows.Forms.CheckBox categoryD;
        private System.Windows.Forms.NumericUpDown minSalary;
        private System.Windows.Forms.NumericUpDown maxSalary;
        private System.Windows.Forms.RichTextBox resume;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.GroupBox t_gender;
        private System.Windows.Forms.GroupBox t_date;
        private System.Windows.Forms.GroupBox t_experience;
        private System.Windows.Forms.GroupBox t_salary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox t_more;
        private System.Windows.Forms.Label t_category;
        private System.Windows.Forms.Label t_resume;
        private System.Windows.Forms.GroupBox t_graphic;
        private System.Windows.Forms.RadioButton gr4;
        private System.Windows.Forms.RadioButton gr3;
        private System.Windows.Forms.RadioButton gr2;
        private System.Windows.Forms.RadioButton gr1;
        private System.Windows.Forms.ComboBox month;
    }
}

