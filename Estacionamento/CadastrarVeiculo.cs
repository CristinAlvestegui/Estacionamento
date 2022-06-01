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
    public partial class CadastrarVeiculo : Form
    {
        Auto vei;
        public CadastrarVeiculo()
        {
            vei = new Auto("Estacionamento");
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cor_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarVeiculo_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Salvar_Click(object sender, EventArgs e)
        {
            string placa = EntradaPlaca();
            string modelo = EntraModelo();
            string cor = EntraCor();
            vei.inserirVeiculo(placa, modelo, cor);
            Placa.Clear();
            Modelo.Clear();
            Cor.Clear();
        }
        public string EntradaPlaca()
        {
            return Placa.Text;
        }



        public string EntraModelo()
        {
            return Placa.Text;
        }



        public string EntraCor()
        {
            return Cor.Text;
        }

        private void Placa_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }//Fim da classe
}//Fim do projeto
