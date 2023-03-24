using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DadosParaGeraçãoDeArquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarLinhas_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            int numeroFuncionarios = Convert.ToInt32(txtNFuncionarios.Text);

            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Salário",typeof
                (int));

            for (int i = 0; i < numeroFuncionarios; i++)
            {
                DataRow row = table.NewRow();
                table.Rows.Add(row);
            }
            dataGridView1.DataSource = table;


        }

        private void txtNFuncionarios_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCriarArquivo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Salvar arquivo";
            saveFileDialog.Filter = "Arquivo de Texto (*.txt)|*.txt";
            saveFileDialog.FileName = "minhaTabela.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string line = "";
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            line += cell.Value.ToString() + "\t";
                        }
                        writer.WriteLine(line.TrimEnd('\t'));
                    }
                }
            }
        }
    }
}
