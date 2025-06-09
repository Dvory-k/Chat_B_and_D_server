using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class AnswerDB
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }

        // שאלות שקיבלו תשובה זו מתוך המאגר
        public List<Question> Questions { get; set; }

    }
}
