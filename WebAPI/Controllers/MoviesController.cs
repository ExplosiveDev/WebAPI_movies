using DataAccess.Entities;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IRepository<Movie> _repository;

        public MoviesController(IRepository<Movie> repository)
        {
            _repository = repository;
        }
        //[HttpGet("Collections
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.Get());
        }
        [HttpGet("Id")]
        public IActionResult GetById([FromRoute]int id)
        {
            return Ok(_repository.GetByID(id).Result);
        }
        [HttpPost("Create")]
        public IActionResult Create(Movie movie)
        {
            _repository.Insert(movie);
            _repository.Save();
            return Ok();
        }
        [HttpPut("Edit")]
        public IActionResult Edit(Movie movie)
        {
            _repository.Update(movie);
            _repository.Save();
            return Ok();
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Movie movie)
        {
            _repository.Delete(movie);
            _repository.Save();
            return Ok();
        }
    }
}
