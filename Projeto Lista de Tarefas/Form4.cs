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
    
    
    public partial class Form4 : Form
    {
        private System.Windows.Forms.Timer timer;
        DateTime startTimer;
        int codigo = 1;
        public Form4()
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToShortDateString();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            startTimer= DateTime.Now;
            codigo++;
            lblCodigo.Text = codigo ToString;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
