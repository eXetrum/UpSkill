namespace UpSkill
{
    partial class TeacherAddEditForm
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.txt_teacher_surname = new System.Windows.Forms.TextBox();
            this.txt_teacher_patronymic = new System.Windows.Forms.TextBox();
            this.txt_teacher_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_teacher_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_teacher_tel = new System.Windows.Forms.TextBox();
            this.txt_teacher_experience = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(163, 166);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(12, 166);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 7;
            this.btn_confirm.Text = "Добавить";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // txt_teacher_surname
            // 
            this.txt_teacher_surname.Location = new System.Drawing.Point(138, 31);
            this.txt_teacher_surname.Name = "txt_teacher_surname";
            this.txt_teacher_surname.Size = new System.Drawing.Size(100, 20);
            this.txt_teacher_surname.TabIndex = 2;
            // 
            // txt_teacher_patronymic
            // 
            this.txt_teacher_patronymic.Location = new System.Drawing.Point(138, 80);
            this.txt_teacher_patronymic.Name = "txt_teacher_patronymic";
            this.txt_teacher_patronymic.Size = new System.Drawing.Size(100, 20);
            this.txt_teacher_patronymic.TabIndex = 4;
            // 
            // txt_teacher_name
            // 
            this.txt_teacher_name.Location = new System.Drawing.Point(138, 56);
            this.txt_teacher_name.Name = "txt_teacher_name";
            this.txt_teacher_name.Size = new System.Drawing.Size(100, 20);
            this.txt_teacher_name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Код преподователя";
            // 
            // txt_teacher_id
            // 
            this.txt_teacher_id.Location = new System.Drawing.Point(138, 6);
            this.txt_teacher_id.Name = "txt_teacher_id";
            this.txt_teacher_id.Size = new System.Drawing.Size(100, 20);
            this.txt_teacher_id.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Стаж";
            // 
            // txt_teacher_tel
            // 
            this.txt_teacher_tel.Location = new System.Drawing.Point(138, 105);
            this.txt_teacher_tel.Name = "txt_teacher_tel";
            this.txt_teacher_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_teacher_tel.TabIndex = 5;
            // 
            // txt_teacher_experience
            // 
            this.txt_teacher_experience.Location = new System.Drawing.Point(138, 130);
            this.txt_teacher_experience.Name = "txt_teacher_experience";
            this.txt_teacher_experience.Size = new System.Drawing.Size(100, 20);
            this.txt_teacher_experience.TabIndex = 6;
            // 
            // TeacherAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 202);
            this.Controls.Add(this.txt_teacher_experience);
            this.Controls.Add(this.txt_teacher_tel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txt_teacher_surname);
            this.Controls.Add(this.txt_teacher_patronymic);
            this.Controls.Add(this.txt_teacher_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_teacher_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherAddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить запись преподователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TextBox txt_teacher_surname;
        private System.Windows.Forms.TextBox txt_teacher_patronymic;
        private System.Windows.Forms.TextBox txt_teacher_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_teacher_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_teacher_tel;
        private System.Windows.Forms.TextBox txt_teacher_experience;
    }
}