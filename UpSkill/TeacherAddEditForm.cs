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
    public partial class TeacherAddEditForm : Form
    {
        UpSkill.TeacherForm teacherForm;
        public TeacherAddEditForm()
        {
            InitializeComponent();
        }
        public TeacherAddEditForm(TeacherForm tc_form)
        {
            InitializeComponent();
            this.teacherForm = tc_form;
            // Если задано редактирование - заполняем поля данными
            if (this.teacherForm.curr_index != -1)
            {
                btn_confirm.Text = "Сохранить";
                this.Text = "Редактировать запись";
                FillData();
            }
        }

        // Обработчик нажатия на кнопку "Добавить"
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            // Получаем и проверяем данные с заполненных полей
            Teacher tc = GetTeacherData();
            // Если данные не корректны или не полны
            if (tc == null)
            {
                MessageBox.Show("Ошибка. Проверьте введенные данные !");
                return;
            }
            // Если задано добавление
            if (teacherForm.curr_index == -1)
            {
                // Проверим нет ли преподователя с таким же идентификатором уже в списке
                Teacher tc_test = UpSkill.SkillUpForm.teachers.Find(Teacher.SearchByID(tc.ID));
                if (tc_test != null)
                {
                    MessageBox.Show("Преподователь с кодом уже есть в списке.");
                    return;
                }
                // Иначе добавляем к списку
                UpSkill.SkillUpForm.teachers.Add(tc);
            }
            else
            {
                int index = UpSkill.SkillUpForm.teachers.FindIndex(Teacher.SearchByID(tc.ID));
                // Проверяем можно ли использовать новый идентификатор преподавателя
                if (index != -1 && index != teacherForm.curr_index)
                {
                    MessageBox.Show("Выбранный код преподавателя уже занят.");
                    return;
                }
                SkillUpForm.teachers[teacherForm.curr_index] = tc;
            }
            // Принудительно вызываем обновление списка преподавателей
            teacherForm.ReFill();
            // Закрываем текущую форму
            this.Close();
        }
        // Обработчик нажатия на кнопку "выход"
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Метод проверки данных в полях
        Teacher GetTeacherData()
        {
            try
            {
                // Проверяем длинну текстовых полей
                if (txt_teacher_id.Text.Length == 0 
                    || txt_teacher_surname.Text.Length == 0 || txt_teacher_name.Text.Length == 0 || txt_teacher_patronymic.Text.Length == 0
                    || txt_teacher_tel.Text.Length == 0
                    || txt_teacher_experience.Text.Length == 0)
                    return null;
                // Пытаемся построить объект типа Teacher. 
                return new Teacher(txt_teacher_id.Text,
                                Convert.ToInt16(txt_teacher_experience.Text),
                                txt_teacher_surname.Text,
                                txt_teacher_name.Text,
                                txt_teacher_patronymic.Text,
                                txt_teacher_tel.Text);
            }
            catch
            {
                return null;
            }
        }
        // Метод заполнения полей для редактирования
        void FillData()
        {
            txt_teacher_id.Text = UpSkill.SkillUpForm.teachers[teacherForm.curr_index].ID;
            txt_teacher_experience.Text = UpSkill.SkillUpForm.teachers[teacherForm.curr_index].Experience.ToString();
            txt_teacher_surname.Text = UpSkill.SkillUpForm.teachers[teacherForm.curr_index].Surname;
            txt_teacher_name.Text = UpSkill.SkillUpForm.teachers[teacherForm.curr_index].Name;
            txt_teacher_patronymic.Text = UpSkill.SkillUpForm.teachers[teacherForm.curr_index].Patronymic;
            txt_teacher_tel.Text = UpSkill.SkillUpForm.teachers[teacherForm.curr_index].Telephone;
        }
    }
}
