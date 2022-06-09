using Atacado.POCO.RH;
using Atacado.Service.RH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtacadoWinApp
{
    public partial class AdicionarFuncionariosFrm : Form
    {
        public AdicionarFuncionariosFrm()
        {
            InitializeComponent();
            this.PreencheSexoCmb();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CodigoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FecharBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalvarBtn_Click(object sender, EventArgs e)
        {

            FuncionarioPOCO poco = new FuncionarioPOCO()
            {
                Cpf = CpfTxt.Text,
                Nome = NomeTxt.Text,
                SobreNome = SobrenomeTxt.Text,
                Telefone = TelefoneTxt.Text,
                Email = EmailTxt.Text,
                Rg = RgTxt.Text,
                Endereco = EnderecoTxt.Text,
                DtNascimento = DtNascimentoDtp.Value,
                Sexo = SexoCmb.SelectedValue.ToString()
                };

                FuncionarioService srv = new FuncionarioService();
                if (srv.Validar(poco) == false)
                {
                    string mensagem = srv.MensagensDeErro.Aggregate((x, y) => x + ";\n" + y);
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string mensagem = "CPF válido";
                    MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
        }

        private void DtNascimentoDtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AdicionarFuncionariosFrm_Load(object sender, EventArgs e)
        {

        }

        private void PreencheSexoCmb()
        {
            SexoCmb.Items.Clear();

            SexoCmb.DisplayMember = "Value";
            SexoCmb.ValueMember = "Key";

            Dictionary<string, string> itens = new Dictionary<string, string>();
            itens.Add("M", "Masculino");
            itens.Add("F", "Feminino");

            SexoCmb.DataSource = new BindingSource(itens, null);

            SexoCmb.SelectedIndex = 0;
        }
    }
}
