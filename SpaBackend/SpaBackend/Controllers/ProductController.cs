using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpaBackend.Db;

namespace SpaBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController:ControllerBase
{
    private SpaDbContext db;

    public ProductController(SpaDbContext db)
    {
        this.db = db;
    }

    [HttpGet("all")]
    public async Task<ActionResult> GetAll()
    {
        return Ok(await db.Products.ToListAsync());
    }
}