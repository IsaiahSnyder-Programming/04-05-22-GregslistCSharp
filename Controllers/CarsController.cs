using Microsoft.AspNetCore.Mvc;
using GregsListCSharp.Models;
using GregsListCSharp.Services;

namespace GregsListCSharp.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CarsController : ControllerBase
{
    private readonly CarsService _cs;

    public CarsController(CarsService cs)
    {
        _cs = cs;
    }

    [HttpGet]
    public ActionResult<List<Car>> Get()
    {
        try
        {
            List<Car> cars = _cs.GetAll();
            return Ok(cars);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("{id}")]
    public ActionResult<Car> GetById(string id)
    {
        try
        {
            Car car = _cs.GetById(id);
            return Ok(car);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car newCar) // req.body is now [FromBody]
    {
        try
        {
            Car car = _cs.Create(newCar);
            return Ok(car);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPut("{id}")]
    public ActionResult<Car> Update(string id, [FromBody] Car updates)
    {
        try
        {
            updates.Id = id;
            Car updated = _cs.Update(updates);
            return Ok(updated);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("{id}")]
    public ActionResult<String> Delete(string id)
    {
        try
        {
            _cs.Delete(id);
            return Ok("Delorted");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

}