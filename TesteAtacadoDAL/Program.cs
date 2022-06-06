using Atacado.DAL.Estoque;
using Atacado.DAL.IBGE;
using Atacado.DAL.RH;
using Atacado.FakeDB.IBGE;
using Atacado.FakeDB.RH;
using Atacado.Domain.Estoque;
using Atacado.Domain.IBGE;
using Atacado.Domain.RH;
using Atacado.DAL.RH.Admin;

namespace TesteAtacadoDAL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Informe o código do Funcionário: ");
            int cod = Convert.ToInt32(Console.ReadLine());
            ApresentarCategoriaFunc(cod);
            Console.ReadLine();
        }

        private static void ApresentarCategoria(int id)
        {
            CategoriaDAO dao = new CategoriaDAO();
            Categoria cat = dao.Read(id);
            Imprimir(cat);
        }

        private static void Imprimir(Categoria cat)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Código: {0} | Nome: {1} | Situação: {2} ", cat.Codigo, cat.Descricao, cat.Situacao);
            Console.ResetColor();
        }

        private static void ApresentarCategoriaEst(int id)
        {
            EstadoDAO dao = new EstadoDAO();
            Estado est = dao.Read(id);
            ImprimirEst(est);
        }

        private static void ImprimirEst(Estado est)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Código: {0} | Descrição: {1} | Sigla: {2} | Região: {3} ", est.Codigo, est.Descricao, est.SiglaUF, est.RegiaoBrasil);
            Console.ResetColor();
        }

        private static void ApresentarCategoriaFunc(int id)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            Funcionario func = dao.Read(id);
            ImprimirFunc(func);
        }
        private static void ImprimirFunc(Funcionario func)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Código: {0} | Nome: {1} {2} | Sexo: {3} | Situação: {4} ", func.Codigo, func.Nome, func.SobreNome, func.Sexo, func.Situacao);
            Console.ResetColor();
        }
    }
}