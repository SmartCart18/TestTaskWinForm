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
            this.components = new System.ComponentModel.Container();
            this.comboEnterEmployee = new System.Windows.Forms.ComboBox();
            this.textAllEmployee = new System.Windows.Forms.TextBox();
            this.comboStatusDoc = new System.Windows.Forms.ComboBox();
            this.btnApplyChange = new System.Windows.Forms.Button();
            this.btnCloseAcc = new System.Windows.Forms.Button();
            this.errorComboEmployee = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorComboStatusDoc = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorComboEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorComboStatusDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // comboEnterEmployee
            // 
            this.comboEnterEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEnterEmployee.FormattingEnabled = true;
            this.comboEnterEmployee.Location = new System.Drawing.Point(12, 416);
            this.comboEnterEmployee.Name = "comboEnterEmployee";
            this.comboEnterEmployee.Size = new System.Drawing.Size(621, 21);
            this.comboEnterEmployee.TabIndex = 0;
            // 
            // textAllEmployee
            // 
            this.textAllEmployee.Location = new System.Drawing.Point(12, 12);
            this.textAllEmployee.Multiline = true;
            this.textAllEmployee.Name = "textAllEmployee";
            this.textAllEmployee.ReadOnly = true;
            this.textAllEmployee.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textAllEmployee.Size = new System.Drawing.Size(621, 398);
            this.textAllEmployee.TabIndex = 1;
            // 
            // comboStatusDoc
            // 
            this.comboStatusDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatusDoc.FormattingEnabled = true;
            this.comboStatusDoc.Items.AddRange(new object[] {
            "Новый документ",
            "В работе",
            "Одобрена",
            "Отклонена",
            "Выдана/оформлена справка",
            "Завершено"});
            this.comboStatusDoc.Location = new System.Drawing.Point(662, 12);
            this.comboStatusDoc.Name = "comboStatusDoc";
            this.comboStatusDoc.Size = new System.Drawing.Size(121, 21);
            this.comboStatusDoc.TabIndex = 2;
            // 
            // btnApplyChange
            // 
            this.btnApplyChange.Location = new System.Drawing.Point(662, 414);
            this.btnApplyChange.Name = "btnApplyChange";
            this.btnApplyChange.Size = new System.Drawing.Size(121, 23);
            this.btnApplyChange.TabIndex = 3;
            this.btnApplyChange.Text = "Применить";
            this.btnApplyChange.UseVisualStyleBackColor = true;
            this.btnApplyChange.Click += new System.EventHandler(this.btnApplyChange_Click);
            // 
            // btnCloseAcc
            // 
            this.btnCloseAcc.Location = new System.Drawing.Point(662, 443);
            this.btnCloseAcc.Name = "btnCloseAcc";
            this.btnCloseAcc.Size = new System.Drawing.Size(121, 23);
            this.btnCloseAcc.TabIndex = 4;
            this.btnCloseAcc.Text = "Назад";
            this.btnCloseAcc.UseVisualStyleBackColor = true;
            this.btnCloseAcc.Click += new System.EventHandler(this.btnCloseAcc_Click);
            // 
            // errorComboEmployee
            // 
            this.errorComboEmployee.ContainerControl = this;
            // 
            // errorComboStatusDoc
            // 
            this.errorComboStatusDoc.ContainerControl = this;
            // 
            // Accountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 475);
            this.Controls.Add(this.btnCloseAcc);
            this.Controls.Add(this.btnApplyChange);
            this.Controls.Add(this.comboStatusDoc);
            this.Controls.Add(this.textAllEmployee);
            this.Controls.Add(this.comboEnterEmployee);
            this.Name = "Accountant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бухгалтер";
            this.Load += new System.EventHandler(this.Accountant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorComboEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorComboStatusDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboEnterEmployee;
        private System.Windows.Forms.TextBox textAllEmployee;
        private System.Windows.Forms.ComboBox comboStatusDoc;
        private System.Windows.Forms.Button btnApplyChange;
        private System.Windows.Forms.Button btnCloseAcc;
        private System.Windows.Forms.ErrorProvider errorComboEmployee;
        private System.Windows.Forms.ErrorProvider errorComboStatusDoc;
    }
}