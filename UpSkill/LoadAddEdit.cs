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
    public partial class LoadAddEditForm : Form
    {
        UpSkill.AllocateLoading ld_form;
        public LoadAddEditForm()
        {
            InitializeComponent();
        }
        public LoadAddEditForm(AllocateLoading ld_form)
        {
            InitializeComponent();
            this.ld_form = ld_form;
            // Если задано редактирование - заполняем поля данными
            if (this.ld_form.curr_index != -1)
            {
                btn_add.Text = "Сохранить";
                this.Text = "Редактировать запись";
                FillData();
            }
        }
        // Обработчик нажатия на кнопку "Добавить"
        private void btn_add_Click(object sender, EventArgs e)
        {
            // Получаем и проверяем данные с заполненных полей
            Loading ld = GetLoadingData();
            // Если данные не корректны или не полны
            if (ld == null)
            {
                MessageBox.Show("Ошибка. Проверьте введенные данные !");
                return;
            }
            // Если задано добавление
            if (ld_form.curr_index == -1)
            {
                UpSkill.SkillUpForm.loadings.Add(ld);
            }
            else
            {
                SkillUpForm.loadings[ld_form.curr_index] = ld;
            }
            // Принудительно вызываем обновление списка групп
            ld_form.ReFill();
            // Закрываем текущую форму
            this.Close();
        }
        // Обработчик нажатия на кнопку "выход"
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Метод проверки данных в полях
        Loading GetLoadingData()
        {
            try
            {
                // Проверяем длинну текстовых полей
                if (cb_teacher_id.SelectedItem.ToString().Length == 0 
                    || cb_group_id.SelectedItem.ToString().Length == 0
                    || txt_hours.Text.Length == 0
                    || txt_subj.Text.Length == 0
                    || !rb_lection.Checked && !rb_pract.Checked
                    || txt_price.Text.Length == 0)
                    return null;
                // Пытаемся построить объект типа Loading. 
                return new Loading(cb_teacher_id.SelectedItem.ToString(),
                                    cb_group_id.SelectedItem.ToString(),
                                    Convert.ToInt16(txt_hours.Text),
                                    txt_subj.Text,
                                    rb_lection.Checked ? Loading.lesson_type.lection : Loading.lesson_type.practice,
                                    Convert.ToInt16(txt_price.Text));
            }
            catch
            {
                return null;
            }
        }
        // Метод заполнения полей для редактирования
        void FillData()
        {
            cb_teacher_id.SelectedIndex = cb_teacher_id.Items.IndexOf(UpSkill.SkillUpForm.loadings[ld_form.curr_index].TeacherID);
            cb_group_id.SelectedIndex = cb_group_id.Items.IndexOf(UpSkill.SkillUpForm.loadings[ld_form.curr_index].GroupID);
            
            txt_hours.Text = UpSkill.SkillUpForm.loadings[ld_form.curr_index].HourCount.ToString();
            txt_subj.Text = UpSkill.SkillUpForm.loadings[ld_form.curr_index].Subject;
            txt_price.Text = UpSkill.SkillUpForm.loadings[ld_form.curr_index].Payment.ToString();
            if (UpSkill.SkillUpForm.loadings[ld_form.curr_index].Lesson == Loading.lesson_type.lection)
                rb_lection.Select();
            else
                rb_pract.Select();
        }

        void Prepare()
        {
            // Добавляем пункты в список идентификаторов преподавателей
            foreach (var tc in UpSkill.SkillUpForm.teachers)
                cb_teacher_id.Items.Add(tc.ID);
            // Добавляем группы
            foreach (var gr in UpSkill.SkillUpForm.groups)
                cb_group_id.Items.Add(gr.ID);
        }

        private void LoadAddEditForm_Load(object sender, EventArgs e)
        {
            Prepare();
        }
    }
}
