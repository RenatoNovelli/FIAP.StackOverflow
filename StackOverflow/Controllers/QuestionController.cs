using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StackOverflow.API.Models;
using StackOverflow.API.Services;

namespace StackOverflow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var response = _questionService.GetAll();
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var response = _questionService.GetById(id);
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] Question question)
        {
            _questionService.Insert(question);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Question question)
        {
            _questionService.Update(id, question);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _questionService.Delete(id);
        }
    }
}
