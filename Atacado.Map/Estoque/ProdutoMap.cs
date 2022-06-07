using Atacado.Domain.Estoque;
using Atacado.POCO.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.Estoque
{
    public static class ProdutoMap
    {
        public static ProdutoPOCO ConverterParaPoco(Produto modelo)
        {
            return new ProdutoPOCO()
            {
                Codigo = modelo.Codigo,
                CodSubcategoria = modelo.CodigoSubcatergoria,
                CodCategoria = modelo.CodigoCategoria,
                Descricao = modelo.Descricao,
                Situacao = modelo.Situacao
            };
        }

        public static Produto ConverterParaDomain(ProdutoPOCO poco)
        {
            return new Produto(poco.Codigo,poco.CodSubcategoria, poco.CodCategoria , poco.Descricao, poco.Situacao);
        }
    }
}
