namespace FitnessClub.Components.Forms
{
    partial class BuyForm
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
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelCountClassGroup = new System.Windows.Forms.Label();
            this.labelCountClassThisGroup = new System.Windows.Forms.Label();
            this.labelCountBuyAll = new System.Windows.Forms.Label();
            this.labelCountBuyWillAll = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPriceOneClass = new System.Windows.Forms.Label();
            this.labelPriceWillAll = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAddPrice = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.bttSave = new System.Windows.Forms.Button();
            this.labelAddSum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(12, 10);
            this.labelGroup.Margin = new System.Windows.Forms.Padding(0);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(62, 21);
            this.labelGroup.TabIndex = 0;
            this.labelGroup.Text = "Группа";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.Location = new System.Drawing.Point(12, 42);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(66, 21);
            this.labelCustomer.TabIndex = 1;
            this.labelCustomer.Text = "Клиент";
            // 
            // labelCountClassGroup
            // 
            this.labelCountClassGroup.AutoSize = true;
            this.labelCountClassGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountClassGroup.Location = new System.Drawing.Point(12, 72);
            this.labelCountClassGroup.Name = "labelCountClassGroup";
            this.labelCountClassGroup.Size = new System.Drawing.Size(227, 21);
            this.labelCountClassGroup.TabIndex = 2;
            this.labelCountClassGroup.Text = "Всего занятий в этой группе";
            // 
            // labelCountClassThisGroup
            // 
            this.labelCountClassThisGroup.AutoSize = true;
            this.labelCountClassThisGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountClassThisGroup.Location = new System.Drawing.Point(8, 149);
            this.labelCountClassThisGroup.Name = "labelCountClassThisGroup";
            this.labelCountClassThisGroup.Size = new System.Drawing.Size(171, 42);
            this.labelCountClassThisGroup.TabIndex = 3;
            this.labelCountClassThisGroup.Text = "Количество занятий \r\nв этой группе";
            // 
            // labelCountBuyAll
            // 
            this.labelCountBuyAll.AutoSize = true;
            this.labelCountBuyAll.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountBuyAll.Location = new System.Drawing.Point(8, 204);
            this.labelCountBuyAll.Name = "labelCountBuyAll";
            this.labelCountBuyAll.Size = new System.Drawing.Size(191, 42);
            this.labelCountBuyAll.TabIndex = 4;
            this.labelCountBuyAll.Text = "Количество оплаченых \r\nвсего";
            // 
            // labelCountBuyWillAll
            // 
            this.labelCountBuyWillAll.AutoSize = true;
            this.labelCountBuyWillAll.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountBuyWillAll.Location = new System.Drawing.Point(8, 253);
            this.labelCountBuyWillAll.Name = "labelCountBuyWillAll";
            this.labelCountBuyWillAll.Size = new System.Drawing.Size(235, 42);
            this.labelCountBuyWillAll.TabIndex = 5;
            this.labelCountBuyWillAll.Text = "Количество занятий которые\r\nнадо оплатить";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(437, 197);
            this.tbPrice.MaxLength = 12;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(76, 28);
            this.tbPrice.TabIndex = 6;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(284, 204);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(147, 21);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "За сколько плаим";
            // 
            // labelPriceOneClass
            // 
            this.labelPriceOneClass.AutoSize = true;
            this.labelPriceOneClass.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceOneClass.Location = new System.Drawing.Point(12, 102);
            this.labelPriceOneClass.Name = "labelPriceOneClass";
            this.labelPriceOneClass.Size = new System.Drawing.Size(178, 21);
            this.labelPriceOneClass.TabIndex = 8;
            this.labelPriceOneClass.Text = "Цена за одно занятие";
            // 
            // labelPriceWillAll
            // 
            this.labelPriceWillAll.AutoSize = true;
            this.labelPriceWillAll.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceWillAll.Location = new System.Drawing.Point(284, 170);
            this.labelPriceWillAll.Name = "labelPriceWillAll";
            this.labelPriceWillAll.Size = new System.Drawing.Size(197, 21);
            this.labelPriceWillAll.TabIndex = 10;
            this.labelPriceWillAll.Text = "Сколько надо оплатить ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.labelGroup);
            this.panel1.Controls.Add(this.labelCustomer);
            this.panel1.Controls.Add(this.labelCountClassGroup);
            this.panel1.Controls.Add(this.labelPriceOneClass);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 134);
            this.panel1.TabIndex = 11;
            // 
            // labelAddPrice
            // 
            this.labelAddPrice.AutoSize = true;
            this.labelAddPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddPrice.Location = new System.Drawing.Point(531, 170);
            this.labelAddPrice.Name = "labelAddPrice";
            this.labelAddPrice.Size = new System.Drawing.Size(38, 21);
            this.labelAddPrice.TabIndex = 12;
            this.labelAddPrice.Text = "руб.";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSum.Location = new System.Drawing.Point(372, 241);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(59, 21);
            this.labelSum.TabIndex = 13;
            this.labelSum.Text = "Сумма";
            // 
            // bttSave
            // 
            this.bttSave.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSave.Location = new System.Drawing.Point(399, 289);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(170, 37);
            this.bttSave.TabIndex = 14;
            this.bttSave.Text = "Сохранить";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // labelAddSum
            // 
            this.labelAddSum.AutoSize = true;
            this.labelAddSum.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddSum.Location = new System.Drawing.Point(531, 241);
            this.labelAddSum.Name = "labelAddSum";
            this.labelAddSum.Size = new System.Drawing.Size(38, 21);
            this.labelAddSum.TabIndex = 15;
            this.labelAddSum.Text = "руб.";
            // 
            // BuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 338);
            this.Controls.Add(this.labelAddSum);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelAddPrice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelPriceWillAll);
            this.Controls.Add(this.labelCountClassThisGroup);
            this.Controls.Add(this.labelCountBuyAll);
            this.Controls.Add(this.labelCountBuyWillAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(597, 377);
            this.MinimumSize = new System.Drawing.Size(597, 377);
            this.Name = "BuyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплата";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuyForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelCountClassGroup;
        private System.Windows.Forms.Label labelCountClassThisGroup;
        private System.Windows.Forms.Label labelCountBuyAll;
        private System.Windows.Forms.Label labelCountBuyWillAll;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelPriceOneClass;
        private System.Windows.Forms.Label labelPriceWillAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAddPrice;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Button bttSave;
        public System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label labelAddSum;
    }
}