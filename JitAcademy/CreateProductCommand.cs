using MediatR;

namespace WebApplication4;

public class CreateProductCommand : IRequest<int>
{
    public CreateProductCommand(string name, bool isOrdered)
    {
        Name = name;
        IsOrdered = isOrdered;
    }

    public string Name { get; set; }
    public bool IsOrdered { get; set; }
}

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
{
    private readonly ProductRepository _repository;

    public CreateProductCommandHandler(ProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        var product = new Product()
        {
            Name = command.Name,
            IsOrdered = command.IsOrdered
        };
        _repository.AddProduct(product);
        return 0;
    }
}