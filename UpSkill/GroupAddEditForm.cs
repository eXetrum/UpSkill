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
    public partial class GroupAddEditForm : Form
    {
        UpSkill.GroupForm gr_form;
        public GroupAddEditForm()
        {
            InitializeComponent();
        }
        public GroupAddEditForm(GroupForm gr_form)
        {
            InitializeComponent();
            this.gr_form = gr_form;
            // Если задано редактирование - заполняем поля данными
            if (this.gr_form.curr_index != -1)
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
            Group gr = GetGroupData();
            // Если данные не корректны или не полны
            if (gr == null)
            {
                MessageBox.Show("Ошибка. Проверьте введенные данные !");
                return;
            }
            // Если задано добавление
            if (gr_form.curr_index == -1)
            {
                // Проверим нет ли группы с таким названием уже в списке
                // Ищем группу с полученным названием
                Group gr_test = UpSkill.SkillUpForm.groups.Find(Group.SearchByID(gr.ID));
                if (gr_test != null)
                {
                    MessageBox.Show("Группа с указанным названием уже есть в списке.");
                    return;
                }
                // Иначе добавляем к списку групп
                UpSkill.SkillUpForm.groups.Add(gr);
            }
            else
            {
                int index = UpSkill.SkillUpForm.groups.FindIndex(Group.SearchByID(gr.ID));
                // Проверяем можно ли использовать новое имя для названия группы
                if (index != -1 && index != gr_form.curr_index)
                {
                    MessageBox.Show("Выбранное название группы уже занято.");
                    return;
                }
                SkillUpForm.groups[gr_form.curr_index] = gr;
            }
            // Принудительно вызываем обновление списка групп
            gr_form.ReFill();
            // Закрываем текущую форму
            this.Close();
        }
        // Обработчик нажатия на кнопку "выход"
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Метод проверки данных в полях
        Group GetGroupData()
        {
            try
            {
                // Проверяем длинну текстовых полей
                if (txt_group_num.Text.Length == 0 || txt_stud_count.Text.Length == 0
                    || txt_profession.Text.Length == 0 || txt_department.Text.Length == 0)
                    return null;
                // Пытаемся построить объект типа Group. 
                return new Group(txt_group_num.Text,
                                Convert.ToInt16(txt_stud_count.Text),
                                txt_profession.Text,
                                txt_department.Text);
            }
            catch
            {
                return null;
            }
        }
        // Метод заполнения полей для редактирования
        void FillData()
        {
            txt_group_num.Text = UpSkill.SkillUpForm.groups[gr_form.curr_index].ID;
            txt_stud_count.Text = UpSkill.SkillUpForm.groups[gr_form.curr_index].Count.ToString();
            txt_profession.Text = UpSkill.SkillUpForm.groups[gr_form.curr_index].Profession;
            txt_department.Text = UpSkill.SkillUpForm.groups[gr_form.curr_index].Department;
        }
    }
}
