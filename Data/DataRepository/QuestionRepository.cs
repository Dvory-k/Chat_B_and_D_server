using Core.Models;
using Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataRepository
{
    public class QuestionRepository: IQuestionRepository
    {
        private readonly BandDContext _dbContext;

        public QuestionRepository(BandDContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> AddQuestion(Question question)
        {
            _dbContext.Questions.Add(question);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
