using DataAccess.Context;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASenkron.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetFirst()
    {
        AppDbContext context = new();

        Product product = await context.Products.FirstAsync();
        return Ok(product);
    }
}
