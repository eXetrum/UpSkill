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
    public partial class AllocateLoading : Form
    {
        public int curr_index = -1;

        public AllocateLoading()
        {
            InitializeComponent();
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;

        }

        private void AllocateLoading_Load(object sender, EventArgs e)
        {
            ReFill();
            listView1.FullRowSelect = true;
        }
        public void ReFill()
        {
            // Очищаем список
            listView1.Items.Clear();
            // Добавляем все из списка
            foreach (var ld in UpSkill.SkillUpForm.loadings)
            {
                ListViewItem lvi = new ListViewItem(ld.TeacherID);
                lvi.SubItems.Add(ld.GroupID);
                lvi.SubItems.Add(ld.HourCount.ToString());
                lvi.SubItems.Add(ld.Subject);
                lvi.SubItems.Add(ld.Lesson == Loading.lesson_type.lection ? "Лекция" : "Практика");
                lvi.SubItems.Add(ld.Payment.ToString());
                listView1.Items.Add(lvi);
            }
            // Выключаем кнопки
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            curr_index = -1;
            LoadAddEditForm ld_add = new LoadAddEditForm(this);
            ld_add.Owner = this;
            ld_add.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            curr_index = listView1.SelectedIndices[0];
            LoadAddEditForm gr_add = new LoadAddEditForm(this);
            gr_add.Owner = this;
            gr_add.ShowDialog();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            ListViewItem selected = listView1.SelectedItems[0];
            // Проверка корректного выделения
            if (selected == null) return;
            int index = -1;
            for (int i = 0; i < UpSkill.SkillUpForm.loadings.Count; i++)
            {
                if (UpSkill.SkillUpForm.loadings[i].TeacherID == selected.SubItems[0].Text
                    && UpSkill.SkillUpForm.loadings[i].GroupID == selected.SubItems[1].Text
                    && UpSkill.SkillUpForm.loadings[i].HourCount.ToString() == selected.SubItems[2].Text
                    && UpSkill.SkillUpForm.loadings[i].Subject == selected.SubItems[3].Text
                    && (UpSkill.SkillUpForm.loadings[i].Lesson == Loading.lesson_type.lection ? "Лекция" : "Практика") == selected.SubItems[4].Text
                    && UpSkill.SkillUpForm.loadings[i].Payment.ToString() == selected.SubItems[5].Text)
                {
                    UpSkill.SkillUpForm.loadings.RemoveAt(i);
                    index = i;
                    ReFill();
                    break;
                }
            }
            // Найден ли индекс
            if (index == -1) return;
            // Перезагружаем видимость списка
            ReFill();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем идентификатор списка
            ListView listView = (ListView)sender;
            if (listView == null)
            {
                // Выключаем возможность редактирования
                btn_edit.Enabled = false;
                // Выключаем возможность удаления
                btn_del.Enabled = false;
                return;
            }
            if (listView.SelectedItems.Count == 0)
            {
                // Выключаем возможность редактирования
                btn_edit.Enabled = false;
                // Выключаем возможность удаления
                btn_del.Enabled = false;
                return;
            }
            // Получаем выделенный элемент
            ListViewItem selected = listView.SelectedItems[0];
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
            for (int i = 0; i < UpSkill.SkillUpForm.loadings.Count; i++)
            {
                if (UpSkill.SkillUpForm.loadings[i].TeacherID == selected.SubItems[0].Text
                    && UpSkill.SkillUpForm.loadings[i].GroupID == selected.SubItems[1].Text
                    && UpSkill.SkillUpForm.loadings[i].HourCount.ToString() == selected.SubItems[2].Text
                    && UpSkill.SkillUpForm.loadings[i].Subject == selected.SubItems[3].Text
                    && (UpSkill.SkillUpForm.loadings[i].Lesson == Loading.lesson_type.lection ? "Лекция" : "Практика") == selected.SubItems[4].Text
                    && UpSkill.SkillUpForm.loadings[i].Payment.ToString() == selected.SubItems[5].Text)
                {
                    curr_index = i;
                    break;
                }
            }
        }        
    }
}
