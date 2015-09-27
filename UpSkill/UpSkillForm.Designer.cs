namespace UpSkill
{
    partial class SkillUpForm
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
            this.btn_groups = new System.Windows.Forms.Button();
            this.btn_teachers = new System.Windows.Forms.Button();
            this.btn_loading = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_groups
            // 
            this.btn_groups.Location = new System.Drawing.Point(6, 19);
            this.btn_groups.Name = "btn_groups";
            this.btn_groups.Size = new System.Drawing.Size(104, 23);
            this.btn_groups.TabIndex = 0;
            this.btn_groups.Text = "Группы";
            this.btn_groups.UseVisualStyleBackColor = true;
            this.btn_groups.Click += new System.EventHandler(this.btn_groups_Click);
            // 
            // btn_teachers
            // 
            this.btn_teachers.Location = new System.Drawing.Point(6, 48);
            this.btn_teachers.Name = "btn_teachers";
            this.btn_teachers.Size = new System.Drawing.Size(105, 23);
            this.btn_teachers.TabIndex = 1;
            this.btn_teachers.Text = "Преподователи";
            this.btn_teachers.UseVisualStyleBackColor = true;
            this.btn_teachers.Click += new System.EventHandler(this.btn_teachers_Click);
            // 
            // btn_loading
            // 
            this.btn_loading.Location = new System.Drawing.Point(7, 77);
            this.btn_loading.Name = "btn_loading";
            this.btn_loading.Size = new System.Drawing.Size(104, 23);
            this.btn_loading.TabIndex = 2;
            this.btn_loading.Text = "Нагрузка";
            this.btn_loading.UseVisualStyleBackColor = true;
            this.btn_loading.Click += new System.EventHandler(this.btn_loading_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(14, 127);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(104, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_groups);
            this.groupBox2.Controls.Add(this.btn_teachers);
            this.groupBox2.Controls.Add(this.btn_loading);
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 109);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // SkillUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(133, 169);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SkillUpForm";
            this.Text = "SkillUp";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_groups;
        private System.Windows.Forms.Button btn_teachers;
        private System.Windows.Forms.Button btn_loading;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

