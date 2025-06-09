using Core.Models;
using Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IAnswerService
    {
        Task<string> Chatdb(Question question);

    }
}
