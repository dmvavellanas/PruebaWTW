using MediatR;
using PruebaWTW.Application.Common.Models;
using PruebaWTW.Application.Products.Dtos;

namespace PruebaWTW.Application.Products.Queries.GetProducts;

public sealed record GetProductsQuery(
    int Page = 1,
    int PageSize = 10,
    string? Name = null
) : IRequest<PagedResult<ProductListItemDto>>;