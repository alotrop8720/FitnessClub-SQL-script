namespace FitnessClub.Forms
{
    partial class GroupAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupAdd));
            this.cbService = new System.Windows.Forms.ComboBox();
            this.cbWorker = new System.Windows.Forms.ComboBox();
            this.DateStart = new System.Windows.Forms.DateTimePicker();
            this.DateFinish = new System.Windows.Forms.DateTimePicker();
            this.tbMaxPeople = new System.Windows.Forms.TextBox();
            this.tbCountTime = new System.Windows.Forms.TextBox();
            this.labelNumberGroup = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.labelWorker = new System.Windows.Forms.Label();
            this.labelMaxPeople = new System.Windows.Forms.Label();
            this.labelDateStart = new System.Windows.Forms.Label();
            this.labelDateFinish = new System.Windows.Forms.Label();
            this.labelCountTime = new System.Windows.Forms.Label();
            this.tbNumberGroup = new System.Windows.Forms.TextBox();
            this.bttAddService = new System.Windows.Forms.Button();
            this.bttAddCustomer = new System.Windows.Forms.Button();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.labelRoom = new System.Windows.Forms.Label();
            this.tbRoom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbService
            // 
            this.cbService.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(256, 56);
            this.cbService.MaxDropDownItems = 5;
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(208, 29);
            this.cbService.TabIndex = 0;
            this.cbService.DropDown += new System.EventHandler(this.cbService_DropDown);
            this.cbService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbService_KeyPress_1);
            // 
            // cbWorker
            // 
            this.cbWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbWorker.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWorker.FormattingEnabled = true;
            this.cbWorker.Location = new System.Drawing.Point(256, 91);
            this.cbWorker.MaxDropDownItems = 5;
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Size = new System.Drawing.Size(208, 29);
            this.cbWorker.TabIndex = 1;
            this.cbWorker.DropDown += new System.EventHandler(this.cbCustomer_DropDown);
            // 
            // DateStart
            // 
            this.DateStart.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateStart.Location = new System.Drawing.Point(256, 211);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(240, 28);
            this.DateStart.TabIndex = 2;
            this.DateStart.ValueChanged += new System.EventHandler(this.DateFinish_ValueChanged);
            // 
            // DateFinish
            // 
            this.DateFinish.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFinish.Location = new System.Drawing.Point(256, 243);
            this.DateFinish.Name = "DateFinish";
            this.DateFinish.Size = new System.Drawing.Size(240, 28);
            this.DateFinish.TabIndex = 3;
            this.DateFinish.ValueChanged += new System.EventHandler(this.DateFinish_ValueChanged);
            // 
            // tbMaxPeople
            // 
            this.tbMaxPeople.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxPeople.Location = new System.Drawing.Point(256, 126);
            this.tbMaxPeople.MaxLength = 2;
            this.tbMaxPeople.Name = "tbMaxPeople";
            this.tbMaxPeople.Size = new System.Drawing.Size(240, 28);
            this.tbMaxPeople.TabIndex = 4;
            this.tbMaxPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxPeople_KeyPress);
            // 
            // tbCountTime
            // 
            this.tbCountTime.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountTime.Location = new System.Drawing.Point(256, 277);
            this.tbCountTime.MaxLength = 1;
            this.tbCountTime.Name = "tbCountTime";
            this.tbCountTime.Size = new System.Drawing.Size(35, 28);
            this.tbCountTime.TabIndex = 5;
            this.tbCountTime.TextChanged += new System.EventHandler(this.tbCountTime_TextChanged);
            this.tbCountTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxPeople_KeyPress);
            // 
            // labelNumberGroup
            // 
            this.labelNumberGroup.AutoSize = true;
            this.labelNumberGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberGroup.Location = new System.Drawing.Point(34, 22);
            this.labelNumberGroup.Name = "labelNumberGroup";
            this.labelNumberGroup.Size = new System.Drawing.Size(116, 21);
            this.labelNumberGroup.TabIndex = 6;
            this.labelNumberGroup.Text = "Номер группы";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelService.Location = new System.Drawing.Point(34, 56);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(61, 21);
            this.labelService.TabIndex = 7;
            this.labelService.Text = "Услуга";
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorker.Location = new System.Drawing.Point(34, 91);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(64, 21);
            this.labelWorker.TabIndex = 8;
            this.labelWorker.Text = "Тренер";
            // 
            // labelMaxPeople
            // 
            this.labelMaxPeople.AutoSize = true;
            this.labelMaxPeople.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxPeople.Location = new System.Drawing.Point(34, 125);
            this.labelMaxPeople.Name = "labelMaxPeople";
            this.labelMaxPeople.Size = new System.Drawing.Size(216, 42);
            this.labelMaxPeople.TabIndex = 9;
            this.labelMaxPeople.Text = "Максимальное количество\r\nчеловек в группе";
            // 
            // labelDateStart
            // 
            this.labelDateStart.AutoSize = true;
            this.labelDateStart.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateStart.Location = new System.Drawing.Point(34, 214);
            this.labelDateStart.Name = "labelDateStart";
            this.labelDateStart.Size = new System.Drawing.Size(108, 21);
            this.labelDateStart.TabIndex = 10;
            this.labelDateStart.Text = "Дата начала";
            // 
            // labelDateFinish
            // 
            this.labelDateFinish.AutoSize = true;
            this.labelDateFinish.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFinish.Location = new System.Drawing.Point(34, 246);
            this.labelDateFinish.Name = "labelDateFinish";
            this.labelDateFinish.Size = new System.Drawing.Size(97, 21);
            this.labelDateFinish.TabIndex = 11;
            this.labelDateFinish.Text = "Дата конца";
            // 
            // labelCountTime
            // 
            this.labelCountTime.AutoSize = true;
            this.labelCountTime.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountTime.Location = new System.Drawing.Point(34, 277);
            this.labelCountTime.Name = "labelCountTime";
            this.labelCountTime.Size = new System.Drawing.Size(147, 42);
            this.labelCountTime.TabIndex = 12;
            this.labelCountTime.Text = "Количество дней \r\nв неделе";
            // 
            // tbNumberGroup
            // 
            this.tbNumberGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberGroup.Location = new System.Drawing.Point(256, 22);
            this.tbNumberGroup.MaxLength = 5;
            this.tbNumberGroup.Name = "tbNumberGroup";
            this.tbNumberGroup.Size = new System.Drawing.Size(240, 28);
            this.tbNumberGroup.TabIndex = 13;
            // 
            // bttAddService
            // 
            this.bttAddService.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAddService.Image = ((System.Drawing.Image)(resources.GetObject("bttAddService.Image")));
            this.bttAddService.Location = new System.Drawing.Point(470, 56);
            this.bttAddService.Name = "bttAddService";
            this.bttAddService.Size = new System.Drawing.Size(27, 29);
            this.bttAddService.TabIndex = 14;
            this.bttAddService.UseVisualStyleBackColor = true;
            this.bttAddService.Click += new System.EventHandler(this.bttAddService_Click);
            // 
            // bttAddCustomer
            // 
            this.bttAddCustomer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAddCustomer.Image = global::FitnessClub.Properties.Resources.plus;
            this.bttAddCustomer.Location = new System.Drawing.Point(470, 91);
            this.bttAddCustomer.Name = "bttAddCustomer";
            this.bttAddCustomer.Size = new System.Drawing.Size(27, 29);
            this.bttAddCustomer.TabIndex = 15;
            this.bttAddCustomer.UseVisualStyleBackColor = true;
            this.bttAddCustomer.Click += new System.EventHandler(this.bttAddCustomer_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd.Location = new System.Drawing.Point(79, 334);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(170, 37);
            this.bttAdd.TabIndex = 16;
            this.bttAdd.Text = "Сохранить";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancel.Location = new System.Drawing.Point(255, 334);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(170, 37);
            this.bttCancel.TabIndex = 17;
            this.bttCancel.Text = "Отмена";
            this.bttCancel.UseVisualStyleBackColor = true;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoom.Location = new System.Drawing.Point(34, 179);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(40, 21);
            this.labelRoom.TabIndex = 19;
            this.labelRoom.Text = "Зал";
            // 
            // tbRoom
            // 
            this.tbRoom.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoom.FormattingEnabled = true;
            this.tbRoom.Items.AddRange(new object[] {
            "Фитнес зал",
            "Аэробика",
            "Бассеин",
            "Тренажерный зал",
            "Зал йоги",
            "Танцевальный зал",
            "Гимнастический зал "});
            this.tbRoom.Location = new System.Drawing.Point(255, 176);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(240, 29);
            this.tbRoom.TabIndex = 20;
            this.tbRoom.DropDown += new System.EventHandler(this.tbRoom_DropDown);
            // 
            // GroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 413);
            this.Controls.Add(this.tbRoom);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.bttAddCustomer);
            this.Controls.Add(this.bttAddService);
            this.Controls.Add(this.tbNumberGroup);
            this.Controls.Add(this.labelCountTime);
            this.Controls.Add(this.labelDateFinish);
            this.Controls.Add(this.labelDateStart);
            this.Controls.Add(this.labelMaxPeople);
            this.Controls.Add(this.labelWorker);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.labelNumberGroup);
            this.Controls.Add(this.tbCountTime);
            this.Controls.Add(this.tbMaxPeople);
            this.Controls.Add(this.DateFinish);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.cbWorker);
            this.Controls.Add(this.cbService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GroupAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая группа";
            this.Load += new System.EventHandler(this.AddGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.ComboBox cbWorker;
        private System.Windows.Forms.DateTimePicker DateStart;
        private System.Windows.Forms.DateTimePicker DateFinish;
        private System.Windows.Forms.TextBox tbMaxPeople;
        private System.Windows.Forms.TextBox tbCountTime;
        private System.Windows.Forms.Label labelNumberGroup;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.Label labelMaxPeople;
        private System.Windows.Forms.Label labelDateStart;
        private System.Windows.Forms.Label labelDateFinish;
        private System.Windows.Forms.Label labelCountTime;
        private System.Windows.Forms.TextBox tbNumberGroup;
        private System.Windows.Forms.Button bttAddService;
        private System.Windows.Forms.Button bttAddCustomer;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.ComboBox tbRoom;
    }
}