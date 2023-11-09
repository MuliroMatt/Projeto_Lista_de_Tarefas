using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Lista_de_Tarefas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            Form1 tarefas = new Form1();
            tarefas.ShowDialog();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            form2 cad = new form2();
            cad.ShowDialog();
        }
    }
}
