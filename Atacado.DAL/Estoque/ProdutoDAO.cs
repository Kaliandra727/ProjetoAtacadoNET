using Atacado.DAL.Ancestral;
using Atacado.FakeDB.Estoque;
using Atacado.Modelo.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DAL.Estoque
{
    public class ProdutoDAO : BaseAncestralDAO<Produto>
    {
        public override Produto Create(Produto obj)
        {
            int chave = ProdutoFakeDB.Produtos.Max(cat => cat.Codigo) + 1;
            obj.Codigo = chave;
            ProdutoFakeDB.Produtos.Add(obj);
            return obj;
        }

        public override Produto Read(int id)
        {
            Produto obj = ProdutoFakeDB.Produtos.SingleOrDefault(sub => sub.Codigo == id);
            return obj;
        }

        public override List<Produto> ReadAll()
        {
            return ProdutoFakeDB.Produtos;
        }

        public override Produto Update(Produto obj)
        {
            Produto alt = this.Read(obj.Codigo);
            alt.CodigoSubcatergoria = obj.CodigoSubcatergoria;
            alt.CodigoCategoria = obj.CodigoCategoria;
            alt.Descricao = obj.Descricao;
            alt.Situacao = obj.Situacao;
            return alt;
        }

       public override Produto Delete(int id)
        {
            Produto del = this.Read(id);
            ProdutoFakeDB.Produtos.Remove(del);
            return del;
        }

        public override Produto Delete(Produto obj)
        {
            return this.Delete(obj.Codigo);
        }

    }
}
