using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Resources
{
    public class AnswerResources
    {
        public int Id { get; set; }
        public int AnswerTextId { get; set; }
        public AnswerDBResources AnswerDB { get; set; }
        // למי נשלחה התשובה
        public int UserId { get; set; }
        public UserResources User { get; set; }
        // על איזו שאלה נשלחה התשובה
        //public int QuestionId { get; set; }
    }
}
