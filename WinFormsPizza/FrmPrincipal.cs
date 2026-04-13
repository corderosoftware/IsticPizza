namespace WinFormsPizza
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            FrmListaClientes clientes = new FrmListaClientes();
            clientes.ShowDialog();
        }
    }
}
