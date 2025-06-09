using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface IAnswerRepository
    {
        

        Task<int> AddAnswer(Answer answer);

        //Task<int> UpdateAnswer(Answer answer);

        //Task<int> DeleteEmployee(int employeeId);
    }
}
