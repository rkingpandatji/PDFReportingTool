using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using iTextSharp.text.pdf.draw;

namespace PDFReporting
{
    public partial class Form1 : Form
    {
        Cursor cursor;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPDFGenerate_Click(object sender, EventArgs e)
        {
            cursor = Cursors.WaitCursor;
            PDFGenerate();
            Directory.CreateDirectory(Application.StartupPath+"\\Temp");
            pdfViewer.LoadFile(Application.StartupPath + "\\Temp\\OutPut.pdf");
            cursor = Cursors.Default;
        }

        #region PDF
        private void PDFGenerate()
        {
            //Chunk is used here for printing the two paragrapsh in single line but one in left and another in right.
            Chunk glue = new Chunk(new VerticalPositionMark());
           
            //boldFont makes the font BOLD.
            var boldFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD);
           
            //It defines the Page Size
            Document document = new Document(PageSize.LETTER);
            PdfWriter.GetInstance(document, new FileStream(Application.StartupPath + "\\Temp\\OutPut.pdf", FileMode.OpenOrCreate));
            document.Open();

            //It is to set the image in pdf.
            var jkboseLogo = Application.StartupPath + "\\Resources\\header.png";
            using (FileStream fs = new FileStream(jkboseLogo, FileMode.Open))
            {
                var png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                png.ScalePercent(50f);
                png.SetAbsolutePosition(document.Left + 40, document.Top - 140);
                document.Add(png);
            }

            //Paragraph is used to set the text in pdf
            Paragraph headerSpacer = new Paragraph("")
            {
                SpacingBefore = 160f,
                SpacingAfter = 40f,
            };
            document.Add(headerSpacer);

            Paragraph p = new Paragraph("Performa of Verification & Approval");
            p.Alignment = Element.ALIGN_CENTER;
            document.Add(p);

            Paragraph spacer = new Paragraph("")
            {
                SpacingBefore = 30f,
                SpacingAfter = 30f,
            };
            document.Add(spacer);

            Paragraph region = new Paragraph("Region - " + cobRegion.SelectedItem.ToString())
            {
                SpacingAfter = 10f,
            };
            region.Alignment = Element.ALIGN_LEFT;
            document.Add(region);

            Paragraph year = new Paragraph("Year - " + txtExamYear.Text);
            year.Add(new Chunk(glue));
            year.Add("Semester - " + txtSemester.Text);
            document.Add(year);

            //PdfPTable is used to make the table on the pdf.
            var table = new PdfPTable(new[] { 2f, 2f })
            {
                WidthPercentage = 75,
                DefaultCell = { MinimumHeight = 22f },
                SpacingBefore = 20f,
                SpacingAfter = 20f
            };

            table.AddCell("No Of Candidates");
            table.AddCell(txtNoOfCandidates.Text);
            table.AddCell("No of Register scan in Appl / Exam form");
            table.AddCell(txtApplSacn.Text);
            table.AddCell("No of register scan in RR register");
            table.AddCell(txtNoOfRRScan.Text);
            table.AddCell("No of register scan in result sheet");
            table.AddCell(txtNoOfResultScan.Text);
            document.Add(table);


            Paragraph verifDate = new Paragraph("Date Of Handover for Verification - ");
            verifDate.Add(new Chunk(glue));
            verifDate.Add("Handed over for Verification");
            document.Add(verifDate);



            Paragraph dcs = new Paragraph("For Datasoft Computer Services Pvt Ltd", boldFont) { SpacingBefore = 10f, SpacingAfter = 15f };
            dcs.Alignment = Element.ALIGN_RIGHT;
            document.Add(dcs);

            Paragraph para = new Paragraph("This is to certify that, we have checked and verified record and found the same to be properly scanned and digitized.On the bases of sample records checked, we confirm and accept images and data of complete year.We also confirm this images and data can be further taken for final uploading and billing purpose.")
            {
                SpacingAfter = 20f,
                SpacingBefore = 10f
            };
            para.Alignment = Element.ALIGN_JUSTIFIED;
            document.Add(para);

            Paragraph approveDate = new Paragraph("Date of Verification and approval ‐ ");
            approveDate.Add(new Chunk(glue));
            approveDate.Add("Verified and Approved by");
            document.Add(approveDate);

            Paragraph jkbose = new Paragraph("For Jammu & Kashmir Board of School Education", boldFont) { SpacingBefore = 20f };
            jkbose.Alignment = Element.ALIGN_RIGHT;
            document.Add(jkbose);

            document.Close();
        }

        #endregion

        private void OnlyNumberic(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;

            }
        }

        private void txtExamYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumberic(e);
        }

        private void txtNoOfCandidates_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumberic(e);
        }

        private void txtApplSacn_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumberic(e);
        }

        private void txtNoOfRRScan_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumberic(e);
        }

        private void txtNoOfResultScan_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumberic(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pdfViewer.Refresh();
            File.Delete(Application.StartupPath + "\\Temp\\OutPut.pdf");
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            pdfViewer.Refresh();
            File.Delete(Application.StartupPath + "\\Temp\\OutPut.pdf");
        }

        private void btnSavePDF_Click(object sender, EventArgs e)
        {
            if(sfd.ShowDialog()==DialogResult.OK)
            {
                File.Copy(Application.StartupPath + "\\Temp\\OutPut.pdf",sfd.FileName,true);
            }
        }

        private void txtSemester_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
