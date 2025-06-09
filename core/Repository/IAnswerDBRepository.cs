using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface IAnswerDBRepository
    {
        Task<List<AnswerDB>> GetAllAnswersDB();

        Task<int> DeleteAnswerDB(int id);
        Task<int> UpdateAnswerDB(AnswerDB answerDB);
    }
}
