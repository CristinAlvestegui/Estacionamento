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
    public partial class Entrada : Form
    {
        DAO dao;
        public Entrada()
        {
            dao = new DAO("Estacionamento");
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           //= monthCalendar1.DateSelected();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataE = DateTime.Now;
            DateTime horaE = DateTime.Now;
            MessageBox.Show("" + dataE, "" + horaE);
            dao.EntradaBoa(dataE, horaE);
            //dao.VetorDataE();
        }//fim do botão para Entrada

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            
        }
    }//Fim da classe
}//Fim do projeto
