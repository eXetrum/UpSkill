namespace UpSkill
{
    partial class TeacherForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_tc_count = new System.Windows.Forms.Label();
            this.lbl_gr_text = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_teacher_info = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 212);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // lbl_tc_count
            // 
            this.lbl_tc_count.AutoSize = true;
            this.lbl_tc_count.Location = new System.Drawing.Point(174, 237);
            this.lbl_tc_count.Name = "lbl_tc_count";
            this.lbl_tc_count.Size = new System.Drawing.Size(13, 13);
            this.lbl_tc_count.TabIndex = 15;
            this.lbl_tc_count.Text = "0";
            // 
            // lbl_gr_text
            // 
            this.lbl_gr_text.AutoSize = true;
            this.lbl_gr_text.Location = new System.Drawing.Point(16, 237);
            this.lbl_gr_text.Name = "lbl_gr_text";
            this.lbl_gr_text.Size = new System.Drawing.Size(152, 13);
            this.lbl_gr_text.TabIndex = 14;
            this.lbl_gr_text.Text = "Количество преподавателей";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(106, 48);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(94, 23);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Закрыть";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Enabled = false;
            this.btn_del.Location = new System.Drawing.Point(6, 48);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(94, 23);
            this.btn_del.TabIndex = 12;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.Location = new System.Drawing.Point(106, 19);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(94, 23);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "Редактировать";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_teacher_info
            // 
            this.txt_teacher_info.Enabled = false;
            this.txt_teacher_info.Location = new System.Drawing.Point(206, 12);
            this.txt_teacher_info.Multiline = true;
            this.txt_teacher_info.Name = "txt_teacher_info";
            this.txt_teacher_info.Size = new System.Drawing.Size(249, 154);
            this.txt_teacher_info.TabIndex = 9;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(6, 19);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(95, 23);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_del);
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Location = new System.Drawing.Point(223, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 81);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_tc_count);
            this.Controls.Add(this.lbl_gr_text);
            this.Controls.Add(this.txt_teacher_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о преподавателях";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_tc_count;
        private System.Windows.Forms.Label lbl_gr_text;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_teacher_info;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}