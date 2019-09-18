namespace FitnessClub.Components.Forms
{
    partial class BuyClasses
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
            this.bttSave = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttSave
            // 
            this.bttSave.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSave.Location = new System.Drawing.Point(59, 93);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(141, 38);
            this.bttSave.TabIndex = 0;
            this.bttSave.Text = "Сохранить";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(36, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 21);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            // 
            // tbCount
            // 
            this.tbCount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCount.Location = new System.Drawing.Point(78, 59);
            this.tbCount.MaxLength = 3;
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(96, 28);
            this.tbCount.TabIndex = 2;
            this.tbCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCount_KeyPress);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(36, 11);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(52, 21);
            this.labelGroup.TabIndex = 3;
            this.labelGroup.Text = "label1";
            // 
            // BuyClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 139);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.bttSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(282, 178);
            this.MinimumSize = new System.Drawing.Size(282, 178);
            this.Name = "BuyClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyClasses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.TextBox tbCount;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label labelGroup;
    }
}