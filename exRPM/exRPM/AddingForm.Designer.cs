namespace exRPM
{
    partial class AddingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbZen = new System.Windows.Forms.RadioButton();
            this.rbMuz = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbOplata = new System.Windows.Forms.CheckBox();
            this.cbFoto = new System.Windows.Forms.CheckBox();
            this.cbPassport = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(114, 15);
            this.tbLastName.MaxLength = 15;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 1;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(114, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 68);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(114, 54);
            this.tbFirstName.MaxLength = 15;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbZen);
            this.groupBox1.Controls.Add(this.rbMuz);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(253, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пол";
            // 
            // rbZen
            // 
            this.rbZen.AutoSize = true;
            this.rbZen.Location = new System.Drawing.Point(8, 64);
            this.rbZen.Name = "rbZen";
            this.rbZen.Size = new System.Drawing.Size(109, 29);
            this.rbZen.TabIndex = 0;
            this.rbZen.TabStop = true;
            this.rbZen.Text = "Женский";
            this.rbZen.UseVisualStyleBackColor = true;
            // 
            // rbMuz
            // 
            this.rbMuz.AutoSize = true;
            this.rbMuz.Location = new System.Drawing.Point(6, 29);
            this.rbMuz.Name = "rbMuz";
            this.rbMuz.Size = new System.Drawing.Size(111, 29);
            this.rbMuz.TabIndex = 0;
            this.rbMuz.TabStop = true;
            this.rbMuz.Text = "Мужской";
            this.rbMuz.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPassport);
            this.groupBox2.Controls.Add(this.cbFoto);
            this.groupBox2.Controls.Add(this.cbOplata);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 163);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оплата и документы";
            // 
            // cbOplata
            // 
            this.cbOplata.AutoSize = true;
            this.cbOplata.Location = new System.Drawing.Point(21, 40);
            this.cbOplata.Name = "cbOplata";
            this.cbOplata.Size = new System.Drawing.Size(118, 28);
            this.cbOplata.TabIndex = 0;
            this.cbOplata.Text = "Оплачено";
            this.cbOplata.UseVisualStyleBackColor = true;
            // 
            // cbFoto
            // 
            this.cbFoto.AutoSize = true;
            this.cbFoto.Location = new System.Drawing.Point(21, 74);
            this.cbFoto.Name = "cbFoto";
            this.cbFoto.Size = new System.Drawing.Size(138, 28);
            this.cbFoto.TabIndex = 0;
            this.cbFoto.Text = "Фото сданы";
            this.cbFoto.UseVisualStyleBackColor = true;
            // 
            // cbPassport
            // 
            this.cbPassport.AutoSize = true;
            this.cbPassport.Location = new System.Drawing.Point(21, 108);
            this.cbPassport.Name = "cbPassport";
            this.cbPassport.Size = new System.Drawing.Size(153, 28);
            this.cbPassport.TabIndex = 0;
            this.cbPassport.Text = "Паспорт сдан";
            this.cbPassport.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Направление тура:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Лондон",
            "Берлин",
            "Прага",
            "Париж",
            "Венеция",
            "село Вахрушево, Новосибирская область"});
            this.comboBox1.Location = new System.Drawing.Point(259, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Продолжительность тура:";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "7 дней",
            "15 дней",
            "20 дней",
            "25 дней",
            "30 дней",
            "45 дней",
            "60 дней"});
            this.comboBox2.Location = new System.Drawing.Point(259, 215);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(238, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(512, 369);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить запись в таблицу";
            this.Load += new System.EventHandler(this.AddingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox cbPassport;
        public System.Windows.Forms.CheckBox cbFoto;
        public System.Windows.Forms.CheckBox cbOplata;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.RadioButton rbZen;
        public System.Windows.Forms.RadioButton rbMuz;
    }
}