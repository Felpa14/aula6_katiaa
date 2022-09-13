namespace aula6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Time obj = new Time();
        Time[] v = new Time[10];
        int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
        //    Time timinho = new Time("Brasil", "SP");
        //    MessageBox.Show("Nome: " + timinho.Nome + "\nPáis: " + timinho.Pais + "\nEstado: " +timinho.Estado + "\nTitulo: " + timinho.Titulo);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                obj.Nome = txtNome.Text;
                obj.Pais = txtPais.Text;
                obj.Estado = txtEstado.Text;
                obj.Titulo = Convert.ToInt32(txtTitulo.Text);
                v[i] = obj;
                i++;
            }
            else
            {
                MessageBox.Show("Não é possível gravar!");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            for(int j = 0; j < 10; j++)
            {
                if (v[j].Nome.Equals(txtNome.Text))
                {
                 
            Time timinho = new Time();
            MessageBox.Show("Nome: " + timinho.Nome + "\nPáis: " + timinho.Pais + "\nEstado: " +timinho.Estado + "\nTitulo: " + timinho.Titulo);
        }

    }
}