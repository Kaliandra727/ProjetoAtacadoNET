using Atacado.Domain.RH;
using Atacado.POCO.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.RH
{
    public static class EmpresaMap
    {
        public static EmpresaPOCO ConverterParaPoco(Empresa modelo)
        {
            return new EmpresaPOCO()
            {
                Codigo = modelo.Codigo,
                Telefone = modelo.Telefone,
                Email = modelo.Email,
                Endereco = modelo.Endereco,
                RazaoSocial = modelo.RazaoSocial,
                NomeFantasia = modelo.NomeFantasia,
                Cnpj = modelo.Cnpj,
                InscricaoEstadual = modelo.InscricaoEstadual
            };
        }

        public static Empresa ConverterParaDomain(EmpresaPOCO poco)
        {
            return new Empresa(poco.Codigo, poco.Telefone, poco.Email, poco.Endereco, poco.RazaoSocial,
                poco.NomeFantasia, poco.Cnpj, poco.InscricaoEstadual);
        }
    }
}
