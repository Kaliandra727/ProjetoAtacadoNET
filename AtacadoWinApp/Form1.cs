using Atacado.POCO.RH;
using Atacado.Service.RH;

namespace AtacadoWinApp
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Oi Mundo!!");
            // MessageBox.Show("Oi Mundo!!", "Mensagem");
            //MessageBox.Show("Oi Mundo!!", "Mensagem", MessageBoxButtons.OK);
            MessageBox.Show("Oi Mundo!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FecharBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void ValidarBtn_Click(object sender, EventArgs e)
        //{
        //    if(CpfTxt.Text == string.Empty )
        //    {
        //        string mensagem = "- CPF não pode ser vazio.";
        //        MessageBox.Show(mensagem,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    FuncionarioPOCO poco = new FuncionarioPOCO()
        //    {
        //        Cpf = CpfTxt.Text
        //    };
        //    FuncionarioService srv = new FuncionarioService();
        //    if (srv.Validar(poco) == false)
        //    {
        //        string mensagem = srv.MensagensDeErro.Aggregate((x, y) => x + ";\n" + y);
        //        MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        string mensagem = "CPF válido";
        //        MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    return;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AdicionarFuncionarioMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarFuncionariosFrm frm = new AdicionarFuncionariosFrm();
            frm.ShowDialog();
        }
    }
}