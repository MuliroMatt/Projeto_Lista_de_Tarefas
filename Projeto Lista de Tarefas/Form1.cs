using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Policy;

namespace Projeto_Lista_de_Tarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            data = DateTime.Now.ToString("yyyy-MM-dd");
            lblData.Text = data;
            
        }
        string tarefa, data, hora, datalimite;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExibirDados();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (txtTarefa.Text == "")
            {
                MessageBox.Show("Preencha todos os Campos!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTarefa.Focus(); 
            }
            else
            {
                tarefa = txtTarefa.Text;
                datalimite = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                hora = lblHora.Text;
                



                using (StreamWriter writer = new StreamWriter("C:\\Users\\" +
                    "murilo.amattiuzzi.SENACEDU\\Documents\\arquivos\\tarefas.txt", true))
                {
                    writer.WriteLine($"Tarefa: {tarefa}\n" +
                        $"Criação: {data} as {hora}\n" +
                        $"Data Limite: {datalimite}");
                    writer.WriteLine("-------------------------------------\n");
                }
                lblStatus.Text = "Tarefa Criada!";
                LimparCampos();
                ExibirDados();
            }
        }
        private void LimparCampos()
        {
            txtTarefa.Clear();
            txtTarefa.Focus();
        }
        private void ExibirDados()
        {
            listTarefas.Items.Clear();
            string[] linhas = File.ReadAllLines("C:\\Users\\murilo.amattiuzzi.SENACEDU" +
                "\\Documents\\arquivos\\tarefas.txt");
            listTarefas.Items.AddRange(linhas);
        }

    }
}