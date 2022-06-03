using Atacado.Modelo.Estoque;
using Atacado.POCO.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.Estoque
{
    public static class SubcategoriaMap
    {
        public static SubcategoriaPOCO ConverterParaPoco(Subcategoria modelo)
        {
            return new SubcategoriaPOCO()
            {
                Codigo = modelo.Codigo,
                CodigoCategoria = modelo.CodigoCategoria,
                Descricao = modelo.Descricao,
                Situacao = modelo.Situacao
            };
        }

        public static Subcategoria ConverterParaModelo(SubcategoriaPOCO poco)
        {
            return new Subcategoria(poco.Codigo, poco.CodigoCategoria, poco.Descricao, poco.Situacao);
        }
    }
}
