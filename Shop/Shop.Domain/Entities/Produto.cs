using Shop.Domain.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Shop.Domain.Entities
{
    public class Produto : Entity
    {
        public Produto(string nome, decimal valor, IEnumerable<string> listaImagens)
        {
            Nome = nome;
            Valor = valor;
            imagens = listaImagens;
        }
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
        public string ValorFormatado { get { return Valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")); } set { } }

        public IEnumerable<string> imagens { get; set; }
    }
}
