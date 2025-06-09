using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // שאלות שנשלחו ע"י המשתמש
        public List<Question> Questions { get; set; }

        // תשובות שנשלחו למשתמש (על השאלות שלו)
        public List<Answer> Answers { get; set; }

    }
}
