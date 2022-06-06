using Atacado.Domain.RH;
using Atacado.POCO.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.RH
{
    public static class FuncionarioMap
    {
        public static FuncionarioPOCO ConverterParaPoco(Funcionario modelo)
        {
            return new FuncionarioPOCO()
            {
                Codigo = modelo.Codigo,
                Telefone = modelo.Telefone,
                Email = modelo.Email,
                Endereco = modelo.Endereco,
                Nome = modelo.Nome,
                SobreNome = modelo.SobreNome,
                Idade = modelo.Idade,
                Altura = modelo.Altura,
                Peso = modelo.Peso,
                DtNascimento = modelo.DtNascimento,
                Naturalidade = modelo.Naturalidade,
                Nacionalidade = modelo.Nacionalidade,
                Sexo = modelo.Sexo,
                Cpf = modelo.Cpf,
                Rg = modelo.Rg
            };
        }

        public static Funcionario ConverterParaModelo(FuncionarioPOCO poco)
        {
            return new Funcionario(poco.Codigo, poco.Telefone, poco.Email, poco.Endereco, poco.Nome
                , poco.SobreNome, poco.Idade, poco.Altura, poco.Peso, poco.DtNascimento, poco.Naturalidade
                , poco.Nacionalidade, poco.Sexo, poco.Cpf, poco.Rg);
        }
    }
}
