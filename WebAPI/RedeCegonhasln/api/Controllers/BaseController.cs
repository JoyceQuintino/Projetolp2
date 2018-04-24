using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using laiscegonha.Context;
using laiscegonha.Repositories;
using laiscegonha.Models;

namespace api.Controllers
{
    [Route("lais/[controller]/")]
    public abstract class BaseController<T> : Controller where T : class, IEntidade
    {
        public RepositoryBase<T> _repository;

        public BaseController(LaisContext context)
        {
            _repository = new RepositoryBase<T>(context);
        }
        [HttpGet]
        public virtual IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var entity = _repository.Find(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }
        [HttpPost]
        public IActionResult Create([FromBody]T entity)
        {
            if (entity == null)
            {
                return BadRequest("Esse objeto não pode ser nulo");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_repository.CreateT(entity));

        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] T entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }
            _repository.Update(entity);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var entity = _repository.Find(id);
            if (entity == null)
            {
                return NotFound();
            }
            _repository.Remove(id);
            return Ok();
        }

    }
}