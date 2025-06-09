using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int AnswerTextId { get; set; }

        // למי נשלחה התשובה
        public int UserId { get; set; }
        public User User { get; set; }

        // על איזו שאלה נשלחה התשובה
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
