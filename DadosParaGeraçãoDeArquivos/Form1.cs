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
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

       private void btnCriarLinhas_Click(object sender, EventArgs e)
        {
            
           if (table.Columns.Count == 0)
                {
                    table.Columns.Add("Nome", typeof(string));
                    table.Columns.Add("Salário", typeof
                        (int));
                }
                (int));
            int numeroFuncionarios;

            if (int.TryParse(txtNFuncionarios.Text, out numeroFuncionarios))
            {
               if(numeroFuncionarios > 0 && table.Columns.Count == 2)
                {
                    for (int i = 0; i < numeroFuncionarios; i++)
                    {
                        DataRow row = table.NewRow();
                        table.Rows.Add(row);
                    }
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for the number of employees.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else if (string.IsNullOrEmpty(txtNFuncionarios.Text))
            {
               
                MessageBox.Show("Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                MessageBox.Show("Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
         private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            txtNFuncionarios.Text = string.Empty;
            txtNFuncionarios.Enabled = true;
            btnCriarArquivo.Enabled = false;
            BtnReiniciar.Enabled = false;
            btnCriarLinhas.Enabled = true;
            BtnReiniciar.Enabled = true;
        }
            }
        }
    }
}
