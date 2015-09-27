using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpSkill
{
    public partial class TeacherForm : Form
    {
        // Индекс текущего выделения в списке преподавателей
        public int curr_index = -1;

        public TeacherForm()
        {
            InitializeComponent();
        }

        public void ReFill()
        {
            // Очищаем поле информации
            txt_teacher_info.Clear();
            // Очищаем список
            listBox1.Items.Clear();
            // Добавляем все группы из списка
            foreach (var gr in UpSkill.SkillUpForm.teachers)
                listBox1.Items.Add(gr.ID);
            // Выводим данные о количестве групп
            lbl_tc_count.Text = UpSkill.SkillUpForm.teachers.Count.ToString();
            // Выключаем кнопки
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            curr_index = -1;
            TeacherAddEditForm tc_add = new TeacherAddEditForm(this);
            tc_add.Owner = this;
            tc_add.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            curr_index = listBox1.SelectedIndex;
            TeacherAddEditForm tc_add = new TeacherAddEditForm(this);
            tc_add.Owner = this;
            tc_add.ShowDialog();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            object selected = listBox1.SelectedItem;
            // Проверка корректного выделения
            if (selected == null) return;
            int index = UpSkill.SkillUpForm.teachers.FindIndex(Teacher.SearchByID(selected.ToString()));
            // Найден ли индекс
            if (index == -1) return;
            // Удаляем из списка
            UpSkill.SkillUpForm.teachers.RemoveAt(index);
            // Перезагружаем видимость списка
            ReFill();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // Получаем идентификатор листбокса
            ListBox listbox = (ListBox)sender;
            // Получаем выделенный элемент
            object selected = listbox.SelectedItem;
            if (selected == null)
            {
                // Выключаем возможность редактирования
                btn_edit.Enabled = false;
                // Выключаем возможность удаления
                btn_del.Enabled = false;

                return;
            }
            // Включаем возможность редактирования
            btn_edit.Enabled = true;
            // Включаем возможность удаления
            btn_del.Enabled = true;
            // Ищем группу с полученным названием
            Teacher tc = UpSkill.SkillUpForm.teachers.Find(Teacher.SearchByID(selected.ToString()));
            // Если нашли
            if (tc != null)
            {
                // Очищаем информационное поле
                txt_teacher_info.Clear();
                // Заполняем инфо поле новыми данными
                txt_teacher_info.AppendText("Код преподавателя: " + tc.ID + Environment.NewLine);
                txt_teacher_info.AppendText("Ф.И.О.: " + tc.Surname + " " + tc.Name + " " + tc.Patronymic + Environment.NewLine);
                txt_teacher_info.AppendText("Телефон: " + tc.Telephone + Environment.NewLine);
                txt_teacher_info.AppendText("Стаж: " + tc.Experience + Environment.NewLine);
            }
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            ReFill();
        }
    }
}
