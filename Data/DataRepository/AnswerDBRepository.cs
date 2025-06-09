using Core.Models;
using Core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataRepository
{
    public class AnswerDBRepository: IAnswerDBRepository
    {
        private readonly BandDContext _dbContext;

        public AnswerDBRepository(BandDContext dbContext)
        {
            _dbContext = dbContext;
        }
        //מחיקת תשובה ממאגר התשובות
        public async Task<int> DeleteAnswerDB(int id)
        {
            var answerDB = await _dbContext.AnswersDB.FindAsync(id);
            if (answerDB == null)
                return 0; 

            _dbContext.AnswersDB.Remove(answerDB);
            return await _dbContext.SaveChangesAsync();
        }
        //שליפת כל התשובות שבמאגר
        public async Task<List<AnswerDB>> GetAllAnswersDB()
        {
            return await _dbContext.AnswersDB.ToListAsync();
        }
        //עדכון תשובה שבמאגר
        public async Task<int> UpdateAnswerDB(AnswerDB answerDB)
        {
            var existingAnswer = await _dbContext.AnswersDB.FindAsync(answerDB.Id);
            if (existingAnswer == null)
                return 0; 

            existingAnswer.AnswerText = answerDB.AnswerText;

            return await _dbContext.SaveChangesAsync();
        }

    }
}
