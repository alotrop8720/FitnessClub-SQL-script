namespace FitnessClub.Forms
{
    partial class CustomeAdd
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
            this.DateBirthday = new System.Windows.Forms.DateTimePicker();
            this.bttAdd = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelThirdName = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.bttCanсel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(205, 41);
            this.tbName.MaxLength = 30;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(234, 28);
            this.tbName.TabIndex = 1;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbSecondName
            // 
            this.tbSecondName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSecondName.Location = new System.Drawing.Point(205, 75);
            this.tbSecondName.MaxLength = 30;
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(234, 28);
            this.tbSecondName.TabIndex = 2;
            this.tbSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbThirdName
            // 
            this.tbThirdName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThirdName.Location = new System.Drawing.Point(205, 109);
            this.tbThirdName.MaxLength = 30;
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.Size = new System.Drawing.Size(234, 28);
            this.tbThirdName.TabIndex = 3;
            this.tbThirdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(205, 235);
            this.tbPhone.Mask = "+375 (99) 000-0000";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(234, 28);
            this.tbPhone.TabIndex = 5;
            // 
            // DateBirthday
            // 
            this.DateBirthday.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBirthday.Location = new System.Drawing.Point(205, 167);
            this.DateBirthday.Name = "DateBirthday";
            this.DateBirthday.Size = new System.Drawing.Size(234, 28);
            this.DateBirthday.TabIndex = 6;
            // 
            // bttAdd
            // 
            this.bttAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd.Location = new System.Drawing.Point(57, 281);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(170, 37);
            this.bttAdd.TabIndex = 7;
            this.bttAdd.Text = "Сохранить";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(34, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 21);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Имя";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecondName.Location = new System.Drawing.Point(34, 82);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(82, 21);
            this.labelSecondName.TabIndex = 9;
            this.labelSecondName.Text = "Фамилия";
            // 
            // labelThirdName
            // 
            this.labelThirdName.AutoSize = true;
            this.labelThirdName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThirdName.Location = new System.Drawing.Point(34, 116);
            this.labelThirdName.Name = "labelThirdName";
            this.labelThirdName.Size = new System.Drawing.Size(84, 21);
            this.labelThirdName.TabIndex = 10;
            this.labelThirdName.Text = "Отчество";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.Location = new System.Drawing.Point(34, 174);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(129, 21);
            this.labelBirthday.TabIndex = 11;
            this.labelBirthday.Text = "Дата рождения";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.Location = new System.Drawing.Point(34, 206);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(41, 21);
            this.labelSex.TabIndex = 12;
            this.labelSex.Text = "Пол";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(34, 242);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(143, 21);
            this.labelPhone.TabIndex = 13;
            this.labelPhone.Text = "Номер Телефона";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(205, 202);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(93, 25);
            this.rbFemale.TabIndex = 14;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Женский";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(324, 202);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(93, 25);
            this.rbMale.TabIndex = 15;
            this.rbMale.Text = "Мужской";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // bttCanсel
            // 
            this.bttCanсel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCanсel.Location = new System.Drawing.Point(233, 281);
            this.bttCanсel.Name = "bttCanсel";
            this.bttCanсel.Size = new System.Drawing.Size(170, 37);
            this.bttCanсel.TabIndex = 16;
            this.bttCanсel.Text = "Отмена";
            this.bttCanсel.UseVisualStyleBackColor = true;
            this.bttCanсel.Click += new System.EventHandler(this.bttCanсel_Click);
            // 
            // CustomeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 359);
            this.Controls.Add(this.bttCanсel);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelThirdName);
            this.Controls.Add(this.labelSecondName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.DateBirthday);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbThirdName);
            this.Controls.Add(this.tbSecondName);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(496, 398);
            this.MinimumSize = new System.Drawing.Size(496, 398);
            this.Name = "CustomeAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.TextBox tbThirdName;
        private System.Windows.Forms.MaskedTextBox tbPhone;
        private System.Windows.Forms.DateTimePicker DateBirthday;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelThirdName;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button bttCanсel;
    }
}