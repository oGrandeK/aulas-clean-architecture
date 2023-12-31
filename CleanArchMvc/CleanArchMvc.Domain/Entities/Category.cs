using CleanArchMvc.Domain.Validation;

namespace CleanArchMvc.Domain.Entities;

public sealed class Category : Entity
{
    // Propriedades
    public string Name { get; private set; }
    public ICollection<Product> Products { get; set; }

    // Construtores
    public Category(string name)
    {
        ValidateDomain(name);
    }

    public Category(int id, string name)
    {
        DomainExceptionValidation.When(id < 0, "Invalid Id value");
        Id = id;
        ValidateDomain(name);
    }

    // Métodos

    public void Update(string name)
    {
        ValidateDomain(name);
    }

    private void ValidateDomain(string name)
    {
        DomainExceptionValidation.When(String.IsNullOrEmpty(name), "Invalid name.Name is required");

        DomainExceptionValidation.When(
            name.Length < 3,
            "Invalid name. Name,to short, minimun 3 characters"
        );

        Name = name;
    }
}
