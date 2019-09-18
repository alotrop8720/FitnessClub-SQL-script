namespace FitnessClub
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PageTimeTable = new System.Windows.Forms.TabPage();
            this.bttAddVisit = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.labelRoom = new System.Windows.Forms.Label();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.GridViewTimeTable = new System.Windows.Forms.DataGridView();
            this.DBTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Понедельник = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вторник = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Среда = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Четверг = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пятница = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Суббота = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectDate = new System.Windows.Forms.DateTimePicker();
            this.PageCustomer = new System.Windows.Forms.TabPage();
            this.bttDeleteCustomer = new System.Windows.Forms.Button();
            this.bttAddCustomer = new System.Windows.Forms.Button();
            this.labelCustomerSearch = new System.Windows.Forms.Label();
            this.tbCustomerSearch = new System.Windows.Forms.TextBox();
            this.GridViewСustomers = new System.Windows.Forms.DataGridView();
            this.PageClasses = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.PageService = new System.Windows.Forms.TabPage();
            this.bttDeleteService = new System.Windows.Forms.Button();
            this.bttAddService = new System.Windows.Forms.Button();
            this.GridViewService = new System.Windows.Forms.DataGridView();
            this.PageGroups = new System.Windows.Forms.TabPage();
            this.GridViewGroups = new System.Windows.Forms.DataGridView();
            this.bttAddGroups = new System.Windows.Forms.Button();
            this.labelGroupsSearch = new System.Windows.Forms.Label();
            this.tbGroupsSearch = new System.Windows.Forms.TextBox();
            this.PageRecordGroup = new System.Windows.Forms.TabPage();
            this.bttDeleteRecord = new System.Windows.Forms.Button();
            this.bttAddRecordGroups = new System.Windows.Forms.Button();
            this.tbRecordGroupsSearch = new System.Windows.Forms.TextBox();
            this.labelRecordGroupsSearch = new System.Windows.Forms.Label();
            this.GridViewRecordGroups = new System.Windows.Forms.DataGridView();
            this.PageVisitGroup = new System.Windows.Forms.TabPage();
            this.bttDeleteVisit = new System.Windows.Forms.Button();
            this.tbVisitGroupSearch = new System.Windows.Forms.TextBox();
            this.labelVisitGroupSearch = new System.Windows.Forms.Label();
            this.GridViewVisitGroup = new System.Windows.Forms.DataGridView();
            this.PageWorker = new System.Windows.Forms.TabPage();
            this.bttDeleteWorker = new System.Windows.Forms.Button();
            this.bttAddWorker = new System.Windows.Forms.Button();
            this.tbWorkerSearch = new System.Windows.Forms.TextBox();
            this.labelWorkerSearch = new System.Windows.Forms.Label();
            this.GridViewWorker = new System.Windows.Forms.DataGridView();
            this.bttReportVisit = new System.Windows.Forms.Button();
            this.bttGroupReport = new System.Windows.Forms.Button();
            this.bttWorkerReport = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.PageTimeTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTimeTable)).BeginInit();
            this.PageCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewСustomers)).BeginInit();
            this.PageClasses.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.PageService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewService)).BeginInit();
            this.PageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGroups)).BeginInit();
            this.PageRecordGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRecordGroups)).BeginInit();
            this.PageVisitGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitGroup)).BeginInit();
            this.PageWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.PageTimeTable);
            this.tabControl1.Controls.Add(this.PageCustomer);
            this.tabControl1.Controls.Add(this.PageClasses);
            this.tabControl1.Controls.Add(this.PageWorker);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(972, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // PageTimeTable
            // 
            this.PageTimeTable.Controls.Add(this.bttAddVisit);
            this.PageTimeTable.Controls.Add(this.bttDelete);
            this.PageTimeTable.Controls.Add(this.labelRoom);
            this.PageTimeTable.Controls.Add(this.cbRoom);
            this.PageTimeTable.Controls.Add(this.GridViewTimeTable);
            this.PageTimeTable.Controls.Add(this.SelectDate);
            this.PageTimeTable.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTimeTable.Location = new System.Drawing.Point(4, 4);
            this.PageTimeTable.Name = "PageTimeTable";
            this.PageTimeTable.Padding = new System.Windows.Forms.Padding(3);
            this.PageTimeTable.Size = new System.Drawing.Size(964, 564);
            this.PageTimeTable.TabIndex = 0;
            this.PageTimeTable.Text = "Расписание";
            this.PageTimeTable.UseVisualStyleBackColor = true;
            // 
            // bttAddVisit
            // 
            this.bttAddVisit.Location = new System.Drawing.Point(795, 16);
            this.bttAddVisit.Name = "bttAddVisit";
            this.bttAddVisit.Size = new System.Drawing.Size(123, 29);
            this.bttAddVisit.TabIndex = 6;
            this.bttAddVisit.Text = "Отметить";
            this.bttAddVisit.UseVisualStyleBackColor = true;
            this.bttAddVisit.Click += new System.EventHandler(this.bttAddVisit_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Image = global::FitnessClub.Properties.Resources.deleteBox;
            this.bttDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttDelete.Location = new System.Drawing.Point(924, 16);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(35, 29);
            this.bttDelete.TabIndex = 5;
            this.bttDelete.UseVisualStyleBackColor = true;
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoom.Location = new System.Drawing.Point(199, 23);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(43, 21);
            this.labelRoom.TabIndex = 4;
            this.labelRoom.Text = "Зал:";
            // 
            // cbRoom
            // 
            this.cbRoom.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Items.AddRange(new object[] {
            "Фитнес зал",
            "Аэробика",
            "Басеин",
            "Тренажерный зал",
            "Зал йоги",
            "Танцевальный зал",
            "Гимнастический зал"});
            this.cbRoom.Location = new System.Drawing.Point(248, 20);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(228, 29);
            this.cbRoom.TabIndex = 3;
            this.cbRoom.TextChanged += new System.EventHandler(this.SelectDate_ValueChanged);
            this.cbRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbRoom_KeyPress);
            // 
            // GridViewTimeTable
            // 
            this.GridViewTimeTable.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.GridViewTimeTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridViewTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewTimeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DBTime,
            this.Понедельник,
            this.Вторник,
            this.Среда,
            this.Четверг,
            this.Пятница,
            this.Суббота});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewTimeTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewTimeTable.EnableHeadersVisualStyles = false;
            this.GridViewTimeTable.Location = new System.Drawing.Point(8, 52);
            this.GridViewTimeTable.Margin = new System.Windows.Forms.Padding(0);
            this.GridViewTimeTable.Name = "GridViewTimeTable";
            this.GridViewTimeTable.ReadOnly = true;
            this.GridViewTimeTable.Size = new System.Drawing.Size(956, 509);
            this.GridViewTimeTable.TabIndex = 2;
            this.GridViewTimeTable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridViewTimeTable_KeyPress);
            // 
            // DBTime
            // 
            this.DBTime.HeaderText = "Время";
            this.DBTime.Name = "DBTime";
            this.DBTime.ReadOnly = true;
            this.DBTime.Width = 84;
            // 
            // Понедельник
            // 
            this.Понедельник.HeaderText = "Понедельник";
            this.Понедельник.Name = "Понедельник";
            this.Понедельник.ReadOnly = true;
            this.Понедельник.Width = 135;
            // 
            // Вторник
            // 
            this.Вторник.HeaderText = "Вторник";
            this.Вторник.Name = "Вторник";
            this.Вторник.ReadOnly = true;
            this.Вторник.Width = 135;
            // 
            // Среда
            // 
            this.Среда.HeaderText = "Среда";
            this.Среда.Name = "Среда";
            this.Среда.ReadOnly = true;
            this.Среда.Width = 135;
            // 
            // Четверг
            // 
            this.Четверг.HeaderText = "Четверг";
            this.Четверг.Name = "Четверг";
            this.Четверг.ReadOnly = true;
            this.Четверг.Width = 135;
            // 
            // Пятница
            // 
            this.Пятница.HeaderText = "Пятница";
            this.Пятница.Name = "Пятница";
            this.Пятница.ReadOnly = true;
            this.Пятница.Width = 135;
            // 
            // Суббота
            // 
            this.Суббота.HeaderText = "Суббота";
            this.Суббота.Name = "Суббота";
            this.Суббота.ReadOnly = true;
            this.Суббота.Width = 135;
            // 
            // SelectDate
            // 
            this.SelectDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDate.Location = new System.Drawing.Point(8, 20);
            this.SelectDate.Name = "SelectDate";
            this.SelectDate.Size = new System.Drawing.Size(165, 28);
            this.SelectDate.TabIndex = 1;
            this.SelectDate.ValueChanged += new System.EventHandler(this.SelectDate_ValueChanged);
            // 
            // PageCustomer
            // 
            this.PageCustomer.Controls.Add(this.bttDeleteCustomer);
            this.PageCustomer.Controls.Add(this.bttAddCustomer);
            this.PageCustomer.Controls.Add(this.labelCustomerSearch);
            this.PageCustomer.Controls.Add(this.tbCustomerSearch);
            this.PageCustomer.Controls.Add(this.GridViewСustomers);
            this.PageCustomer.Location = new System.Drawing.Point(4, 4);
            this.PageCustomer.Name = "PageCustomer";
            this.PageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.PageCustomer.Size = new System.Drawing.Size(964, 564);
            this.PageCustomer.TabIndex = 1;
            this.PageCustomer.Text = "Клиенты";
            this.PageCustomer.UseVisualStyleBackColor = true;
            // 
            // bttDeleteCustomer
            // 
            this.bttDeleteCustomer.Image = global::FitnessClub.Properties.Resources.deleteBox;
            this.bttDeleteCustomer.Location = new System.Drawing.Point(744, 20);
            this.bttDeleteCustomer.Name = "bttDeleteCustomer";
            this.bttDeleteCustomer.Size = new System.Drawing.Size(35, 29);
            this.bttDeleteCustomer.TabIndex = 4;
            this.bttDeleteCustomer.UseVisualStyleBackColor = true;
            this.bttDeleteCustomer.Click += new System.EventHandler(this.bttDeleteCustomer_Click);
            // 
            // bttAddCustomer
            // 
            this.bttAddCustomer.Location = new System.Drawing.Point(785, 20);
            this.bttAddCustomer.Name = "bttAddCustomer";
            this.bttAddCustomer.Size = new System.Drawing.Size(176, 29);
            this.bttAddCustomer.TabIndex = 3;
            this.bttAddCustomer.Text = "Новый клиент";
            this.bttAddCustomer.UseVisualStyleBackColor = true;
            this.bttAddCustomer.Click += new System.EventHandler(this.bttAddCustomer_Click);
            // 
            // labelCustomerSearch
            // 
            this.labelCustomerSearch.AutoSize = true;
            this.labelCustomerSearch.Location = new System.Drawing.Point(8, 23);
            this.labelCustomerSearch.Name = "labelCustomerSearch";
            this.labelCustomerSearch.Size = new System.Drawing.Size(59, 21);
            this.labelCustomerSearch.TabIndex = 2;
            this.labelCustomerSearch.Text = "Поиск:";
            // 
            // tbCustomerSearch
            // 
            this.tbCustomerSearch.Location = new System.Drawing.Point(68, 20);
            this.tbCustomerSearch.Name = "tbCustomerSearch";
            this.tbCustomerSearch.Size = new System.Drawing.Size(165, 28);
            this.tbCustomerSearch.TabIndex = 1;
            this.tbCustomerSearch.TextChanged += new System.EventHandler(this.tbCustomerSearch_TextChanged);
            // 
            // GridViewСustomers
            // 
            this.GridViewСustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewСustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewСustomers.Location = new System.Drawing.Point(8, 52);
            this.GridViewСustomers.Name = "GridViewСustomers";
            this.GridViewСustomers.ReadOnly = true;
            this.GridViewСustomers.Size = new System.Drawing.Size(956, 509);
            this.GridViewСustomers.TabIndex = 0;
            this.GridViewСustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewСustomers_CellContentClick);
            this.GridViewСustomers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridViewTimeTable_KeyPress);
            // 
            // PageClasses
            // 
            this.PageClasses.Controls.Add(this.tabControl2);
            this.PageClasses.Location = new System.Drawing.Point(4, 4);
            this.PageClasses.Name = "PageClasses";
            this.PageClasses.Size = new System.Drawing.Size(964, 564);
            this.PageClasses.TabIndex = 2;
            this.PageClasses.Text = "Занятия";
            this.PageClasses.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl2.Controls.Add(this.PageService);
            this.tabControl2.Controls.Add(this.PageGroups);
            this.tabControl2.Controls.Add(this.PageRecordGroup);
            this.tabControl2.Controls.Add(this.PageVisitGroup);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(964, 564);
            this.tabControl2.TabIndex = 4;
            // 
            // PageService
            // 
            this.PageService.Controls.Add(this.bttDeleteService);
            this.PageService.Controls.Add(this.bttAddService);
            this.PageService.Controls.Add(this.GridViewService);
            this.PageService.Location = new System.Drawing.Point(4, 4);
            this.PageService.Name = "PageService";
            this.PageService.Size = new System.Drawing.Size(956, 530);
            this.PageService.TabIndex = 3;
            this.PageService.Text = "Услуги";
            this.PageService.UseVisualStyleBackColor = true;
            // 
            // bttDeleteService
            // 
            this.bttDeleteService.Image = global::FitnessClub.Properties.Resources.deleteBox;
            this.bttDeleteService.Location = new System.Drawing.Point(734, 23);
            this.bttDeleteService.Name = "bttDeleteService";
            this.bttDeleteService.Size = new System.Drawing.Size(35, 29);
            this.bttDeleteService.TabIndex = 2;
            this.bttDeleteService.UseVisualStyleBackColor = true;
            this.bttDeleteService.Click += new System.EventHandler(this.bttDeleteService_Click);
            // 
            // bttAddService
            // 
            this.bttAddService.Location = new System.Drawing.Point(775, 23);
            this.bttAddService.Name = "bttAddService";
            this.bttAddService.Size = new System.Drawing.Size(176, 29);
            this.bttAddService.TabIndex = 1;
            this.bttAddService.Text = "Новая Услуга";
            this.bttAddService.UseVisualStyleBackColor = true;
            this.bttAddService.Click += new System.EventHandler(this.bttAddService_Click);
            // 
            // GridViewService
            // 
            this.GridViewService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewService.Location = new System.Drawing.Point(24, 58);
            this.GridViewService.Name = "GridViewService";
            this.GridViewService.ReadOnly = true;
            this.GridViewService.Size = new System.Drawing.Size(928, 448);
            this.GridViewService.TabIndex = 0;
            this.GridViewService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridViewTimeTable_KeyPress);
            // 
            // PageGroups
            // 
            this.PageGroups.Controls.Add(this.bttGroupReport);
            this.PageGroups.Controls.Add(this.GridViewGroups);
            this.PageGroups.Controls.Add(this.bttAddGroups);
            this.PageGroups.Controls.Add(this.labelGroupsSearch);
            this.PageGroups.Controls.Add(this.tbGroupsSearch);
            this.PageGroups.Location = new System.Drawing.Point(4, 4);
            this.PageGroups.Name = "PageGroups";
            this.PageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.PageGroups.Size = new System.Drawing.Size(956, 530);
            this.PageGroups.TabIndex = 0;
            this.PageGroups.Text = "Группы";
            this.PageGroups.UseVisualStyleBackColor = true;
            // 
            // GridViewGroups
            // 
            this.GridViewGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewGroups.Location = new System.Drawing.Point(24, 58);
            this.GridViewGroups.Name = "GridViewGroups";
            this.GridViewGroups.ReadOnly = true;
            this.GridViewGroups.Size = new System.Drawing.Size(928, 448);
            this.GridViewGroups.TabIndex = 0;
            this.GridViewGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewGroups_CellContentClick);
            this.GridViewGroups.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridViewTimeTable_KeyPress);
            // 
            // bttAddGroups
            // 
            this.bttAddGroups.Location = new System.Drawing.Point(776, 23);
            this.bttAddGroups.Name = "bttAddGroups";
            this.bttAddGroups.Size = new System.Drawing.Size(176, 29);
            this.bttAddGroups.TabIndex = 1;
            this.bttAddGroups.Text = "Новая группа";
            this.bttAddGroups.UseVisualStyleBackColor = true;
            this.bttAddGroups.Click += new System.EventHandler(this.bttAddGroups_Click);
            // 
            // labelGroupsSearch
            // 
            this.labelGroupsSearch.AutoSize = true;
            this.labelGroupsSearch.Location = new System.Drawing.Point(20, 27);
            this.labelGroupsSearch.Name = "labelGroupsSearch";
            this.labelGroupsSearch.Size = new System.Drawing.Size(59, 21);
            this.labelGroupsSearch.TabIndex = 3;
            this.labelGroupsSearch.Text = "Поиск:";
            // 
            // tbGroupsSearch
            // 
            this.tbGroupsSearch.Location = new System.Drawing.Point(85, 24);
            this.tbGroupsSearch.Name = "tbGroupsSearch";
            this.tbGroupsSearch.Size = new System.Drawing.Size(165, 28);
            this.tbGroupsSearch.TabIndex = 2;
            this.tbGroupsSearch.TextChanged += new System.EventHandler(this.tbGroupsSearch_TextChanged);
            // 
            // PageRecordGroup
            // 
            this.PageRecordGroup.Controls.Add(this.bttDeleteRecord);
            this.PageRecordGroup.Controls.Add(this.bttAddRecordGroups);
            this.PageRecordGroup.Controls.Add(this.tbRecordGroupsSearch);
            this.PageRecordGroup.Controls.Add(this.labelRecordGroupsSearch);
            this.PageRecordGroup.Controls.Add(this.GridViewRecordGroups);
            this.PageRecordGroup.Location = new System.Drawing.Point(4, 4);
            this.PageRecordGroup.Name = "PageRecordGroup";
            this.PageRecordGroup.Padding = new System.Windows.Forms.Padding(3);
            this.PageRecordGroup.Size = new System.Drawing.Size(956, 530);
            this.PageRecordGroup.TabIndex = 1;
            this.PageRecordGroup.Text = "Запись в группы";
            this.PageRecordGroup.UseVisualStyleBackColor = true;
            // 
            // bttDeleteRecord
            // 
            this.bttDeleteRecord.Image = global::FitnessClub.Properties.Resources.deleteBox;
            this.bttDeleteRecord.Location = new System.Drawing.Point(729, 23);
            this.bttDeleteRecord.Name = "bttDeleteRecord";
            this.bttDeleteRecord.Size = new System.Drawing.Size(35, 29);
            this.bttDeleteRecord.TabIndex = 4;
            this.bttDeleteRecord.UseVisualStyleBackColor = true;
            this.bttDeleteRecord.Click += new System.EventHandler(this.bttDeleteRecord_Click);
            // 
            // bttAddRecordGroups
            // 
            this.bttAddRecordGroups.Location = new System.Drawing.Point(776, 23);
            this.bttAddRecordGroups.Name = "bttAddRecordGroups";
            this.bttAddRecordGroups.Size = new System.Drawing.Size(176, 29);
            this.bttAddRecordGroups.TabIndex = 3;
            this.bttAddRecordGroups.Text = "Добавить запись";
            this.bttAddRecordGroups.UseVisualStyleBackColor = true;
            this.bttAddRecordGroups.Click += new System.EventHandler(this.bttAddRecordGroups_Click);
            // 
            // tbRecordGroupsSearch
            // 
            this.tbRecordGroupsSearch.Location = new System.Drawing.Point(85, 24);
            this.tbRecordGroupsSearch.Name = "tbRecordGroupsSearch";
            this.tbRecordGroupsSearch.Size = new System.Drawing.Size(165, 28);
            this.tbRecordGroupsSearch.TabIndex = 2;
            this.tbRecordGroupsSearch.TextChanged += new System.EventHandler(this.tbRecordGroupsSearch_TextChanged);
            // 
            // labelRecordGroupsSearch
            // 
            this.labelRecordGroupsSearch.AutoSize = true;
            this.labelRecordGroupsSearch.Location = new System.Drawing.Point(20, 27);
            this.labelRecordGroupsSearch.Name = "labelRecordGroupsSearch";
            this.labelRecordGroupsSearch.Size = new System.Drawing.Size(59, 21);
            this.labelRecordGroupsSearch.TabIndex = 1;
            this.labelRecordGroupsSearch.Text = "Поиск:";
            // 
            // GridViewRecordGroups
            // 
            this.GridViewRecordGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewRecordGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewRecordGroups.Location = new System.Drawing.Point(24, 58);
            this.GridViewRecordGroups.Name = "GridViewRecordGroups";
            this.GridViewRecordGroups.ReadOnly = true;
            this.GridViewRecordGroups.Size = new System.Drawing.Size(928, 448);
            this.GridViewRecordGroups.TabIndex = 0;
            this.GridViewRecordGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewRecordGroups_CellContentClick);
            this.GridViewRecordGroups.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridViewTimeTable_KeyPress);
            // 
            // PageVisitGroup
            // 
            this.PageVisitGroup.Controls.Add(this.bttReportVisit);
            this.PageVisitGroup.Controls.Add(this.bttDeleteVisit);
            this.PageVisitGroup.Controls.Add(this.tbVisitGroupSearch);
            this.PageVisitGroup.Controls.Add(this.labelVisitGroupSearch);
            this.PageVisitGroup.Controls.Add(this.GridViewVisitGroup);
            this.PageVisitGroup.Location = new System.Drawing.Point(4, 4);
            this.PageVisitGroup.Name = "PageVisitGroup";
            this.PageVisitGroup.Size = new System.Drawing.Size(956, 530);
            this.PageVisitGroup.TabIndex = 2;
            this.PageVisitGroup.Text = "Посещения";
            this.PageVisitGroup.UseVisualStyleBackColor = true;
            // 
            // bttDeleteVisit
            // 
            this.bttDeleteVisit.Image = global::FitnessClub.Properties.Resources.deleteBox;
            this.bttDeleteVisit.Location = new System.Drawing.Point(914, 27);
            this.bttDeleteVisit.Name = "bttDeleteVisit";
            this.bttDeleteVisit.Size = new System.Drawing.Size(35, 29);
            this.bttDeleteVisit.TabIndex = 3;
            this.bttDeleteVisit.UseVisualStyleBackColor = true;
            this.bttDeleteVisit.Click += new System.EventHandler(this.bttDeleteVisit_Click);
            // 
            // tbVisitGroupSearch
            // 
            this.tbVisitGroupSearch.Location = new System.Drawing.Point(85, 24);
            this.tbVisitGroupSearch.Name = "tbVisitGroupSearch";
            this.tbVisitGroupSearch.Size = new System.Drawing.Size(165, 28);
            this.tbVisitGroupSearch.TabIndex = 2;
            this.tbVisitGroupSearch.TextChanged += new System.EventHandler(this.tbVisitGroupSearch_TextChanged);
            // 
            // labelVisitGroupSearch
            // 
            this.labelVisitGroupSearch.AutoSize = true;
            this.labelVisitGroupSearch.Location = new System.Drawing.Point(20, 27);
            this.labelVisitGroupSearch.Name = "labelVisitGroupSearch";
            this.labelVisitGroupSearch.Size = new System.Drawing.Size(59, 21);
            this.labelVisitGroupSearch.TabIndex = 1;
            this.labelVisitGroupSearch.Text = "Поиск:";
            // 
            // GridViewVisitGroup
            // 
            this.GridViewVisitGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewVisitGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewVisitGroup.Location = new System.Drawing.Point(24, 58);
            this.GridViewVisitGroup.Name = "GridViewVisitGroup";
            this.GridViewVisitGroup.ReadOnly = true;
            this.GridViewVisitGroup.Size = new System.Drawing.Size(928, 448);
            this.GridViewVisitGroup.TabIndex = 0;
            this.GridViewVisitGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridViewTimeTable_KeyPress);
            // 
            // PageWorker
            // 
            this.PageWorker.Controls.Add(this.bttWorkerReport);
            this.PageWorker.Controls.Add(this.bttDeleteWorker);
            this.PageWorker.Controls.Add(this.bttAddWorker);
            this.PageWorker.Controls.Add(this.tbWorkerSearch);
            this.PageWorker.Controls.Add(this.labelWorkerSearch);
            this.PageWorker.Controls.Add(this.GridViewWorker);
            this.PageWorker.Location = new System.Drawing.Point(4, 4);
            this.PageWorker.Name = "PageWorker";
            this.PageWorker.Size = new System.Drawing.Size(964, 564);
            this.PageWorker.TabIndex = 3;
            this.PageWorker.Text = "Сотрудники";
            this.PageWorker.UseVisualStyleBackColor = true;
            // 
            // bttDeleteWorker
            // 
            this.bttDeleteWorker.Image = global::FitnessClub.Properties.Resources.deleteBox;
            this.bttDeleteWorker.Location = new System.Drawing.Point(744, 19);
            this.bttDeleteWorker.Name = "bttDeleteWorker";
            this.bttDeleteWorker.Size = new System.Drawing.Size(35, 29);
            this.bttDeleteWorker.TabIndex = 4;
            this.bttDeleteWorker.UseVisualStyleBackColor = true;
            this.bttDeleteWorker.Click += new System.EventHandler(this.bttDeleteWorker_Click);
            // 
            // bttAddWorker
            // 
            this.bttAddWorker.Location = new System.Drawing.Point(785, 19);
            this.bttAddWorker.Name = "bttAddWorker";
            this.bttAddWorker.Size = new System.Drawing.Size(176, 29);
            this.bttAddWorker.TabIndex = 3;
            this.bttAddWorker.Text = "Новый сотрудник";
            this.bttAddWorker.UseVisualStyleBackColor = true;
            this.bttAddWorker.Click += new System.EventHandler(this.bttAddWorker_Click);
            // 
            // tbWorkerSearch
            // 
            this.tbWorkerSearch.Location = new System.Drawing.Point(73, 20);
            this.tbWorkerSearch.Name = "tbWorkerSearch";
            this.tbWorkerSearch.Size = new System.Drawing.Size(165, 28);
            this.tbWorkerSearch.TabIndex = 2;
            this.tbWorkerSearch.TextChanged += new System.EventHandler(this.tbWorkerSearch_TextChanged);
            // 
            // labelWorkerSearch
            // 
            this.labelWorkerSearch.AutoSize = true;
            this.labelWorkerSearch.Location = new System.Drawing.Point(8, 23);
            this.labelWorkerSearch.Name = "labelWorkerSearch";
            this.labelWorkerSearch.Size = new System.Drawing.Size(59, 21);
            this.labelWorkerSearch.TabIndex = 1;
            this.labelWorkerSearch.Text = "Поиск:";
            // 
            // GridViewWorker
            // 
            this.GridViewWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewWorker.Location = new System.Drawing.Point(8, 52);
            this.GridViewWorker.Name = "GridViewWorker";
            this.GridViewWorker.ReadOnly = true;
            this.GridViewWorker.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridViewWorker.Size = new System.Drawing.Size(956, 509);
            this.GridViewWorker.TabIndex = 0;
            this.GridViewWorker.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewWorker_CellContentClick);
            this.GridViewWorker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridViewTimeTable_KeyPress);
            // 
            // bttReportVisit
            // 
            this.bttReportVisit.Location = new System.Drawing.Point(779, 28);
            this.bttReportVisit.Name = "bttReportVisit";
            this.bttReportVisit.Size = new System.Drawing.Size(129, 28);
            this.bttReportVisit.TabIndex = 4;
            this.bttReportVisit.Text = "Отчет";
            this.bttReportVisit.UseVisualStyleBackColor = true;
            this.bttReportVisit.Click += new System.EventHandler(this.bttReportVisit_Click);
            // 
            // bttGroupReport
            // 
            this.bttGroupReport.Location = new System.Drawing.Point(641, 24);
            this.bttGroupReport.Name = "bttGroupReport";
            this.bttGroupReport.Size = new System.Drawing.Size(129, 28);
            this.bttGroupReport.TabIndex = 4;
            this.bttGroupReport.Text = "Отчет";
            this.bttGroupReport.UseVisualStyleBackColor = true;
            this.bttGroupReport.Click += new System.EventHandler(this.bttGroupReport_Click);
            // 
            // bttWorkerReport
            // 
            this.bttWorkerReport.Location = new System.Drawing.Point(609, 20);
            this.bttWorkerReport.Name = "bttWorkerReport";
            this.bttWorkerReport.Size = new System.Drawing.Size(129, 28);
            this.bttWorkerReport.TabIndex = 5;
            this.bttWorkerReport.Text = "Отчет";
            this.bttWorkerReport.UseVisualStyleBackColor = true;
            this.bttWorkerReport.Click += new System.EventHandler(this.bttWorkerReport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 598);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(988, 637);
            this.MinimumSize = new System.Drawing.Size(988, 637);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.PageTimeTable.ResumeLayout(false);
            this.PageTimeTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTimeTable)).EndInit();
            this.PageCustomer.ResumeLayout(false);
            this.PageCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewСustomers)).EndInit();
            this.PageClasses.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.PageService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewService)).EndInit();
            this.PageGroups.ResumeLayout(false);
            this.PageGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGroups)).EndInit();
            this.PageRecordGroup.ResumeLayout(false);
            this.PageRecordGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRecordGroups)).EndInit();
            this.PageVisitGroup.ResumeLayout(false);
            this.PageVisitGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitGroup)).EndInit();
            this.PageWorker.ResumeLayout(false);
            this.PageWorker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewWorker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PageTimeTable;
        private System.Windows.Forms.TabPage PageCustomer;
        private System.Windows.Forms.DateTimePicker SelectDate;
        private System.Windows.Forms.DataGridView GridViewTimeTable;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Label labelCustomerSearch;
        private System.Windows.Forms.TextBox tbCustomerSearch;
        private System.Windows.Forms.DataGridView GridViewСustomers;
        private System.Windows.Forms.Button bttAddCustomer;
        private System.Windows.Forms.TabPage PageClasses;
        private System.Windows.Forms.Label labelGroupsSearch;
        private System.Windows.Forms.TextBox tbGroupsSearch;
        private System.Windows.Forms.Button bttAddGroups;
        private System.Windows.Forms.DataGridView GridViewGroups;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage PageGroups;
        private System.Windows.Forms.TabPage PageRecordGroup;
        private System.Windows.Forms.Button bttAddRecordGroups;
        private System.Windows.Forms.TextBox tbRecordGroupsSearch;
        private System.Windows.Forms.Label labelRecordGroupsSearch;
        private System.Windows.Forms.DataGridView GridViewRecordGroups;
        private System.Windows.Forms.TabPage PageVisitGroup;
        private System.Windows.Forms.TextBox tbVisitGroupSearch;
        private System.Windows.Forms.Label labelVisitGroupSearch;
        private System.Windows.Forms.DataGridView GridViewVisitGroup;
        private System.Windows.Forms.TabPage PageWorker;
        private System.Windows.Forms.Button bttAddWorker;
        private System.Windows.Forms.TextBox tbWorkerSearch;
        private System.Windows.Forms.Label labelWorkerSearch;
        private System.Windows.Forms.TabPage PageService;
        private System.Windows.Forms.Button bttAddService;
        private System.Windows.Forms.DataGridView GridViewService;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttDeleteCustomer;
        private System.Windows.Forms.Button bttDeleteWorker;
        public System.Windows.Forms.DataGridView GridViewWorker;
        private System.Windows.Forms.Button bttDeleteService;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Понедельник;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вторник;
        private System.Windows.Forms.DataGridViewTextBoxColumn Среда;
        private System.Windows.Forms.DataGridViewTextBoxColumn Четверг;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пятница;
        private System.Windows.Forms.DataGridViewTextBoxColumn Суббота;
        private System.Windows.Forms.Button bttDeleteRecord;
        private System.Windows.Forms.Button bttAddVisit;
        private System.Windows.Forms.Button bttDeleteVisit;
        private System.Windows.Forms.Button bttReportVisit;
        private System.Windows.Forms.Button bttGroupReport;
        private System.Windows.Forms.Button bttWorkerReport;
    }
}

