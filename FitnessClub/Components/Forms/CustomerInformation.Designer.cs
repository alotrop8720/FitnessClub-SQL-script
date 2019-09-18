namespace FitnessClub.Components.Forms
{
    partial class CustomerInformation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelName = new System.Windows.Forms.Label();
            this.labelThirdName = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbThirdName = new System.Windows.Forms.TextBox();
            this.DateBirthday = new System.Windows.Forms.DateTimePicker();
            this.GridViewSelect = new System.Windows.Forms.DataGridView();
            this.labelSex = new System.Windows.Forms.Label();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.cbChoseDate = new System.Windows.Forms.CheckBox();
            this.rbGroupVisit = new System.Windows.Forms.RadioButton();
            this.labelCategory = new System.Windows.Forms.Label();
            this.DateChose = new System.Windows.Forms.DateTimePicker();
            this.rbVisit = new System.Windows.Forms.RadioButton();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSelect)).BeginInit();
            this.panelCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(21, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(119, 21);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя Отчество";
            // 
            // labelThirdName
            // 
            this.labelThirdName.AutoSize = true;
            this.labelThirdName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThirdName.Location = new System.Drawing.Point(21, 76);
            this.labelThirdName.Name = "labelThirdName";
            this.labelThirdName.Size = new System.Drawing.Size(82, 21);
            this.labelThirdName.TabIndex = 1;
            this.labelThirdName.Text = "Фамилия";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.Location = new System.Drawing.Point(21, 113);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(129, 21);
            this.labelBirthday.TabIndex = 2;
            this.labelBirthday.Text = "Дата рождения";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(21, 144);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(80, 21);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Телефон";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Snow;
            this.tbName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(171, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(230, 28);
            this.tbName.TabIndex = 4;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbThirdName
            // 
            this.tbThirdName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThirdName.Location = new System.Drawing.Point(171, 73);
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.Size = new System.Drawing.Size(173, 28);
            this.tbThirdName.TabIndex = 5;
            // 
            // DateBirthday
            // 
            this.DateBirthday.CalendarMonthBackground = System.Drawing.Color.Snow;
            this.DateBirthday.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBirthday.Location = new System.Drawing.Point(171, 107);
            this.DateBirthday.Name = "DateBirthday";
            this.DateBirthday.Size = new System.Drawing.Size(200, 28);
            this.DateBirthday.TabIndex = 7;
            this.DateBirthday.ValueChanged += new System.EventHandler(this.DateBirthday_ValueChanged);
            this.DateBirthday.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // GridViewSelect
            // 
            this.GridViewSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewSelect.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridViewSelect.Location = new System.Drawing.Point(25, 185);
            this.GridViewSelect.Name = "GridViewSelect";
            this.GridViewSelect.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewSelect.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GridViewSelect.Size = new System.Drawing.Size(467, 253);
            this.GridViewSelect.TabIndex = 8;
            this.GridViewSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridViewSelect_KeyPress);
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.Location = new System.Drawing.Point(407, 40);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(41, 21);
            this.labelSex.TabIndex = 9;
            this.labelSex.Text = "Пол";
            // 
            // panelCategory
            // 
            this.panelCategory.Controls.Add(this.cbChoseDate);
            this.panelCategory.Controls.Add(this.rbGroupVisit);
            this.panelCategory.Controls.Add(this.labelCategory);
            this.panelCategory.Controls.Add(this.DateChose);
            this.panelCategory.Controls.Add(this.rbVisit);
            this.panelCategory.Location = new System.Drawing.Point(498, 185);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(208, 193);
            this.panelCategory.TabIndex = 10;
            // 
            // cbChoseDate
            // 
            this.cbChoseDate.AutoSize = true;
            this.cbChoseDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChoseDate.Location = new System.Drawing.Point(58, 155);
            this.cbChoseDate.Name = "cbChoseDate";
            this.cbChoseDate.Size = new System.Drawing.Size(142, 25);
            this.cbChoseDate.TabIndex = 5;
            this.cbChoseDate.Text = "Выбор по дате";
            this.cbChoseDate.UseVisualStyleBackColor = true;
            this.cbChoseDate.CheckedChanged += new System.EventHandler(this.cbChoseDate_CheckedChanged);
            // 
            // rbGroupVisit
            // 
            this.rbGroupVisit.AutoSize = true;
            this.rbGroupVisit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGroupVisit.Location = new System.Drawing.Point(16, 38);
            this.rbGroupVisit.Name = "rbGroupVisit";
            this.rbGroupVisit.Size = new System.Drawing.Size(187, 46);
            this.rbGroupVisit.TabIndex = 1;
            this.rbGroupVisit.TabStop = true;
            this.rbGroupVisit.Text = "Группы посещаемые \r\nклиентом";
            this.rbGroupVisit.UseVisualStyleBackColor = true;
            this.rbGroupVisit.CheckedChanged += new System.EventHandler(this.rbGroupVisit_CheckedChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(12, 14);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(90, 21);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Категория";
            // 
            // DateChose
            // 
            this.DateChose.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateChose.Location = new System.Drawing.Point(33, 121);
            this.DateChose.Name = "DateChose";
            this.DateChose.Size = new System.Drawing.Size(167, 28);
            this.DateChose.TabIndex = 4;
            this.DateChose.ValueChanged += new System.EventHandler(this.cbChoseDate_CheckedChanged);
            // 
            // rbVisit
            // 
            this.rbVisit.AutoSize = true;
            this.rbVisit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVisit.Location = new System.Drawing.Point(16, 90);
            this.rbVisit.Name = "rbVisit";
            this.rbVisit.Size = new System.Drawing.Size(115, 25);
            this.rbVisit.TabIndex = 2;
            this.rbVisit.TabStop = true;
            this.rbVisit.Text = "Посещения\r\n";
            this.rbVisit.UseVisualStyleBackColor = true;
            this.rbVisit.CheckedChanged += new System.EventHandler(this.rbVisit_CheckedChanged);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(171, 141);
            this.tbPhone.Mask = "+375 (99) 000-0000";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(200, 28);
            this.tbPhone.TabIndex = 6;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // CustomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.panelCategory);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.GridViewSelect);
            this.Controls.Add(this.DateBirthday);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbThirdName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelThirdName);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(743, 489);
            this.MinimumSize = new System.Drawing.Size(743, 489);
            this.Name = "CustomerInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о клиенте";
            this.Activated += new System.EventHandler(this.CustomerInformation_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerInformation_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSelect)).EndInit();
            this.panelCategory.ResumeLayout(false);
            this.panelCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelThirdName;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.DataGridView GridViewSelect;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.CheckBox cbChoseDate;
        private System.Windows.Forms.RadioButton rbGroupVisit;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.DateTimePicker DateChose;
        private System.Windows.Forms.RadioButton rbVisit;
        public System.Windows.Forms.Label labelSex;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.TextBox tbThirdName;
        public System.Windows.Forms.DateTimePicker DateBirthday;
        public System.Windows.Forms.MaskedTextBox tbPhone;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}