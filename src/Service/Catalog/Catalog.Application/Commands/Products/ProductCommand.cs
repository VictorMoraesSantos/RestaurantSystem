using Catalog.Domain.Entities;
using Catalog.Domain.Enums;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Application.Commands.Products
{
    public class ProductCommand : IRequest<Product>
    {
        public string? Name { get; private set; }
        public string? Description { get; private set; }
        public string? ImageUrl { get; private set; }
        public decimal Price { get; private set; }
        public Category? Category { get; private set; }
        public ProductStatus Status { get; private set; }
    }
}
