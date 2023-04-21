using DataAccess.Context;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CancellationTokenWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
    {
        //İşlemler



        AppDbContext context = new();

        IList<Product> products = await context.Products.ToListAsync(cancellationToken);
        return Ok(products); 
    }
}
