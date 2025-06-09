using AutoMapper;
using Core.Models;
using Core.Resources;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {

        private readonly IAnswerService _answerService;
        private readonly IMapper _mapper;
    

        public AnswerController(IAnswerService answerService, IMapper mapper)
        {
            _mapper = mapper;
            _answerService = answerService;
        
        }

        //[HttpPost("chat")]
        //public async Task<string> chat(QuestionResources questionResources)
        //{

        //    return await _answerService.Chatdb(_mapper.Map<Question>(questionResources));
        //}

        [HttpPost("chat")]
        public async Task<string> chat(QuestionResources questionResources)
        {
            if (questionResources.UserId <= 0)
                return "Invalid UserId";

            var question = _mapper.Map<Question>(questionResources);
            return await _answerService.Chatdb(question);
        }

    }
}
