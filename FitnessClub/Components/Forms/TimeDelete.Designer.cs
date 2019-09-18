namespace FitnessClub.Components.Forms
{
    partial class TimeDelete
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelWorker = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.labelDateStart = new System.Windows.Forms.Label();
            this.labelDateFinish = new System.Windows.Forms.Label();
            this.GridViewSelect = new System.Windows.Forms.DataGridView();
            this.labelMaxCountPeople = new System.Windows.Forms.Label();
            this.labelAvgAge = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.rbVisit = new System.Windows.Forms.RadioButton();
            this.rbCustomers = new System.Windows.Forms.RadioButton();
            this.PanelCategory = new System.Windows.Forms.Panel();
            this.cbChoseDate = new System.Windows.Forms.CheckBox();
            this.ChoseDate = new System.Windows.Forms.DateTimePicker();
            this.bttDays = new System.Windows.Forms.Button();
            this.PanelDays = new System.Windows.Forms.Panel();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerPanel = new System.Windows.Forms.Timer(this.components);
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.tbService = new System.Windows.Forms.TextBox();
            this.tbWorker = new System.Windows.Forms.TextBox();
            this.tbCountPeople = new System.Windows.Forms.TextBox();
            this.tbDateStart = new System.Windows.Forms.DateTimePicker();
            this.tbDateFinish = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSelect)).BeginInit();
            this.PanelCategory.SuspendLayout();
            this.PanelDays.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(23, 51);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(62, 21);
            this.labelGroup.TabIndex = 0;
            this.labelGroup.Text = "Группа";
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorker.Location = new System.Drawing.Point(23, 88);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(64, 21);
            this.labelWorker.TabIndex = 1;
            this.labelWorker.Text = "Тренер";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelService.Location = new System.Drawing.Point(23, 121);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(106, 21);
            this.labelService.TabIndex = 2;
            this.labelService.Text = "Сфера услуг";
            // 
            // labelDateStart
            // 
            this.labelDateStart.AutoSize = true;
            this.labelDateStart.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateStart.Location = new System.Drawing.Point(23, 155);
            this.labelDateStart.Name = "labelDateStart";
            this.labelDateStart.Size = new System.Drawing.Size(134, 21);
            this.labelDateStart.TabIndex = 3;
            this.labelDateStart.Text = "Начало занятий";
            // 
            // labelDateFinish
            // 
            this.labelDateFinish.AutoSize = true;
            this.labelDateFinish.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFinish.Location = new System.Drawing.Point(374, 155);
            this.labelDateFinish.Name = "labelDateFinish";
            this.labelDateFinish.Size = new System.Drawing.Size(30, 21);
            this.labelDateFinish.TabIndex = 4;
            this.labelDateFinish.Text = "до";
            // 
            // GridViewSelect
            // 
            this.GridViewSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.GridViewSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewSelect.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewSelect.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewSelect.Location = new System.Drawing.Point(19, 263);
            this.GridViewSelect.Name = "GridViewSelect";
            this.GridViewSelect.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewSelect.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewSelect.Size = new System.Drawing.Size(685, 224);
            this.GridViewSelect.TabIndex = 5;
            this.GridViewSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridViewSelect_KeyPress);
            // 
            // labelMaxCountPeople
            // 
            this.labelMaxCountPeople.AutoSize = true;
            this.labelMaxCountPeople.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxCountPeople.Location = new System.Drawing.Point(23, 192);
            this.labelMaxCountPeople.Name = "labelMaxCountPeople";
            this.labelMaxCountPeople.Size = new System.Drawing.Size(168, 21);
            this.labelMaxCountPeople.TabIndex = 10;
            this.labelMaxCountPeople.Text = "Количество человек";
            // 
            // labelAvgAge
            // 
            this.labelAvgAge.AutoSize = true;
            this.labelAvgAge.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgAge.Location = new System.Drawing.Point(432, 239);
            this.labelAvgAge.Name = "labelAvgAge";
            this.labelAvgAge.Size = new System.Drawing.Size(209, 21);
            this.labelAvgAge.TabIndex = 11;
            this.labelAvgAge.Text = "Средний возраст в группе";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(3, 9);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(93, 21);
            this.labelType.TabIndex = 12;
            this.labelType.Text = "Категория:";
            // 
            // rbVisit
            // 
            this.rbVisit.AutoSize = true;
            this.rbVisit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVisit.Location = new System.Drawing.Point(20, 56);
            this.rbVisit.Name = "rbVisit";
            this.rbVisit.Size = new System.Drawing.Size(115, 25);
            this.rbVisit.TabIndex = 7;
            this.rbVisit.TabStop = true;
            this.rbVisit.Text = "Посещения";
            this.rbVisit.UseVisualStyleBackColor = true;
            this.rbVisit.CheckedChanged += new System.EventHandler(this.rbVisit_CheckedChanged);
            // 
            // rbCustomers
            // 
            this.rbCustomers.AutoSize = true;
            this.rbCustomers.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCustomers.Location = new System.Drawing.Point(20, 33);
            this.rbCustomers.Name = "rbCustomers";
            this.rbCustomers.Size = new System.Drawing.Size(177, 25);
            this.rbCustomers.TabIndex = 6;
            this.rbCustomers.TabStop = true;
            this.rbCustomers.Text = "Посетители группы";
            this.rbCustomers.UseVisualStyleBackColor = true;
            this.rbCustomers.CheckedChanged += new System.EventHandler(this.rbCustomers_CheckedChanged);
            // 
            // PanelCategory
            // 
            this.PanelCategory.Controls.Add(this.cbChoseDate);
            this.PanelCategory.Controls.Add(this.ChoseDate);
            this.PanelCategory.Controls.Add(this.labelType);
            this.PanelCategory.Controls.Add(this.rbCustomers);
            this.PanelCategory.Controls.Add(this.rbVisit);
            this.PanelCategory.Location = new System.Drawing.Point(710, 280);
            this.PanelCategory.Name = "PanelCategory";
            this.PanelCategory.Size = new System.Drawing.Size(200, 159);
            this.PanelCategory.TabIndex = 13;
            // 
            // cbChoseDate
            // 
            this.cbChoseDate.AutoSize = true;
            this.cbChoseDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChoseDate.Location = new System.Drawing.Point(55, 121);
            this.cbChoseDate.Name = "cbChoseDate";
            this.cbChoseDate.Size = new System.Drawing.Size(142, 25);
            this.cbChoseDate.TabIndex = 14;
            this.cbChoseDate.Text = "Выбор по дате";
            this.cbChoseDate.UseVisualStyleBackColor = true;
            this.cbChoseDate.CheckedChanged += new System.EventHandler(this.cbChoseDate_CheckedChanged);
            // 
            // ChoseDate
            // 
            this.ChoseDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoseDate.Location = new System.Drawing.Point(39, 87);
            this.ChoseDate.Name = "ChoseDate";
            this.ChoseDate.Size = new System.Drawing.Size(158, 28);
            this.ChoseDate.TabIndex = 13;
            this.ChoseDate.ValueChanged += new System.EventHandler(this.cbChoseDate_CheckedChanged);
            // 
            // bttDays
            // 
            this.bttDays.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttDays.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDays.Location = new System.Drawing.Point(0, 377);
            this.bttDays.Name = "bttDays";
            this.bttDays.Size = new System.Drawing.Size(313, 28);
            this.bttDays.TabIndex = 15;
            this.bttDays.Text = "Дни посещения";
            this.bttDays.UseVisualStyleBackColor = true;
            this.bttDays.Click += new System.EventHandler(this.bttDays_Click);
            // 
            // PanelDays
            // 
            this.PanelDays.BackColor = System.Drawing.Color.Snow;
            this.PanelDays.Controls.Add(this.labelDay);
            this.PanelDays.Controls.Add(this.labelTime);
            this.PanelDays.Controls.Add(this.bttDays);
            this.PanelDays.Location = new System.Drawing.Point(597, -375);
            this.PanelDays.Name = "PanelDays";
            this.PanelDays.Size = new System.Drawing.Size(313, 405);
            this.PanelDays.TabIndex = 16;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.Location = new System.Drawing.Point(129, 20);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(113, 21);
            this.labelDay.TabIndex = 17;
            this.labelDay.Text = "День Недели";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(19, 20);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(59, 21);
            this.labelTime.TabIndex = 16;
            this.labelTime.Text = "Время";
            // 
            // timerPanel
            // 
            this.timerPanel.Interval = 1;
            this.timerPanel.Tick += new System.EventHandler(this.timerPanel_Tick);
            // 
            // tbGroup
            // 
            this.tbGroup.BackColor = System.Drawing.SystemColors.Info;
            this.tbGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGroup.Location = new System.Drawing.Point(197, 51);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(66, 28);
            this.tbGroup.TabIndex = 17;
            this.tbGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGroup_KeyPress);
            // 
            // tbService
            // 
            this.tbService.BackColor = System.Drawing.SystemColors.Info;
            this.tbService.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbService.Location = new System.Drawing.Point(197, 118);
            this.tbService.Name = "tbService";
            this.tbService.Size = new System.Drawing.Size(148, 28);
            this.tbService.TabIndex = 18;
            this.tbService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGroup_KeyPress);
            // 
            // tbWorker
            // 
            this.tbWorker.BackColor = System.Drawing.SystemColors.Info;
            this.tbWorker.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWorker.Location = new System.Drawing.Point(197, 85);
            this.tbWorker.Name = "tbWorker";
            this.tbWorker.Size = new System.Drawing.Size(281, 28);
            this.tbWorker.TabIndex = 19;
            this.tbWorker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGroup_KeyPress);
            // 
            // tbCountPeople
            // 
            this.tbCountPeople.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountPeople.Location = new System.Drawing.Point(197, 189);
            this.tbCountPeople.Name = "tbCountPeople";
            this.tbCountPeople.Size = new System.Drawing.Size(63, 28);
            this.tbCountPeople.TabIndex = 22;
            this.tbCountPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGroup_KeyPress);
            // 
            // tbDateStart
            // 
            this.tbDateStart.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateStart.Location = new System.Drawing.Point(197, 155);
            this.tbDateStart.Name = "tbDateStart";
            this.tbDateStart.Size = new System.Drawing.Size(171, 28);
            this.tbDateStart.TabIndex = 23;
            this.tbDateStart.ValueChanged += new System.EventHandler(this.tbDateStart_ValueChanged);
            this.tbDateStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGroup_KeyPress);
            // 
            // tbDateFinish
            // 
            this.tbDateFinish.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateFinish.Location = new System.Drawing.Point(410, 155);
            this.tbDateFinish.Name = "tbDateFinish";
            this.tbDateFinish.Size = new System.Drawing.Size(166, 28);
            this.tbDateFinish.TabIndex = 24;
            this.tbDateFinish.ValueChanged += new System.EventHandler(this.tbDateStart_ValueChanged);
            this.tbDateFinish.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGroup_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 24);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TimeDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDateFinish);
            this.Controls.Add(this.tbDateStart);
            this.Controls.Add(this.tbCountPeople);
            this.Controls.Add(this.tbWorker);
            this.Controls.Add(this.tbService);
            this.Controls.Add(this.tbGroup);
            this.Controls.Add(this.PanelDays);
            this.Controls.Add(this.PanelCategory);
            this.Controls.Add(this.labelAvgAge);
            this.Controls.Add(this.labelMaxCountPeople);
            this.Controls.Add(this.GridViewSelect);
            this.Controls.Add(this.labelDateFinish);
            this.Controls.Add(this.labelDateStart);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.labelWorker);
            this.Controls.Add(this.labelGroup);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(938, 538);
            this.MinimumSize = new System.Drawing.Size(938, 538);
            this.Name = "TimeDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о группе ";
            this.Activated += new System.EventHandler(this.TimeDelete_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeDelete_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSelect)).EndInit();
            this.PanelCategory.ResumeLayout(false);
            this.PanelCategory.PerformLayout();
            this.PanelDays.ResumeLayout(false);
            this.PanelDays.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelDateStart;
        private System.Windows.Forms.Label labelDateFinish;
        private System.Windows.Forms.DataGridView GridViewSelect;
        private System.Windows.Forms.Label labelMaxCountPeople;
        private System.Windows.Forms.Label labelAvgAge;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.RadioButton rbVisit;
        private System.Windows.Forms.RadioButton rbCustomers;
        private System.Windows.Forms.Panel PanelCategory;
        private System.Windows.Forms.Button bttDays;
        private System.Windows.Forms.Panel PanelDays;
        private System.Windows.Forms.Timer timerPanel;
        public System.Windows.Forms.TextBox tbGroup;
        public System.Windows.Forms.TextBox tbService;
        public System.Windows.Forms.TextBox tbWorker;
        public System.Windows.Forms.TextBox tbCountPeople;
        public System.Windows.Forms.DateTimePicker tbDateStart;
        public System.Windows.Forms.DateTimePicker tbDateFinish;
        private System.Windows.Forms.CheckBox cbChoseDate;
        private System.Windows.Forms.DateTimePicker ChoseDate;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button button1;
    }
}