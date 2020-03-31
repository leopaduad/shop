using Shop.Domain.Interfaces;

namespace Shop.Domain.Entities
{
    public class Produto : Entity
    {
        public Produto(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
    }
}
