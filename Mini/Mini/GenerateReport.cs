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
    public partial class GenerateReport : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter prog;
        public GenerateReport()
        {
            InitializeComponent();
        }

        private void GenerateReport_Load(object sender, EventArgs e)
        {

            DataTable data = new DataTable();
            conn.Open();
            String ans = "SELECT Title AS 'Project', FirstName+ ' ' + LastName AS 'Advisor'  , (SELECT Value From [Lookup] where [Lookup].Id = AdvisorRole AND Category = 'ADVISOR_ROLE') AS 'ROLE', AssignmentDate FROM ((Project JOIN ProjectAdvisor ON ProjectId = Id) JOIN Advisor ON AdvisorId = Advisor.Id) JOIN Person ON Person.Id = Advisor.Id";
            SqlCommand cm= new SqlCommand(ans, conn);
            //SqlDataAdapter d = new SqlDataAdapter();
            //d = ExcecuteSCALARNONQUERY
            SqlDataAdapter d = new SqlDataAdapter();
            d.SelectCommand = cm;
            d.Fill(data);
            Advisors.DataSource = data;
            conn.Close();
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


            foreach (DataGridViewRow row in Advisors.Rows)
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


        private void AddB_Click(object sender, EventArgs e)
        {
            exportGridToPDF(Advisors, "Generate pdf");
        }
    }
}
