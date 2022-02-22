using Microsoft.AspNetCore.Mvc;
using TaskManager.Data.Repositories;

namespace TaskManager.Controllers;

public class TarefasController : Controller
{
    private ITarefasRepository _tarefasRepository;
    
    // GET: api/<TarefasController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<TarefasController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<TarefasController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<TarefasController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<TarefasController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}