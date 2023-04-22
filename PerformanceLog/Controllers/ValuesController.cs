using DataAccess.Context;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PerformanceLogWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet("[action]")]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
    {
        AppDbContext context = new();
        IList<PerformanceLog> performanceLogs =
            await context.PerformanceLogs
            .OrderByDescending(p => p.Id)
            .ToListAsync(cancellationToken);

        return Ok(performanceLogs);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAllProductsAsync(CancellationToken cancellationToken)
    {
        AppDbContext context = new();
        IList<Product> producst =
            await context.Products
            .ToListAsync(cancellationToken);

        return Ok(producst.Take(10));
    }
}
