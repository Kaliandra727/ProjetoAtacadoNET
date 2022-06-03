using Atacado.Modelo.Estoque;
using Atacado.POCO.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.Estoque
{
    public static class CategoriaMap
    {
        public static CategoriaPOCO ConverterParaPoco(Categoria modelo)
        {
            return new CategoriaPOCO()
            {
                Codigo = modelo.Codigo,
                Descricao = modelo.Descricao,
                Situacao = modelo.Situacao
            };
        }

        public static Categoria ConverterParaModelo(CategoriaPOCO poco)
        {
            return new Categoria(poco.Codigo, poco.Descricao, poco.Situacao);
        }
    }
}
