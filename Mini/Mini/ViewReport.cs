using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace Mini
{
    public partial class ViewReport : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter prog;
        public ViewReport()
        {
            InitializeComponent();
        }

        public void exportGridToPDF(DataGridView dataGridView, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dataGridView.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //Add header
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    string str = string.Format("Date: {0}", DateTime.Now);
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }

        }


        public void exportGridToPDF1(DataGridView dataGridView, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dataGridView.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //Add header
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }


            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    string str = string.Format("Date: {0}", DateTime.Now);
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }

        }
        public void exportGridToPDF2(DataGridView dataGridView, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dataGridView.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //Add header
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }


            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    string str = string.Format("Date: {0}", DateTime.Now);
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }

        }

        public void exportGridToPDF3(DataGridView dataGridView, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dataGridView.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //Add header
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }


            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    string str = string.Format("Date: {0}", DateTime.Now);
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }

        }
        private void ViewReport_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            conn.Open();
            String ans = "SELECT * from Free_Advisor ";
            SqlCommand cm = new SqlCommand(ans, conn);
            //SqlDataAdapter d = new SqlDataAdapter();
            //d = ExcecuteSCALARNONQUERY
            SqlDataAdapter d = new SqlDataAdapter();
            d.SelectCommand = cm;
            d.Fill(data);
            dataGridView1.DataSource = data;
            conn.Close();



            DataTable data1 = new DataTable();
            conn.Open();
            String a = "SELECT * from list ";
            SqlCommand c = new SqlCommand(a, conn);
            //SqlDataAdapter d = new SqlDataAdapter();
            //d = ExcecuteSCALARNONQUERY
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = c;
            da.Fill(data);
            dataGridView2.DataSource = data;
            conn.Close();


            DataTable de = new DataTable();
            conn.Open();
            String b = "SELECT * from ad_st ";
            SqlCommand ca = new SqlCommand(b, conn);
            //SqlDataAdapter d = new SqlDataAdapter();
            //d = ExcecuteSCALARNONQUERY
            SqlDataAdapter dad = new SqlDataAdapter();
            dad.SelectCommand = ca;
            dad.Fill(data);
            dataGridView3.DataSource = data;
            conn.Close();

            DataTable dade = new DataTable();
            conn.Open();
            String bab = "SELECT * from CountOFpROJECT  ";
            SqlCommand cat = new SqlCommand(bab, conn);
            //SqlDataAdapter d = new SqlDataAdapter();
            //d = ExcecuteSCALARNONQUERY
            SqlDataAdapter dac = new SqlDataAdapter();
            dac.SelectCommand = cat;
            dac.Fill(data);
            dataGridView5.DataSource = data;
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            exportGridToPDF(dataGridView1, "Generate pdf");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exportGridToPDF1(dataGridView2, "Generate pdf");
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            exportGridToPDF2(dataGridView3, "Generate pdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportGridToPDF3(dataGridView5, "Generate pdf");
        }
    }
}
