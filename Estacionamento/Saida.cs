using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Saida : Form
    {
        DAO dao;
        public Saida()
        {
            dao = new DAO("Estacionamento");
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            string placa = ConPlaca();
            DateTime dataS = DateTime.Now;
            DateTime horaS = DateTime.Now;
            dao.SaidaBoa(dataS, horaS);
            MessageBox.Show("" + dataS, "" + horaS);
            //dao.VetorDataS();
            
        }//Fim do botão confirmar

        private void Placa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public string ConPlaca()
        {
            return Placa.Text;
        }//Fim do método para confirmar Placa

        private void Saida_Load(object sender, EventArgs e)
        {

        }
    }//Fim da classe
}//Fim do projeto
