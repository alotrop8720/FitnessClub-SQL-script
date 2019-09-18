namespace FitnessClub.Components.Forms
{
    partial class RecordGroupAdd
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
            this.cbGroups = new System.Windows.Forms.ComboBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.DateRecord = new System.Windows.Forms.DateTimePicker();
            this.tbCountClasses = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelDateRecord = new System.Windows.Forms.Label();
            this.labelCountClasses = new System.Windows.Forms.Label();
            this.bttAddGroup = new System.Windows.Forms.Button();
            this.bttCustomer = new System.Windows.Forms.Button();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.bttBuyClasses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbGroups
            // 
            this.cbGroups.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroups.FormattingEnabled = true;
            this.cbGroups.Location = new System.Drawing.Point(234, 46);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.Size = new System.Drawing.Size(172, 29);
            this.cbGroups.TabIndex = 0;
            this.cbGroups.DropDown += new System.EventHandler(this.cbGroups_DropDown);
            // 
            // cbCustomer
            // 
            this.cbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(234, 81);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(172, 29);
            this.cbCustomer.TabIndex = 1;
            this.cbCustomer.DropDown += new System.EventHandler(this.cbCustomer_DropDown);
            // 
            // DateRecord
            // 
            this.DateRecord.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRecord.Location = new System.Drawing.Point(234, 116);
            this.DateRecord.Name = "DateRecord";
            this.DateRecord.Size = new System.Drawing.Size(214, 28);
            this.DateRecord.TabIndex = 2;
            this.DateRecord.ValueChanged += new System.EventHandler(this.DateRecord_ValueChanged);
            // 
            // tbCountClasses
            // 
            this.tbCountClasses.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountClasses.Location = new System.Drawing.Point(234, 150);
            this.tbCountClasses.Name = "tbCountClasses";
            this.tbCountClasses.Size = new System.Drawing.Size(77, 28);
            this.tbCountClasses.TabIndex = 3;
            this.tbCountClasses.Text = "0";
            this.tbCountClasses.TextChanged += new System.EventHandler(this.tbCountClasses_TextChanged);
            this.tbCountClasses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCountClasses_KeyPress);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(34, 48);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(62, 21);
            this.labelGroup.TabIndex = 4;
            this.labelGroup.Text = "Группа";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.Location = new System.Drawing.Point(34, 84);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(66, 21);
            this.labelCustomer.TabIndex = 5;
            this.labelCustomer.Text = "Клиент";
            // 
            // labelDateRecord
            // 
            this.labelDateRecord.AutoSize = true;
            this.labelDateRecord.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateRecord.Location = new System.Drawing.Point(34, 121);
            this.labelDateRecord.Name = "labelDateRecord";
            this.labelDateRecord.Size = new System.Drawing.Size(105, 21);
            this.labelDateRecord.TabIndex = 6;
            this.labelDateRecord.Text = "Дата записи";
            // 
            // labelCountClasses
            // 
            this.labelCountClasses.AutoSize = true;
            this.labelCountClasses.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountClasses.Location = new System.Drawing.Point(34, 153);
            this.labelCountClasses.Name = "labelCountClasses";
            this.labelCountClasses.Size = new System.Drawing.Size(187, 42);
            this.labelCountClasses.TabIndex = 7;
            this.labelCountClasses.Text = "Количество оплаченых\r\nзанятий";
            // 
            // bttAddGroup
            // 
            this.bttAddGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAddGroup.Image = global::FitnessClub.Properties.Resources.plus;
            this.bttAddGroup.Location = new System.Drawing.Point(413, 46);
            this.bttAddGroup.Name = "bttAddGroup";
            this.bttAddGroup.Size = new System.Drawing.Size(35, 29);
            this.bttAddGroup.TabIndex = 8;
            this.bttAddGroup.UseVisualStyleBackColor = true;
            this.bttAddGroup.Click += new System.EventHandler(this.bttAddGroup_Click);
            // 
            // bttCustomer
            // 
            this.bttCustomer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCustomer.Image = global::FitnessClub.Properties.Resources.plus;
            this.bttCustomer.Location = new System.Drawing.Point(413, 81);
            this.bttCustomer.Name = "bttCustomer";
            this.bttCustomer.Size = new System.Drawing.Size(35, 29);
            this.bttCustomer.TabIndex = 9;
            this.bttCustomer.UseVisualStyleBackColor = true;
            this.bttCustomer.Click += new System.EventHandler(this.bttCustomer_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd.Location = new System.Drawing.Point(71, 201);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(170, 37);
            this.bttAdd.TabIndex = 10;
            this.bttAdd.Text = "Сохранить";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancel.Location = new System.Drawing.Point(247, 201);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(170, 37);
            this.bttCancel.TabIndex = 11;
            this.bttCancel.Text = "Отмена";
            this.bttCancel.UseVisualStyleBackColor = true;
            // 
            // bttBuyClasses
            // 
            this.bttBuyClasses.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttBuyClasses.Location = new System.Drawing.Point(317, 150);
            this.bttBuyClasses.Name = "bttBuyClasses";
            this.bttBuyClasses.Size = new System.Drawing.Size(131, 28);
            this.bttBuyClasses.TabIndex = 12;
            this.bttBuyClasses.Text = "Оплата";
            this.bttBuyClasses.UseVisualStyleBackColor = true;
            this.bttBuyClasses.Click += new System.EventHandler(this.bttBuyClasses_Click);
            // 
            // RecordGroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 270);
            this.Controls.Add(this.bttBuyClasses);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.bttCustomer);
            this.Controls.Add(this.bttAddGroup);
            this.Controls.Add(this.labelCountClasses);
            this.Controls.Add(this.labelDateRecord);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.tbCountClasses);
            this.Controls.Add(this.DateRecord);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.cbGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(497, 309);
            this.MinimumSize = new System.Drawing.Size(497, 309);
            this.Name = "RecordGroupAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая запись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGroups;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.DateTimePicker DateRecord;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelDateRecord;
        private System.Windows.Forms.Label labelCountClasses;
        private System.Windows.Forms.Button bttAddGroup;
        private System.Windows.Forms.Button bttCustomer;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Button bttBuyClasses;
        public System.Windows.Forms.TextBox tbCountClasses;
    }
}