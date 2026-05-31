namespace Lab12
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxTemplates = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.txtFaxNotes = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtFaxText = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtFaxCopy = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtFaxGoal = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtFaxDate = new System.Windows.Forms.TextBox();
            this.txtToUser = new System.Windows.Forms.TextBox();
            this.txtFaxPhone = new System.Windows.Forms.TextBox();
            this.txtFromUser = new System.Windows.Forms.TextBox();
            this.txtFaxPage = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl12 = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.lbl11 = new System.Windows.Forms.Label();
            this.btnFindReplace = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTemplates
            // 
            this.comboBoxTemplates.FormattingEnabled = true;
            this.comboBoxTemplates.Location = new System.Drawing.Point(379, 207);
            this.comboBoxTemplates.Name = "comboBoxTemplates";
            this.comboBoxTemplates.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTemplates.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl10);
            this.groupBox1.Controls.Add(this.lbl9);
            this.groupBox1.Controls.Add(this.lbl8);
            this.groupBox1.Controls.Add(this.lbl7);
            this.groupBox1.Controls.Add(this.lbl6);
            this.groupBox1.Controls.Add(this.txtFaxNotes);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.txtFaxText);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.txtFaxCopy);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.txtFaxGoal);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.txtFaxDate);
            this.groupBox1.Controls.Add(this.txtToUser);
            this.groupBox1.Controls.Add(this.txtFaxPhone);
            this.groupBox1.Controls.Add(this.txtFromUser);
            this.groupBox1.Controls.Add(this.txtFaxPage);
            this.groupBox1.Controls.Add(this.txtFax);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 285);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(8, 250);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(57, 13);
            this.lbl10.TabIndex = 26;
            this.lbl10.Text = "Примітки:";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(6, 226);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(40, 13);
            this.lbl9.TabIndex = 25;
            this.lbl9.Text = "Текст:";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(6, 203);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(37, 13);
            this.lbl8.TabIndex = 24;
            this.lbl8.Text = "Копія:";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(6, 177);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(24, 13);
            this.lbl7.TabIndex = 23;
            this.lbl7.Text = "На:";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(6, 153);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(36, 13);
            this.lbl6.TabIndex = 22;
            this.lbl6.Text = "Дата:";
            // 
            // txtFaxNotes
            // 
            this.txtFaxNotes.Location = new System.Drawing.Point(91, 247);
            this.txtFaxNotes.Multiline = true;
            this.txtFaxNotes.Name = "txtFaxNotes";
            this.txtFaxNotes.Size = new System.Drawing.Size(65, 20);
            this.txtFaxNotes.TabIndex = 12;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(6, 129);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(55, 13);
            this.lbl5.TabIndex = 21;
            this.lbl5.Text = "Телефон:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(6, 105);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(54, 13);
            this.lbl4.TabIndex = 20;
            this.lbl4.Text = "Сторінки:";
            // 
            // txtFaxText
            // 
            this.txtFaxText.Location = new System.Drawing.Point(91, 223);
            this.txtFaxText.Multiline = true;
            this.txtFaxText.Name = "txtFaxText";
            this.txtFaxText.Size = new System.Drawing.Size(65, 20);
            this.txtFaxText.TabIndex = 10;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(6, 79);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(39, 13);
            this.lbl3.TabIndex = 19;
            this.lbl3.Text = "Факс:";
            // 
            // txtFaxCopy
            // 
            this.txtFaxCopy.Location = new System.Drawing.Point(91, 200);
            this.txtFaxCopy.Name = "txtFaxCopy";
            this.txtFaxCopy.Size = new System.Drawing.Size(65, 20);
            this.txtFaxCopy.TabIndex = 9;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(6, 54);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(25, 13);
            this.lbl2.TabIndex = 18;
            this.lbl2.Text = "Від:";
            // 
            // txtFaxGoal
            // 
            this.txtFaxGoal.Location = new System.Drawing.Point(91, 174);
            this.txtFaxGoal.Name = "txtFaxGoal";
            this.txtFaxGoal.Size = new System.Drawing.Size(65, 20);
            this.txtFaxGoal.TabIndex = 8;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(36, 13);
            this.lbl1.TabIndex = 17;
            this.lbl1.Text = "Кому:";
            // 
            // txtFaxDate
            // 
            this.txtFaxDate.Location = new System.Drawing.Point(91, 150);
            this.txtFaxDate.Name = "txtFaxDate";
            this.txtFaxDate.Size = new System.Drawing.Size(65, 20);
            this.txtFaxDate.TabIndex = 7;
            // 
            // txtToUser
            // 
            this.txtToUser.Location = new System.Drawing.Point(91, 25);
            this.txtToUser.Name = "txtToUser";
            this.txtToUser.Size = new System.Drawing.Size(65, 20);
            this.txtToUser.TabIndex = 2;
            // 
            // txtFaxPhone
            // 
            this.txtFaxPhone.Location = new System.Drawing.Point(91, 126);
            this.txtFaxPhone.Name = "txtFaxPhone";
            this.txtFaxPhone.Size = new System.Drawing.Size(65, 20);
            this.txtFaxPhone.TabIndex = 6;
            // 
            // txtFromUser
            // 
            this.txtFromUser.Location = new System.Drawing.Point(91, 51);
            this.txtFromUser.Name = "txtFromUser";
            this.txtFromUser.Size = new System.Drawing.Size(65, 20);
            this.txtFromUser.TabIndex = 3;
            // 
            // txtFaxPage
            // 
            this.txtFaxPage.Location = new System.Drawing.Point(91, 102);
            this.txtFaxPage.Name = "txtFaxPage";
            this.txtFaxPage.Size = new System.Drawing.Size(65, 20);
            this.txtFaxPage.TabIndex = 5;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(91, 76);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(65, 20);
            this.txtFax.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl12);
            this.groupBox2.Controls.Add(this.txtReplace);
            this.groupBox2.Controls.Add(this.lbl11);
            this.groupBox2.Controls.Add(this.btnFindReplace);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(379, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 166);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Location = new System.Drawing.Point(15, 51);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(84, 13);
            this.lbl12.TabIndex = 1;
            this.lbl12.Text = "На що змінити:";
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(111, 48);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(65, 20);
            this.txtReplace.TabIndex = 17;
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(15, 25);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(64, 13);
            this.lbl11.TabIndex = 0;
            this.lbl11.Text = "Що знайти:";
            // 
            // btnFindReplace
            // 
            this.btnFindReplace.Location = new System.Drawing.Point(18, 95);
            this.btnFindReplace.Name = "btnFindReplace";
            this.btnFindReplace.Size = new System.Drawing.Size(75, 23);
            this.btnFindReplace.TabIndex = 14;
            this.btnFindReplace.Text = "Виконати заміну";
            this.btnFindReplace.UseVisualStyleBackColor = true;
            this.btnFindReplace.Click += new System.EventHandler(this.btnFindReplace_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(111, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(65, 20);
            this.txtSearch.TabIndex = 13;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(573, 210);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(121, 23);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Створити документ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(573, 252);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(99, 23);
            this.btnSaveAs.TabIndex = 16;
            this.btnSaveAs.Text = "Зберегти як...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxTemplates);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTemplates;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtToUser;
        private System.Windows.Forms.TextBox txtFromUser;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtFaxPage;
        private System.Windows.Forms.TextBox txtFaxPhone;
        private System.Windows.Forms.TextBox txtFaxDate;
        private System.Windows.Forms.TextBox txtFaxGoal;
        private System.Windows.Forms.TextBox txtFaxCopy;
        private System.Windows.Forms.TextBox txtFaxText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFaxNotes;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFindReplace;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl11;
    }
}

