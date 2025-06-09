using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Resources
{
    public class QuestionResources
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }

        public int UserId { get; set; }

    }
}
