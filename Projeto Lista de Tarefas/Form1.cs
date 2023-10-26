namespace Projeto_Lista_de_Tarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string tarefa, data, hora, datalimite;

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (txtTarefa.Text == "")
            {
                MessageBox.Show("Preencha todos os Campos!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tarefa = txtTarefa.Text;
                datalimite = dateTimePicker1.Value.ToString();
            }
        }
    }
}