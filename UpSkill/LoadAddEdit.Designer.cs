namespace UpSkill
{
    partial class LoadAddEditForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_teacher_id = new System.Windows.Forms.ComboBox();
            this.cb_group_id = new System.Windows.Forms.ComboBox();
            this.txt_hours = new System.Windows.Forms.TextBox();
            this.rb_lection = new System.Windows.Forms.RadioButton();
            this.rb_pract = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_subj = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код преподавателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер группы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество часов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Предмет";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Оплата";
            // 
            // cb_teacher_id
            // 
            this.cb_teacher_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_teacher_id.FormattingEnabled = true;
            this.cb_teacher_id.Location = new System.Drawing.Point(173, 6);
            this.cb_teacher_id.Name = "cb_teacher_id";
            this.cb_teacher_id.Size = new System.Drawing.Size(121, 21);
            this.cb_teacher_id.TabIndex = 0;
            // 
            // cb_group_id
            // 
            this.cb_group_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_group_id.FormattingEnabled = true;
            this.cb_group_id.Location = new System.Drawing.Point(173, 34);
            this.cb_group_id.Name = "cb_group_id";
            this.cb_group_id.Size = new System.Drawing.Size(121, 21);
            this.cb_group_id.TabIndex = 1;
            // 
            // txt_hours
            // 
            this.txt_hours.Location = new System.Drawing.Point(173, 62);
            this.txt_hours.Name = "txt_hours";
            this.txt_hours.Size = new System.Drawing.Size(121, 20);
            this.txt_hours.TabIndex = 2;
            // 
            // rb_lection
            // 
            this.rb_lection.AutoSize = true;
            this.rb_lection.Location = new System.Drawing.Point(6, 19);
            this.rb_lection.Name = "rb_lection";
            this.rb_lection.Size = new System.Drawing.Size(63, 17);
            this.rb_lection.TabIndex = 6;
            this.rb_lection.TabStop = true;
            this.rb_lection.Text = "Лекция";
            this.rb_lection.UseVisualStyleBackColor = true;
            // 
            // rb_pract
            // 
            this.rb_pract.AutoSize = true;
            this.rb_pract.Location = new System.Drawing.Point(97, 19);
            this.rb_pract.Name = "rb_pract";
            this.rb_pract.Size = new System.Drawing.Size(74, 17);
            this.rb_pract.TabIndex = 7;
            this.rb_pract.TabStop = true;
            this.rb_pract.Text = "Практика";
            this.rb_pract.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_lection);
            this.groupBox1.Controls.Add(this.rb_pract);
            this.groupBox1.Location = new System.Drawing.Point(14, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 48);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип занятия";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(173, 117);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(121, 20);
            this.txt_price.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(197, 143);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(97, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(197, 167);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(97, 23);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Закрыть";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_subj
            // 
            this.txt_subj.Location = new System.Drawing.Point(173, 89);
            this.txt_subj.Name = "txt_subj";
            this.txt_subj.Size = new System.Drawing.Size(121, 20);
            this.txt_subj.TabIndex = 3;
            // 
            // LoadAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 203);
            this.Controls.Add(this.txt_subj);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_hours);
            this.Controls.Add(this.cb_group_id);
            this.Controls.Add(this.cb_teacher_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadAddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добваить нагрузку";
            this.Load += new System.EventHandler(this.LoadAddEditForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_teacher_id;
        private System.Windows.Forms.ComboBox cb_group_id;
        private System.Windows.Forms.TextBox txt_hours;
        private System.Windows.Forms.RadioButton rb_lection;
        private System.Windows.Forms.RadioButton rb_pract;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_subj;
    }
}