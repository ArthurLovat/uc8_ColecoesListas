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

            txtLista.Clear();

            for(int i = 0; i < nomes.Count; i++)
            {
                txtLista.AppendText(nomes[i] + Environment.NewLine);
            }
        }
    }
}
