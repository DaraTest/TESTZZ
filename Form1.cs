using System;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;

namespace TESTneu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenMatrix.Click += new System.EventHandler(this.GenMatrix_Click);
            SaveMatrix.Click += new System.EventHandler(this.SaveMatrix_Click);
        }

        private void GenMatrix_Click(object sender, EventArgs e)
        {
            int rows = int.Parse(eingabeZeile.Text);
            int cols = int.Parse(eingabeSpalten.Text);

            dataGridView1.ColumnCount = cols;
            dataGridView1.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridView1.Columns[i].Name = "Col " + (i + 1);
            }
        }

        private void SaveMatrix_Click(object sender, EventArgs e)
        {
            int rows = dataGridView1.RowCount;
            int cols = dataGridView1.ColumnCount;

            double[,] matrixData = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        double.TryParse(dataGridView1[j, i].Value.ToString(), out matrixData[i, j]);
                    }
                }
            }

            var matrix = Matrix<double>.Build.DenseOfArray(matrixData);

            string latex = "\\begin{pmatrix}\n";

            for (int i = 0; i < rows; i++)
            {
                bool isRowEmpty = true;
                for (int j = 0; j < cols; j++)
                {
                    if (matrixData[i, j] != 0)
                    {
                        isRowEmpty = false;
                        break;
                    }
                }
                if (isRowEmpty) continue;

                for (int j = 0; j < cols; j++)
                {
                    latex += matrix[i, j];
                    if (j < cols - 1)
                    {
                        latex += " & ";
                    }
                }
                if (i < rows - 1)
                {
                    latex += " \\\\\n";
                }
            }

            latex += "\n\\end{pmatrix}";

            textBoxAusgabeMatrix.Text = latex;
        }
    }
}
