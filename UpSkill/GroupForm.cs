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
    public partial class GroupForm : Form
    {
        // Индекс текущего выделения в списке групп
        public int curr_index = -1;

        public GroupForm()
        {
            InitializeComponent();
        }

        public void ReFill()
        {
            // Очищаем поле информации
            txt_group_info.Clear();
            // Очищаем список
            listBox1.Items.Clear();
            // Добавляем все группы из списка
            foreach (var gr in UpSkill.SkillUpForm.groups)
                listBox1.Items.Add(gr.ID);
            // Выводим данные о количестве групп
            lbl_gr_count.Text = UpSkill.SkillUpForm.groups.Count.ToString();
            // Выключаем кнопки
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            curr_index = -1;
            GroupAddEditForm gr_add = new GroupAddEditForm(this);
            gr_add.Owner = this;
            gr_add.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            curr_index = listBox1.SelectedIndex;
            GroupAddEditForm gr_add = new GroupAddEditForm(this);
            gr_add.Owner = this;            
            gr_add.ShowDialog();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            object selected = listBox1.SelectedItem;
            // Проверка корректного выделения
            if (selected == null) return;
            int index = UpSkill.SkillUpForm.groups.FindIndex(Group.SearchByID(selected.ToString()));
            // Найден ли индекс
            if (index == -1) return;
            // Удаляем из списка
            UpSkill.SkillUpForm.groups.RemoveAt(index);
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
            Group gr = UpSkill.SkillUpForm.groups.Find(Group.SearchByID(selected.ToString()));
            // Если нашли
            if(gr != null)
            {               
                // Очищаем информационное поле
                txt_group_info.Clear();
                // Заполняем инфо поле новыми данными
                txt_group_info.AppendText("Номер группы: " + gr.ID + Environment.NewLine);
                txt_group_info.AppendText("Количество студентов: " + gr.Count + Environment.NewLine);
                txt_group_info.AppendText("Специальность: " + gr.Profession + Environment.NewLine);
                txt_group_info.AppendText("Отделение: " + gr.Department + Environment.NewLine);
            }
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            ReFill();
        }
    }
}
