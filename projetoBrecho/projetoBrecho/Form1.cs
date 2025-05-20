using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoBrecho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //Produtos//
            categoriaProducts.Items.Add("Peças de corpo inteiro");
            categoriaProducts.Items.Add("Peças inferiores");
            categoriaProducts.Items.Add("Camisetas");
            categoriaProducts.Items.Add("Casacos");
            categoriaProducts.Items.Add("Acessórios");
            categoriaProducts.Items.Add("Calçados");
            categoriaProducts.Items.Add("Variedades");

        }

        private void produtoText_Click(object sender, EventArgs e)
        {

        }

        private void precoText_Click(object sender, EventArgs e)
        {

        }

        private void produtoBox_TextChanged(object sender, EventArgs e)
        {
            int limiteDeCaracteres = 25;

            if (produtoBox.Text.Length > limiteDeCaracteres)
            {

                produtoBox.Text = produtoBox.Text.Substring(0, limiteDeCaracteres);

                MessageBox.Show($"Limite de {limiteDeCaracteres} caracteres atingido!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void precoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoriaProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataDeEnvio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void botaoEnvio_Click(object sender, EventArgs e)
        {

            string nome = produtoBox.Text.Trim();
            string precoTexto = precoBox.Text.Trim();
            string categoriaSelecionada = categoriaProducts.SelectedItem?.ToString();
            bool estaDisponivel = disponibilidade.Checked;
            DateTime envio = dataDeEnvio.Value;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O nome do produto não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(precoTexto) || !decimal.TryParse(precoTexto, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("O preço deve ser um número maior que zero e não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (envio < DateTime.Now.Date)
            {
                MessageBox.Show("A data de envio deve ser maior ou igual a data atual.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"Produto {nome} cadastrado com sucesso! " +
                $"Preço: R$ {preco:F2}. Categoria: {categoriaSelecionada}. " +
                $"Disponível: {(estaDisponivel ? "Sim" : "Não")}. Data de envio: {envio.ToShortDateString()}",
                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void botaoClear_Click(object sender, EventArgs e)
        {
            produtoBox.Text = "";
            precoBox.Text = "";
            categoriaProducts.SelectedIndex = -1;
            disponibilidade.Checked = false;
            dataDeEnvio.Value = DateTime.Now;
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
