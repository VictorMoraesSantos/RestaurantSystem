using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.Commands.Categories
{
    public class CategoryDeleteCommand : IRequest<Category>
    {
        public Guid Id { get; set; }

        public CategoryDeleteCommand(Guid id)
        {
            Id = id;
        }
    }
}
