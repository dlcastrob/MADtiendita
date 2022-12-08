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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace AVANCE2
{
    public partial class VENTA : Form
    {
        public VENTA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void VENTA_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToLongTimeString();
            label11.Text = DateTime.Now.ToShortDateString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {


                    Document doc = new Document(PageSize.LETTER, 10, 10, 42, 35);
                    try
                    {
                        doc.Open();

                        PdfPTable table = new PdfPTable(dgvArticulosAgregados.Columns.Count);

                        for (int j = 0; j < dgvArticulosAgregados.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dgvArticulosAgregados.Columns[j].HeaderText));
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dgvArticulosAgregados.Rows.Count; i++)
                        {
                            for (int k = 0; k < dgvArticulosAgregados.Columns.Count; k++)
                            {
                                if (dgvArticulosAgregados[k, i].Value != null)
                                {
                                    table.AddCell(new Phrase(dgvArticulosAgregados[k, i].Value.ToString()));
                                }
                            }
                        }
                        doc.Add(table);
                        /* PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(tbPrueba.Text)); */
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }
    }
}
