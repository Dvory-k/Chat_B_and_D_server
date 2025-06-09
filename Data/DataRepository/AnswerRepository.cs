using Core.Models;
using Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataRepository
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly BandDContext _dbContext;

        public AnswerRepository(BandDContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<int> AddAnswer(Answer answer)
        {
            _dbContext.Answers.Add(answer);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
