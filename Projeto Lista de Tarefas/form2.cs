using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;

namespace Projeto_Lista_de_Tarefas
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Arquivos de Imagem| *.jpg;*.jpeg;*.png;*.gif;*.bmp";
                ofd.Title = "Selecione uma imagem";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Carrega a imagem selecionada na picturebox
                    foto.Image  = new System.Drawing.Bitmap(ofd.FileName);
                }
            }
        }
    }

}
