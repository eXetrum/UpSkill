using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSkill
{
    // Описание "учителя"
    public class Teacher
    {
        // Параметрический конструктор
        public Teacher(string id, int experience, string surname, string name, string patronymic, string telephone)
        {
            this.id = id;
            this.experience = experience;
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.telephone = telephone;
        }
        // Доступ к полю "код преподователя"
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        // Доступ к полю "Стаж работы"
        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }
        // Доступ к полю "Фамилия"
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        // Доступ к полю "Имя"
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // Доступ к полю "Отчество"
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }
        // Доступ к полю "телефон"
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        public static Predicate<Teacher> SearchByID(string id)
        {
            return delegate(Teacher tc)
            {
                return tc.ID == id;
            };
        }
        // Код преподователя
        string id;
        // Стаж
        int experience;
        // Фамилия
        string surname;
        // Имя
        string name;
        // Отчество
        string patronymic;
        // Номер телефона
        string telephone;
    }
}
