namespace FitnessClub.Forms
{
    partial class WorkerAdd
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.tbThirdName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbExperience = new System.Windows.Forms.TextBox();
            this.DateBirthday = new System.Windows.Forms.DateTimePicker();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbNumberHome = new System.Windows.Forms.TextBox();
            this.tbNumberFlat = new System.Windows.Forms.TextBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelThirdName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelExperience = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelNumberHome = new System.Windows.Forms.Label();
            this.labelNumberFlat = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttCenсel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(196, 41);
            this.tbName.MaxLength = 30;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(240, 28);
            this.tbName.TabIndex = 0;
            this.tbName.Tag = "record";
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbSecondName
            // 
            this.tbSecondName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSecondName.Location = new System.Drawing.Point(196, 75);
            this.tbSecondName.MaxLength = 30;
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(240, 28);
            this.tbSecondName.TabIndex = 1;
            this.tbSecondName.Tag = "record";
            this.tbSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbThirdName
            // 
            this.tbThirdName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThirdName.Location = new System.Drawing.Point(196, 109);
            this.tbThirdName.MaxLength = 30;
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.Size = new System.Drawing.Size(240, 28);
            this.tbThirdName.TabIndex = 2;
            this.tbThirdName.Tag = "";
            this.tbThirdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(196, 143);
            this.tbPhone.Mask = "+375 (99) 000-00-00";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(240, 28);
            this.tbPhone.TabIndex = 3;
            // 
            // tbExperience
            // 
            this.tbExperience.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExperience.Location = new System.Drawing.Point(196, 178);
            this.tbExperience.MaxLength = 2;
            this.tbExperience.Name = "tbExperience";
            this.tbExperience.Size = new System.Drawing.Size(240, 28);
            this.tbExperience.TabIndex = 4;
            this.tbExperience.Text = "0";
            this.tbExperience.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbExperience_KeyPress);
            // 
            // DateBirthday
            // 
            this.DateBirthday.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBirthday.Location = new System.Drawing.Point(196, 239);
            this.DateBirthday.Name = "DateBirthday";
            this.DateBirthday.Size = new System.Drawing.Size(240, 28);
            this.DateBirthday.TabIndex = 5;
            this.DateBirthday.Tag = "";
            // 
            // tbStreet
            // 
            this.tbStreet.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStreet.Location = new System.Drawing.Point(196, 353);
            this.tbStreet.MaxLength = 50;
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(240, 28);
            this.tbStreet.TabIndex = 6;
            this.tbStreet.Tag = "";
            this.tbStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStreet_KeyPress);
            // 
            // tbNumberHome
            // 
            this.tbNumberHome.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberHome.Location = new System.Drawing.Point(265, 393);
            this.tbNumberHome.MaxLength = 4;
            this.tbNumberHome.Name = "tbNumberHome";
            this.tbNumberHome.Size = new System.Drawing.Size(50, 28);
            this.tbNumberHome.TabIndex = 7;
            this.tbNumberHome.Tag = "";
            this.tbNumberHome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbExperience_KeyPress);
            // 
            // tbNumberFlat
            // 
            this.tbNumberFlat.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberFlat.Location = new System.Drawing.Point(378, 393);
            this.tbNumberFlat.MaxLength = 4;
            this.tbNumberFlat.Name = "tbNumberFlat";
            this.tbNumberFlat.Size = new System.Drawing.Size(58, 28);
            this.tbNumberFlat.TabIndex = 8;
            this.tbNumberFlat.Tag = "";
            this.tbNumberFlat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbExperience_KeyPress);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(196, 281);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(93, 25);
            this.rbFemale.TabIndex = 9;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Женский";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(295, 281);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(93, 25);
            this.rbMale.TabIndex = 10;
            this.rbMale.Text = "Мужской";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(34, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 21);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Имя";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecondName.Location = new System.Drawing.Point(34, 83);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(82, 21);
            this.labelSecondName.TabIndex = 12;
            this.labelSecondName.Text = "Фамилия";
            // 
            // labelThirdName
            // 
            this.labelThirdName.AutoSize = true;
            this.labelThirdName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThirdName.Location = new System.Drawing.Point(34, 117);
            this.labelThirdName.Name = "labelThirdName";
            this.labelThirdName.Size = new System.Drawing.Size(84, 21);
            this.labelThirdName.TabIndex = 13;
            this.labelThirdName.Text = "Отчество";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(34, 150);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(143, 21);
            this.labelPhone.TabIndex = 14;
            this.labelPhone.Text = "Номер телефона";
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExperience.Location = new System.Drawing.Point(34, 185);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(110, 21);
            this.labelExperience.TabIndex = 15;
            this.labelExperience.Text = "Стаж работы";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.Location = new System.Drawing.Point(34, 245);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(129, 21);
            this.labelBirthday.TabIndex = 16;
            this.labelBirthday.Text = "Дата рождения";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.Location = new System.Drawing.Point(34, 283);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(41, 21);
            this.labelSex.TabIndex = 17;
            this.labelSex.Text = "Пол";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStreet.Location = new System.Drawing.Point(196, 329);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(57, 21);
            this.labelStreet.TabIndex = 18;
            this.labelStreet.Text = "Улица";
            // 
            // labelNumberHome
            // 
            this.labelNumberHome.AutoSize = true;
            this.labelNumberHome.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberHome.Location = new System.Drawing.Point(196, 396);
            this.labelNumberHome.Name = "labelNumberHome";
            this.labelNumberHome.Size = new System.Drawing.Size(63, 21);
            this.labelNumberHome.TabIndex = 19;
            this.labelNumberHome.Text = "Дом №";
            // 
            // labelNumberFlat
            // 
            this.labelNumberFlat.AutoSize = true;
            this.labelNumberFlat.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberFlat.Location = new System.Drawing.Point(332, 396);
            this.labelNumberFlat.Name = "labelNumberFlat";
            this.labelNumberFlat.Size = new System.Drawing.Size(32, 21);
            this.labelNumberFlat.TabIndex = 20;
            this.labelNumberFlat.Text = "Кв.";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(34, 356);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 21);
            this.labelAddress.TabIndex = 21;
            this.labelAddress.Text = "Адрес";
            // 
            // bttAdd
            // 
            this.bttAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd.Location = new System.Drawing.Point(52, 436);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(170, 37);
            this.bttAdd.TabIndex = 22;
            this.bttAdd.Text = "Сохранить";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttCenсel
            // 
            this.bttCenсel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCenсel.Location = new System.Drawing.Point(249, 436);
            this.bttCenсel.Name = "bttCenсel";
            this.bttCenсel.Size = new System.Drawing.Size(170, 37);
            this.bttCenсel.TabIndex = 23;
            this.bttCenсel.Text = "Отмена";
            this.bttCenсel.UseVisualStyleBackColor = true;
            this.bttCenсel.Click += new System.EventHandler(this.bttCenсel_Click);
            // 
            // WorkerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 505);
            this.Controls.Add(this.bttCenсel);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelNumberFlat);
            this.Controls.Add(this.labelNumberHome);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelExperience);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelThirdName);
            this.Controls.Add(this.labelSecondName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.tbNumberFlat);
            this.Controls.Add(this.tbNumberHome);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.DateBirthday);
            this.Controls.Add(this.tbExperience);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbThirdName);
            this.Controls.Add(this.tbSecondName);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(496, 544);
            this.MinimumSize = new System.Drawing.Size(496, 544);
            this.Name = "WorkerAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый сотрудник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.TextBox tbThirdName;
        private System.Windows.Forms.MaskedTextBox tbPhone;
        private System.Windows.Forms.TextBox tbExperience;
        private System.Windows.Forms.DateTimePicker DateBirthday;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbNumberHome;
        private System.Windows.Forms.TextBox tbNumberFlat;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelThirdName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelNumberHome;
        private System.Windows.Forms.Label labelNumberFlat;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttCenсel;
    }
}