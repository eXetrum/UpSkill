using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSkill
{
    // Описание "группы"
    public class Group
    {
        // Параметрический конструктор
        public Group(string id, int count, string profession, string department)
        {
            this.id = id;
            this.count = count;
            this.profession = profession;
            this.department = department;
        }
        // Доступ к номеру группы
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        // Доступ к количеству студентов
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        // Доступ к полю "спецаильность"
        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }
        // Доступ к полю "отделение"
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public static Predicate<Group> SearchByID(string id)
        {
            return delegate(Group gr)
            {
                return gr.ID == id;
            };
        }
        // Номер группы
        string id;
        // Количество студентов
        int count;
        // Специальность
        string profession;
        // Отделение
        string department;        
    }
}
