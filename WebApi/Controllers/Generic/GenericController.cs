using System;
using System.Collections.Generic;
using Context.Repository;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Generic;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenericController<TEntity> : ControllerBase, IBaseController<TEntity> where TEntity : class
    {
        public readonly RepositoryBase<TEntity> _repo;

        public virtual List<TEntity> list { get; set; }

        public GenericController()
        {
            _repo = new RepositoryBase<TEntity>();
        }

        [HttpGet("{filter?}")]
        public virtual IEnumerable<Object> Get(Int64 filter)
        {
            return _repo.Get();
        }

        [HttpPost]
        public virtual IActionResult Post(TEntity entity)
        {
            _repo.Add(entity, list);

            return Ok();
        }

        [HttpPut]
        public virtual IActionResult Update(TEntity entity)
        {
            _repo.Update(entity);

            return Ok();
        }

        [HttpDelete]
        public virtual IActionResult Delete(Int64 id)
        {
            _repo.Delete(id);

            return Ok();
        }


    }
}
