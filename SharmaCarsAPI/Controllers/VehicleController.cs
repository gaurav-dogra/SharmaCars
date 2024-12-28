using DataLayer.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace SharmaCarsAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VehicleController(IUnitOfWork unitOfWork) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var data = await unitOfWork.Vehicles.GetAllAsync();
        return Ok(data);
    }
}
