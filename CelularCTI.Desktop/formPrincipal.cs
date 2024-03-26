using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CelularCTI.Model.Entidades;
using CelularCTI.Model;

namespace CelularCTI.Desktop
{
    public partial class formPrincipal : Form
    {
        private List<Aparelho> aparelhos = new List<Aparelho>();
        private List<Fabricante> fabricantes = new List<Fabricante>();
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            fabricantes = Servico.BuscarFabricante();
            cmbFabricante.DataSource = fabricantes;
            cmbFabricante.DisplayMember = "Nome";
            cmbFabricante.ValueMember = "id_fabricante";

            aparelhos = Servico.BuscarAparelho();
            lstCelulares.DataSource = aparelhos;
        }

        private void numPrecoInicial_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisarModelo_Click(object sender, EventArgs e)
        {
            aparelhos = Servico.BuscarAparelho(txtModelo.Text);
            lstCelulares.DataSource = aparelhos;

        }

        private void btnPesquisarPreco_Click(object sender, EventArgs e)
        {
            aparelhos = Servico.BuscarAparelho(
                                numPrecoMinimo.Value,
                                numPrecoMaximo.Value);
            lstCelulares.DataSource = aparelhos;
        }
    }
}
