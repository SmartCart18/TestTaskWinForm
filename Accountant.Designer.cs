namespace TestTaskWinForm
{
    partial class Accountant
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
            this.comboEnterEmployee = new System.Windows.Forms.ComboBox();
            this.textAllEmployee = new System.Windows.Forms.TextBox();
            this.comboTypeDoc = new System.Windows.Forms.ComboBox();
            this.btnApplyChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboEnterEmployee
            // 
            this.comboEnterEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEnterEmployee.FormattingEnabled = true;
            this.comboEnterEmployee.Location = new System.Drawing.Point(13, 417);
            this.comboEnterEmployee.Name = "comboEnterEmployee";
            this.comboEnterEmployee.Size = new System.Drawing.Size(621, 21);
            this.comboEnterEmployee.TabIndex = 0;
            // 
            // textAllEmployee
            // 
            this.textAllEmployee.Location = new System.Drawing.Point(13, 13);
            this.textAllEmployee.Multiline = true;
            this.textAllEmployee.Name = "textAllEmployee";
            this.textAllEmployee.ReadOnly = true;
            this.textAllEmployee.Size = new System.Drawing.Size(621, 398);
            this.textAllEmployee.TabIndex = 1;
            // 
            // comboTypeDoc
            // 
            this.comboTypeDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypeDoc.FormattingEnabled = true;
            this.comboTypeDoc.Items.AddRange(new object[] {
            "Новый документ",
            "В работе",
            "Одобрена",
            "Отклонена",
            "Выдана/оформлена справка",
            "Завершено"});
            this.comboTypeDoc.Location = new System.Drawing.Point(640, 13);
            this.comboTypeDoc.Name = "comboTypeDoc";
            this.comboTypeDoc.Size = new System.Drawing.Size(121, 21);
            this.comboTypeDoc.TabIndex = 2;
            // 
            // btnApplyChange
            // 
            this.btnApplyChange.Location = new System.Drawing.Point(640, 415);
            this.btnApplyChange.Name = "btnApplyChange";
            this.btnApplyChange.Size = new System.Drawing.Size(121, 23);
            this.btnApplyChange.TabIndex = 3;
            this.btnApplyChange.Text = "Применить";
            this.btnApplyChange.UseVisualStyleBackColor = true;
            this.btnApplyChange.Click += new System.EventHandler(this.btnApplyChange_Click);
            // 
            // Accountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApplyChange);
            this.Controls.Add(this.comboTypeDoc);
            this.Controls.Add(this.textAllEmployee);
            this.Controls.Add(this.comboEnterEmployee);
            this.Name = "Accountant";
            this.Text = "Бухгалтер";
            this.Load += new System.EventHandler(this.Accountant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboEnterEmployee;
        private System.Windows.Forms.TextBox textAllEmployee;
        private System.Windows.Forms.ComboBox comboTypeDoc;
        private System.Windows.Forms.Button btnApplyChange;
    }
}