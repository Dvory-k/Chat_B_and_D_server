using Core.Models;
using Core.Repository;
using Core.Resources;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class AnswerService : IAnswerService
    {
        private readonly IAnswerRepository _answerRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly IAnswerDBRepository _answerDBRepository;


        public AnswerService(IAnswerRepository answerRepository, IQuestionRepository questionRepository, IAnswerDBRepository answerDBRepository)
        {
            _answerRepository = answerRepository;
            _questionRepository = questionRepository;
            _answerDBRepository = answerDBRepository;
        }

        public async Task<string> Chatdb(Question question)
        {
            int q = await _questionRepository.AddQuestion(question);
            List<AnswerDB> answerDBs = await _answerDBRepository.GetAllAnswersDB();
            Random random = new Random();
            int number = random.Next(1, answerDBs.Count());
            string ans = answerDBs[number].AnswerText;
            Answer newAnswer = new Answer();
            newAnswer.UserId = question.UserId;
            newAnswer.Question = question;
            newAnswer.AnswerTextId= answerDBs[number].Id;

            await _answerRepository.AddAnswer(newAnswer);

            return ans;


        }

      
    }
}
