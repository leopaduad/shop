
using Shop.Domain.Entities;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Shop.Infra.Data.Repository
{
    public class ProdutoRepository 
    {
        private readonly IBaseRepository _repo;
        public ProdutoRepository(IBaseRepository repo)
        {
            _repo = repo;
        }



    }
}
