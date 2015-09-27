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
    public partial class SkillUpForm : Form
    {
        public enum Subjects { a, b };
        // Список групп
        public static List<Group> groups = new List<Group>();
        // Список преподователей
        public static List<Teacher> teachers = new List<Teacher>();
        // Список информации и нагрузке
        public static List<Loading> loadings = new List<Loading>();

        public SkillUpForm()
        {
            InitializeComponent();
        }

        private void btn_groups_Click(object sender, EventArgs e)
        {
            GroupForm groupForm = new GroupForm();
            groupForm.ShowDialog();
        }

        private void btn_teachers_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm();
            teacherForm.ShowDialog();
        }

        private void btn_loading_Click(object sender, EventArgs e)
        {
            AllocateLoading allocLoading = new AllocateLoading();
            allocLoading.ShowDialog();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
