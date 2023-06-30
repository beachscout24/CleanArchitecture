

using Domain.Products;
using MediatR;

namespace Application.Products.Create;

internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
{
	private readonly IProductRepository _productRepository;

	public CreateProductCommandHandler(IProductRepository productRepository)
	{
		_productRepository = productRepository;
	}

	public Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
