using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SimpleToPark
{
    public partial class SimpleToPark : Form
    {
        private DataTable bancoDeDados;
        private GerenciadorArrecadacao gerenciador;
        public SimpleToPark()
        {
            InitializeComponent();
            BancoDeDados();
            GerenteDeArrecadacao();
        }

        private void GerenteDeArrecadacao()
        {
            gerenciador = new GerenciadorArrecadacao
            {
                ValorHora = 10,
                Arrecadado = 0

            };
            lbHora.Text = $"Valor Hora R$ {gerenciador.ValorHora.ToString("0.00")}";
        }

        private void BancoDeDados()
        {
            bancoDeDados = new DataTable("Estacionamento");
            bancoDeDados.Columns.Add("Placa", typeof(string));
            bancoDeDados.Columns.Add("Entrada", typeof(string));

            DgvEstaacionado.DataSource = bancoDeDados;

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            var placa = Interaction.InputBox("Digite a placa do veiculo:", "Entrada do Veiculo");

            if (!string.IsNullOrEmpty(placa))
            {
                bancoDeDados.Rows.Add(new string[] { placa, DateTime.Now.ToString()});
                //DgvEstaacionado.Rows[DgvEstaacionado.Rows.Count - 1].MinimumHeight = 30;

            }
        }

        private void btnConfg_Click(object sender, EventArgs e)
        {
            var valorHora = Interaction.InputBox("Digite o Valor da Hora: ", "Valor da Hora");
            if (!string.IsNullOrEmpty(valorHora))
            {
                gerenciador.ValorHora = float.Parse(valorHora);
                lbHora.Text = $"Valor Hora R$ {gerenciador.ValorHora.ToString("0.00")}";
            }
        }

        private void DgvEstaacionado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                var entrada = DateTime.Parse(bancoDeDados.Rows[e.RowIndex].ItemArray[1].ToString());
                var placa = bancoDeDados.Rows[e.RowIndex].ItemArray[0].ToString();
                var arrecadado = gerenciador.CalculoEstadia(entrada);

                if (MessageBox.Show(this, $"Deseja encerrar o ticket de {placa}?" +
                    $" Valor : R$ {arrecadado.ToString("0.00")}", "Encerrar o Tiket") == DialogResult.OK)
                {
                    bancoDeDados.Rows.RemoveAt(e.RowIndex);
                    gerenciador.Arrecadado = arrecadado;
                    LbTotal.Text = $"Valor Total R$ {gerenciador.Arrecadado.ToString("0.00")}";
                }
            }

        }
    }
}
