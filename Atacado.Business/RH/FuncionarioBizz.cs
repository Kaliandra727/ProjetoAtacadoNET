using Atacado.Domain.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Business.RH
{
	public class FuncionarioBizz
	{
		private Funcionario funcionario;

		private List<string> mensagens;

		public List<string> Mensagens
		{
			get { return mensagens; }
		}

		public FuncionarioBizz()
		{
			this.mensagens = new List<string>();
		}

		public bool Executar(Funcionario obj)
		{
			this.funcionario = obj;
			if (this.ValidarCpfVazio(funcionario.Cpf) == false)
			{
				this.mensagens.Add("- CPF não pode ser vazio.");
				return false;
			}
			if (this.ValidarCpf(funcionario.Cpf) == false)
			{
				this.mensagens.Add("- Cpf inválido");
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool ExecutarRg(Funcionario obj)
		{
			this.funcionario = obj;
			if (this.ValidarRgVazio(funcionario.Rg) == false)
			{
				this.mensagens.Add("- RG não pode ser vazio.");
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool ExecutarNome(Funcionario obj)
		{
			this.funcionario = obj;
			if (this.ValidarNomeVazio(funcionario.Nome) == false)
			{
				this.mensagens.Add("- Nome não pode ser vazio.");
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool ExecutarSobrenome(Funcionario obj)
		{
			this.funcionario = obj;
			if (this.ValidarSobrenomeVazio(funcionario.SobreNome) == false)
			{
				this.mensagens.Add("- Sobrenome não pode ser vazio.");
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool ExecutarEndereco(Funcionario obj)
		{
			this.funcionario = obj;
			if (this.ValidarEnderecoVazio(funcionario.Endereco) == false)
			{
				this.mensagens.Add("- Endereço não popde ser vazio.");
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool ExecutarTelefone(Funcionario obj)
		{
			this.funcionario = obj;
			if (this.ValidarTelefoneVazio(funcionario.Telefone) == false)
			{
				this.mensagens.Add("- Telefone não pode ser vazio.");
				return false;
			}
			if (funcionario.Telefone.Length <= 10 && funcionario.Telefone.Length > 11)
			{
				this.mensagens.Add("- Telefone inválido.");
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool ExecutarEmail(Funcionario obj)
		{
			this.funcionario = obj;
			if (this.ValidarEmailVazio(funcionario.Email) == false)
			{
				this.mensagens.Add("- Email não pode ser vazio.");
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool ExecutarIdade(Funcionario obj)
        {
			if (this.ValidarIdadeVazio(funcionario.Idade) == false)
			{
				this.mensagens.Add("- Idade não pode ser vazia.");
				return false;
			}
			else if (this.ValidarDtNascimento(funcionario.DtNascimento) == false)
			{
				this.mensagens.Add("- Data de nascimento inválida.");
				return false;
			}
			else if (this.ValidarIdade(funcionario.Idade) == false)
			{
				this.mensagens.Add("- Não pode ser cadastrado, menor de 18.");
				return false;
			}
			else
			{
				return true;
			}
		}


		private bool ValidarCpfVazio(string cpf)
		{
			return !(cpf == String.Empty);
		}

		private bool ValidarCpf(string cpf)
		{
			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			string tempCpf;
			string digito;
			int soma;
			int resto;
			cpf = cpf.Trim();
			cpf = cpf.Replace(".", "").Replace("-", "");
			if (cpf.Length != 11)
				return false;
			tempCpf = cpf.Substring(0, 9);
			soma = 0;

			for (int i = 0; i < 9; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = resto.ToString();
			tempCpf = tempCpf + digito;
			soma = 0;
			for (int i = 0; i < 10; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = digito + resto.ToString();
			return cpf.EndsWith(digito);
		}

		private bool ValidarData(string data)
		{
			DateTime dtnasc;

			if (DateTime.TryParse(data, out dtnasc))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool ValidarRgVazio(string rg)
		{
			return !(rg == String.Empty);
		}

		private bool ValidarNomeVazio(string nome)
		{
			return !(nome == String.Empty);
		}

		private bool ValidarSobrenomeVazio(string sobrenome)
		{
			return !(sobrenome == String.Empty);
		}

		private bool ValidarEnderecoVazio(string endereco)
		{
			return !(endereco == String.Empty);
		}

		private bool ValidarTelefoneVazio(string telefone)
		{
			return !(telefone == String.Empty);
		}

		private bool ValidarEmailVazio(string email)
		{
			return !(email == String.Empty);
		}

		private bool ValidarDataNascVazia(string data)
		{
			return !(data == String.Empty);
		}

		private bool ValidarIdadeVazio(int? idade)
		{
			return !(idade == null);
		}

		private bool ValidarDtNascimento(DateTime dtNascimento)
		{
			DateTime dtteste;
			if (DateTime.TryParse(dtNascimento.ToString(), out dtteste))
			{
				return true;
			}
			else
			{
				return false;
			}

		}

		private bool ValidarIdade(int idade)
		{
			idade = 0;
			if (DateTime.Today.DayOfYear < funcionario.DtNascimento.DayOfYear)
			{
				idade = DateTime.Today.Year - funcionario.DtNascimento.Year - 1;
			}
			else
			{
				idade = DateTime.Today.Year - funcionario.DtNascimento.Year;
			}

			if (idade < 18)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
