namespace FitnessClub.Components.Forms
{
    partial class VisitAdd
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
            this.cbLustCustomer = new System.Windows.Forms.CheckedListBox();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelVisit = new System.Windows.Forms.Label();
            this.bttAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbLustCustomer
            // 
            this.cbLustCustomer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLustCustomer.FormattingEnabled = true;
            this.cbLustCustomer.Location = new System.Drawing.Point(9, 70);
            this.cbLustCustomer.Name = "cbLustCustomer";
            this.cbLustCustomer.Size = new System.Drawing.Size(339, 326);
            this.cbLustCustomer.TabIndex = 0;
            // 
            // cbGroup
            // 
            this.cbGroup.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(205, 35);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(143, 29);
            this.cbGroup.TabIndex = 1;
            this.cbGroup.DropDown += new System.EventHandler(this.cbGroup_DropDown);
            this.cbGroup.TextChanged += new System.EventHandler(this.cbGroup_TextChanged);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(135, 38);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(64, 21);
            this.labelGroup.TabIndex = 2;
            this.labelGroup.Text = "Группы";
            // 
            // labelVisit
            // 
            this.labelVisit.AutoSize = true;
            this.labelVisit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisit.Location = new System.Drawing.Point(8, 9);
            this.labelVisit.Name = "labelVisit";
            this.labelVisit.Size = new System.Drawing.Size(203, 21);
            this.labelVisit.TabIndex = 3;
            this.labelVisit.Text = "Отметить посещаемость";
            // 
            // bttAdd
            // 
            this.bttAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd.Location = new System.Drawing.Point(162, 402);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(186, 39);
            this.bttAdd.TabIndex = 4;
            this.bttAdd.Text = "Сохранить";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // VisitAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 447);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.labelVisit);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.cbLustCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(376, 486);
            this.MinimumSize = new System.Drawing.Size(376, 486);
            this.Name = "VisitAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Посещения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cbLustCustomer;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelVisit;
        private System.Windows.Forms.Button bttAdd;
    }
}