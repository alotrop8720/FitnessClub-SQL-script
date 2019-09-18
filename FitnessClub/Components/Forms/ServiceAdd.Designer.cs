namespace FitnessClub.Forms
{
    partial class ServiceAdd
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelHouse = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbHouse = new System.Windows.Forms.ComboBox();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttCanсel = new System.Windows.Forms.Button();
            this.labelAddHouse = new System.Windows.Forms.Label();
            this.labelAddPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(29, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(127, 21);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Нзвание услуги";
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHouse.Location = new System.Drawing.Point(29, 82);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(188, 21);
            this.labelHouse.TabIndex = 1;
            this.labelHouse.Text = "Длительность занятия";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(29, 117);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(178, 21);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Цена за одно занятие";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(228, 45);
            this.tbName.MaxLength = 20;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(195, 28);
            this.tbName.TabIndex = 3;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // cbHouse
            // 
            this.cbHouse.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHouse.FormattingEnabled = true;
            this.cbHouse.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbHouse.Location = new System.Drawing.Point(228, 79);
            this.cbHouse.Name = "cbHouse";
            this.cbHouse.Size = new System.Drawing.Size(136, 29);
            this.cbHouse.TabIndex = 5;
            this.cbHouse.Text = "1";
            this.cbHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbHouse_KeyPress);
            // 
            // bttAdd
            // 
            this.bttAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd.Location = new System.Drawing.Point(39, 158);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(170, 37);
            this.bttAdd.TabIndex = 6;
            this.bttAdd.Text = "Сохранить\r\n";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttCanсel
            // 
            this.bttCanсel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCanсel.Location = new System.Drawing.Point(228, 158);
            this.bttCanсel.Name = "bttCanсel";
            this.bttCanсel.Size = new System.Drawing.Size(170, 37);
            this.bttCanсel.TabIndex = 7;
            this.bttCanсel.Text = "Отмена";
            this.bttCanсel.UseVisualStyleBackColor = true;
            this.bttCanсel.Click += new System.EventHandler(this.bttCanсel_Click);
            // 
            // labelAddHouse
            // 
            this.labelAddHouse.AutoSize = true;
            this.labelAddHouse.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddHouse.Location = new System.Drawing.Point(378, 82);
            this.labelAddHouse.Name = "labelAddHouse";
            this.labelAddHouse.Size = new System.Drawing.Size(35, 21);
            this.labelAddHouse.TabIndex = 8;
            this.labelAddHouse.Text = "чаc";
            // 
            // labelAddPrice
            // 
            this.labelAddPrice.AutoSize = true;
            this.labelAddPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddPrice.Location = new System.Drawing.Point(378, 121);
            this.labelAddPrice.Name = "labelAddPrice";
            this.labelAddPrice.Size = new System.Drawing.Size(38, 21);
            this.labelAddPrice.TabIndex = 9;
            this.labelAddPrice.Text = "руб.";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(228, 114);
            this.tbPrice.MaxLength = 3;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(136, 28);
            this.tbPrice.TabIndex = 10;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // ServiceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 223);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.labelAddPrice);
            this.Controls.Add(this.labelAddHouse);
            this.Controls.Add(this.bttCanсel);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.cbHouse);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelHouse);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(463, 262);
            this.MinimumSize = new System.Drawing.Size(463, 262);
            this.Name = "ServiceAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая услуга";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbHouse;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttCanсel;
        private System.Windows.Forms.Label labelAddHouse;
        private System.Windows.Forms.Label labelAddPrice;
        private System.Windows.Forms.TextBox tbPrice;
    }
}