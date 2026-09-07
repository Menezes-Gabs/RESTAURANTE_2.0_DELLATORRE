using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANTE_2._0_DELLATORRE
{
    public partial class FrmRestaurante : Form
    {
        /*"pega os dados" da classe criada e traz pra ca*/
        ClassCalculo conta = new ClassCalculo();
        public FrmRestaurante()
        {
            InitializeComponent();
        }
        //serve para atualizar o label de saida sempre que trocar algo
        private void AtualizarTotal()
        {
            conta.Calcular(
            CboAlmoco.Checked,
            CboRefrig.Checked,
            CboCerveja.Checked,
            CboSuco.Checked);

            /*se for aniversariante, ja puxa desconto*/
            bool Aniversario = lblAniversario.Visible;
            conta.DescontoAniversariante(Aniversario);

            /*"f2" deixa o desconto nao quebrar o valor final,fica fixo em duas casas decimais*/
            lblSaida.Text = "Total: R$ " + conta.TotalFinal.ToString("F2");
        }

        private void FrmRestaurante_Load(object sender, EventArgs e)
        {
            //deixa a caixa de data de nascimento zerada, é melhor assim
            DtpClient.Format = DateTimePickerFormat.Custom;
            DtpClient.CustomFormat = " ";
            
        }

        /*mostra os dois groupbx somente de a caixa estiver checkada*/
        private void CboAlmoco_CheckedChanged(object sender, EventArgs e)
        {
            GpbAlmoco.Visible = CboAlmoco.Checked;
            AtualizarTotal();
        }

        private void CboBebidas_CheckedChanged(object sender, EventArgs e)
        {
            GpbBebidas.Visible = CboBebidas.Checked;
        }

        private void DtpClient_ValueChanged(object sender, EventArgs e)
        {
            //se o usuario colocar mes e dia de nascimento igual ao de hoe (marcado no sistema) mostra o textinho de desconto aplicado
            DtpClient.Format =
                DateTimePickerFormat.Short;
            DtpClient.CustomFormat = "dd/MM/yyyy";

            DateTime nascimento = DtpClient.Value;
            DateTime hoje = DateTime.Today;

            lblAniversario.Visible =
                nascimento.Day == hoje.Day &&
                nascimento.Month == hoje.Month;

            AtualizarTotal();
        }

        /*puxa a função criada para atualizar o preço no label*/
        private void CboRefrig_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void CboCerveja_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void CboSuco_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {                        
            // 1. Instancia aclasse de recibo
            ClassRecibo gerador = new ClassRecibo();

            // chama classe
            string reciboPronto = gerador.GerarTextoRecibo(
                txtNomeClient.Text,
                DtpClient.Text,
                txtOnde.Text,
                CboAlmoco.Checked,
                CboRefrig.Checked,
                CboCerveja.Checked,
                CboSuco.Checked,
                lblSaida.Text
            );            
            FrmRecibo telaRecibo = new FrmRecibo(reciboPronto);
            telaRecibo.ShowDialog();
        }
    }
}