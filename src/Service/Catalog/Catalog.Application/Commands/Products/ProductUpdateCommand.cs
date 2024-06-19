namespace Catalog.Application.Commands.Products
{
    public class ProductUpdateCommand : ProductCommand
    {
        public Guid Id { get; set; }
    }
}
