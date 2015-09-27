using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSkill
{
    // Описание сущности "нагрузка"
    public class Loading
    {
        public enum lesson_type { lection, practice };
        // Параметрический конструктор
        public Loading(string teacher_id, string group_id, int hour_count, string subject, lesson_type lesson, int payment)
        {
            this.teacher_id = teacher_id;
            this.group_id = group_id;
            this.hour_count = hour_count;
            this.subject = subject;
            this.lesson = lesson;
            this.payment = payment;
        }
        // Доступ к полю "Код преподователя"
        public string TeacherID
        {
            get { return teacher_id; }
            set { teacher_id = value; }
        }
        // Доступ к полю "Номер группы"
        public string GroupID
        {
            get { return group_id; }
            set { group_id = value; }
        }
        // Доступ к полю "Количество часов"
        public int HourCount
        {
            get { return hour_count; }
            set { hour_count = value; }
        }
        // Доступ к полю "Предмет"
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        // Доступ к полю "Тип занятия"
        public lesson_type Lesson
        {
            get { return lesson; }
            set { lesson = value; }
        }
        // Доступ к полю "Оплата"
        public int Payment
        {
            get { return payment; }
            set { payment = value; }
        }
        // Код преподователя
        string teacher_id;
        // Номер группы
        string group_id;
        // Количество часов
        int hour_count;
        // Предмет
        string subject;
        // Тип занятия
        lesson_type lesson;
        // Оплата
        int payment;
    }
}
