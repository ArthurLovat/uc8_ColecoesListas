namespace uc8_ColecoesListas
{
    public partial class Form1 : Form
    {
        //lista global para armazenamento de nomes
        public static List<string> nomes = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            nomes.Add(txtNome.Text);
            AtualizarNomes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            nomes.Remove(txtNome.Text);
            AtualizarNomes();

        }
        private void AtualizarNomes()
        {
            txtLista.Clear();
            for (int i = 0; i < nomes.Count; i++)
            {
                txtLista.AppendText(nomes[i] + Environment.NewLine);
            }

            //foreach (string nome in nomes) outra forma de resolver
            //{
            //    txtLista.AppendText(nome + Environment.NewLine);
            //}
        }

        private void brnAlterar_Click(object sender, EventArgs e)
        {
            int idx = nomes.IndexOf(txtNome.Text);

            if (idx > -1)
            {
                nomes[idx] = txtNovoNome.Text;
            }
            AtualizarNomes();
        }

        private void btnCrescente_Click(object sender, EventArgs e)
        {
            nomes.Sort();
            AtualizarNomes();
        }

        private void btnDecrescente_Click(object sender, EventArgs e)
        {
            nomes.Reverse();
            AtualizarNomes();
        }
    }
}
