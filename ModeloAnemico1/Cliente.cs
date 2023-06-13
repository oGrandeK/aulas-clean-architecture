namespace ModeloAnemico1;

public sealed class Cliente
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Endereco { get; private set; }

    public Cliente(int id, string nome, string endereco)
    {
        Validar(id, nome, endereco);
        Id = id;
        Nome = nome;
        Endereco = endereco;
    }

    public void Update(int id, string nome, string endereco)
    {
        Validar(id, nome, endereco);
        Id = id;
        Nome = nome;
        Endereco = endereco;
    }

    private void Validar(int id, string nome, string endereco)
    {
        if (id < 0) throw new InvalidOperationException("O Id tem que ser maior que 0");

        if (String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(endereco)) throw new InvalidOperationException("O nome e o endereço são requiridos");

        if (nome.Length < 3) throw new InvalidOperationException("O nome deve possuir mais que 3 caracteres");

        if (nome.Length > 100) throw new InvalidOperationException("O nome não deve possuir mais que 100 caracteres");
    }
}