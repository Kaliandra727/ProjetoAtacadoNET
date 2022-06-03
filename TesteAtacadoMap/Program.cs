using Atacado.DAL.Estoque;
using Atacado.Map.Estoque;
using Atacado.Modelo.Estoque;
using Atacado.POCO.Estoque;

namespace TesteAtacadoMap
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Imforme o código da categoria: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            CategoriaDAO dao = new CategoriaDAO();
            Categoria modelo = dao.Read(codigo);

            CategoriaPOCO poco = CategoriaMap.ConverterParaPoco(modelo);

            Console.Write("Código: {0} | Descrição: {1} | Situação: {2} ", poco.Codigo, poco.Descricao, poco.Situacao);

            Console.ReadLine();
        }
    }
}