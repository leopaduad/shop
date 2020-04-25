using Shop.Domain.Entities;
using System.Collections.Generic;

namespace Shop.UI.Models
{
    public class ProdutoViewModel
    {
        public IEnumerable<Produto> produtos { get; set; }
        public Produto produto { get; set; }
    }
}
