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
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Drawing.Imaging;
using System.Diagnostics;


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
        private Bitmap CapturarTela()
        {
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            Bitmap capturarTela=new Bitmap(bounds.Width, bounds.Height);

            using(Graphics g = Graphics.FromImage(capturarTela))
            {
                g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
            }
            return capturarTela;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (Bitmap capturarTela=CapturarTela())
            {
                //SALVA A IMAGEM DA TELA EM ARQ TEMPORÁRIO
                string tempImagePath = "C:\\Users\\murilo.amattiuzzi.SENACEDU\\source" +
                    "\\repos\\Projeto Lista de Tarefas\\Projeto Lista de Tarefas\\arquivos\\temp.png";
                capturarTela.Save(tempImagePath,ImageFormat.Png);

                //CRIA UM DOCTO PDF
                PdfDocument pdfdoc = new PdfDocument();
                PdfPage page = pdfdoc.AddPage();
                XGraphics gfx= XGraphics.FromPdfPage(page);

                //ADD A IMAGEM DA TELA AO DOCTO PDF
                XImage image=XImage.FromFile(tempImagePath);
                gfx.DrawImage(image, 0, 0);

                //SALVA EM PDF
                string pdfFilePath = "C\\Users\\murilo.amattiuzzi.SENACEDU\\source" +
                    "\\repos\\ProjetoListaTarefas\\ProjetoListaTarefas\\arquivos\\ScreenShot.pdf";

                //ABRE O PDF APOS A EXECUÇÃO
                Process.Start(pdfFilePath);
            }
        }
    }

}
