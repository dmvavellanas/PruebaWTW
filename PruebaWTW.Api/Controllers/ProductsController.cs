using MediatR;
using Microsoft.AspNetCore.Mvc;
using PruebaWTW.Application.Common.Models;
using PruebaWTW.Application.Products.Dtos;
using PruebaWTW.Application.Products.Queries.GetProducts;

namespace PruebaWTW.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [ProducesResponseType(typeof(PagedResult<ProductListItemDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<PagedResult<ProductListItemDto>>> GetList (
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 10,
        [FromQuery] string? name = null,
        CancellationToken ct = default)
    {
        var result = await _mediator.Send(new GetProductsQuery(page, pageSize, name), ct);
        return Ok(result);
    }
}
