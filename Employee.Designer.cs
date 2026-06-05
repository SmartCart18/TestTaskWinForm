namespace TestTaskWinForm
{
    partial class Employee
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
            this.btnRequestDoc = new System.Windows.Forms.Button();
            this.textFullName = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textTypeDocument = new System.Windows.Forms.ComboBox();
            this.otherTypeDoc = new System.Windows.Forms.TextBox();
            this.QuantityDocument = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textReasonRequest = new System.Windows.Forms.TextBox();
            this.btnStatusRequestDoc = new System.Windows.Forms.Button();
            this.errorTypeDocument = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorReasonRequest = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorOtherTypeDoc = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnCloseEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTypeDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorReasonRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorOtherTypeDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRequestDoc
            // 
            this.btnRequestDoc.Location = new System.Drawing.Point(56, 350);
            this.btnRequestDoc.Name = "btnRequestDoc";
            this.btnRequestDoc.Size = new System.Drawing.Size(177, 47);
            this.btnRequestDoc.TabIndex = 0;
            this.btnRequestDoc.Text = "Отправить заявук";
            this.btnRequestDoc.UseVisualStyleBackColor = true;
            this.btnRequestDoc.Click += new System.EventHandler(this.btnRequestDoc_Click);
            // 
            // textFullName
            // 
            this.textFullName.Location = new System.Drawing.Point(40, 70);
            this.textFullName.Name = "textFullName";
            this.textFullName.Size = new System.Drawing.Size(288, 20);
            this.textFullName.TabIndex = 1;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // textTypeDocument
            // 
            this.textTypeDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textTypeDocument.FormattingEnabled = true;
            this.textTypeDocument.Items.AddRange(new object[] {
            "2-НДФЛ",
            "Справка о месте работы и стаж",
            "Справка о среднем заработке",
            "Другое"});
            this.textTypeDocument.Location = new System.Drawing.Point(40, 130);
            this.textTypeDocument.Name = "textTypeDocument";
            this.textTypeDocument.Size = new System.Drawing.Size(288, 21);
            this.textTypeDocument.TabIndex = 3;
            this.textTypeDocument.SelectedIndexChanged += new System.EventHandler(this.TypeDocument_SelectedIndexChanged);
            // 
            // otherTypeDoc
            // 
            this.otherTypeDoc.Location = new System.Drawing.Point(352, 131);
            this.otherTypeDoc.Name = "otherTypeDoc";
            this.otherTypeDoc.Size = new System.Drawing.Size(279, 20);
            this.otherTypeDoc.TabIndex = 4;
            this.otherTypeDoc.Visible = false;
            // 
            // QuantityDocument
            // 
            this.QuantityDocument.Location = new System.Drawing.Point(40, 186);
            this.QuantityDocument.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.QuantityDocument.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityDocument.Name = "QuantityDocument";
            this.QuantityDocument.Size = new System.Drawing.Size(120, 20);
            this.QuantityDocument.TabIndex = 5;
            this.QuantityDocument.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вид справки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество экземпляров";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Причина запроса";
            // 
            // textReasonRequest
            // 
            this.textReasonRequest.Location = new System.Drawing.Point(40, 240);
            this.textReasonRequest.Multiline = true;
            this.textReasonRequest.Name = "textReasonRequest";
            this.textReasonRequest.Size = new System.Drawing.Size(288, 67);
            this.textReasonRequest.TabIndex = 9;
            // 
            // btnStatusRequestDoc
            // 
            this.btnStatusRequestDoc.Location = new System.Drawing.Point(446, 350);
            this.btnStatusRequestDoc.Name = "btnStatusRequestDoc";
            this.btnStatusRequestDoc.Size = new System.Drawing.Size(176, 47);
            this.btnStatusRequestDoc.TabIndex = 10;
            this.btnStatusRequestDoc.Text = "Просмотреть справки";
            this.btnStatusRequestDoc.UseVisualStyleBackColor = true;
            this.btnStatusRequestDoc.Click += new System.EventHandler(this.btnStatusRequestDoc_Click);
            // 
            // errorTypeDocument
            // 
            this.errorTypeDocument.ContainerControl = this;
            // 
            // errorReasonRequest
            // 
            this.errorReasonRequest.ContainerControl = this;
            // 
            // errorOtherTypeDoc
            // 
            this.errorOtherTypeDoc.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Для просмотра справки заполните поле ФИО";
            // 
            // btnCloseEmp
            // 
            this.btnCloseEmp.Location = new System.Drawing.Point(288, 410);
            this.btnCloseEmp.Name = "btnCloseEmp";
            this.btnCloseEmp.Size = new System.Drawing.Size(102, 23);
            this.btnCloseEmp.TabIndex = 12;
            this.btnCloseEmp.Text = "Назад";
            this.btnCloseEmp.UseVisualStyleBackColor = true;
            this.btnCloseEmp.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 458);
            this.Controls.Add(this.btnCloseEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStatusRequestDoc);
            this.Controls.Add(this.textReasonRequest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuantityDocument);
            this.Controls.Add(this.otherTypeDoc);
            this.Controls.Add(this.textTypeDocument);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFullName);
            this.Controls.Add(this.btnRequestDoc);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTypeDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorReasonRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorOtherTypeDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRequestDoc;
        private System.Windows.Forms.TextBox textFullName;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox textTypeDocument;
        private System.Windows.Forms.TextBox otherTypeDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown QuantityDocument;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textReasonRequest;
        private System.Windows.Forms.Button btnStatusRequestDoc;
        private System.Windows.Forms.ErrorProvider errorTypeDocument;
        private System.Windows.Forms.ErrorProvider errorReasonRequest;
        private System.Windows.Forms.ErrorProvider errorOtherTypeDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCloseEmp;
    }
}