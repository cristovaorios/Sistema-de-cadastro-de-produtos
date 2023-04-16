using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Mercado_Av01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void MostrarDados_Click(object sender, EventArgs e)
        {
            string newNomeProd = NomeProd.Text;
            string newDescProd = DescProd.Text;
            string newUnidProd = UnidProd.SelectedItem.ToString();

            string newPerecivel = "";
            if (SimPerec.Checked) { newPerecivel = "Sim"; }
            
            else { newPerecivel = "Não"; }

            string newParticPromocao = "";
            if (ParticPromo.Checked) { newParticPromocao = "Sim"; }
            
            else { newParticPromocao = "Não"; }
            
            string newLimitEstoq = "";
            if (LimitEstoq.Checked) { newLimitEstoq = "Sim"; }
            
            else { newLimitEstoq = "Não"; }
            
            string newLocalRefrig = "";
            if (LocalRefrig.Checked) { newLocalRefrig = "Sim"; }
            
            else { newLocalRefrig = "Não"; }
            
            DateTime newDataFabric = DataFabric.Value;
            DateTime newDataValid = DataValid.Value;

            string mensagem = "Nome do Produto: " + newNomeProd +
                "\nDescrição do Produto: " + newDescProd +
                "\nUnidade do Produto: " + newUnidProd +
                "\nPerecível: " + newPerecivel +
                "\nParticipa de Promoção: " + newParticPromocao +
                "\nLimite de Estoque: " + newLimitEstoq +
                "\nRequer Refrigeração: " + newLocalRefrig +
                "\nData de Fabricação: " + newDataFabric.ToString("dd/MM/yyyy") +
                "\nData de Validade: " + newDataValid.ToString("dd/MM/yyyy");

            MessageBox.Show(mensagem, "Dados do Produto");
        }

        private void LimparForm_Click(object sender, EventArgs e)
        {
            NomeProd.Clear();
            DescProd.Clear();
            UnidProd.SelectedIndex = -1;
            SimPerec.Checked = false;
            NaoPerec.Checked = false;
            ParticPromo.Checked = false;
            LimitEstoq.Checked = false;
            LocalRefrig.Checked = false;
            DataFabric.Value = DateTime.Today;
            DataFabric.Value = DateTime.Today;
        }

        private void SairForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
