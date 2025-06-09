using AutoMapper;
using Core.Models;
using Core.Repository;
using Core.Resources;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerDBController : ControllerBase
    {

        private readonly IAnswerDBRepository _answerDBRepository;
        private readonly IMapper _mapper;


        public AnswerDBController(IAnswerDBRepository answerDBRepository, IMapper mapper)
        {
            _mapper = mapper;
            _answerDBRepository = answerDBRepository;

        }
        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] AnswerDBResources answerDBResources)
        {
         

            var answerDB = _mapper.Map<AnswerDB>(answerDBResources);
            var result = await _answerDBRepository.UpdateAnswerDB(answerDB);

            if (result == 0)
                return NotFound("תשובה לא נמצאה");

            return Ok("התשובה עודכנה בהצלחה");
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _answerDBRepository.DeleteAnswerDB(id);

            if (result == 0)
                return NotFound("תשובה לא נמצאה למחיקה");

            return Ok("נמחק בהצלחה");
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<AnswerDBResources>>> GetAll()
        {
            var answers = await _answerDBRepository.GetAllAnswersDB();
            var resources = _mapper.Map<List<AnswerDBResources>>(answers);
            return Ok(resources);
        }



    }
}
