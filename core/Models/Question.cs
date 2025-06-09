using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        // הקשר למשתמש ששאל
        public int UserId { get; set; }
        public User User { get; set; }

        // תשובה שנשלחה בעקבות שאלה זו
        public Answer Answer { get; set; }

        // תשובה שנבחרה מתוך מאגר (לשימוש פנימי)
        public int? AnswerDBId { get; set; }
        public AnswerDB AnswerDB { get; set; }
    }
}
