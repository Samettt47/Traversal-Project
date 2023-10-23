using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReport/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create); // verdiğim yoldaki dosyayı MOD OLARAK
                                                                // CREATE İŞLEMİNE ( YENİ YENİ OLUŞTURMA İŞLEMİ YAPACAK
            Document document = new Document(PageSize.A4); // A4 FORMATINDA BİR PDF OLUŞTUR
            PdfWriter.GetInstance(document, stream); // pdf 'i yazdırma işlemine hangi dökümanın gideceği

            document.Open(); // Dökümanı açtık

            Paragraph paragraph = new Paragraph("Treversal Rezervasyon Pdf Raporu"); // içine STATİK OLARA SIMDI BUNU YAZ
            document.Add(paragraph); // yukarıda ki veriyi yazdır
            document.Close(); // En sonunda Sonlandırıyor
            return File("/PdfReport/dosya1.pdf", "application/pdf", "dosya1.pdf"); // Burada da indirme işlemi yapıyor 3. parametrede



        }

        //  BUNU ŞİMDİ TABLO FORMATINDA YAZACAĞIZ AŞAĞIDA Kİ METOT TABLO FORMATINDA YAZAR 
        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReport/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create); // verdiğim yoldaki dosyayı MOD OLARAK
                                                                // CREATE İŞLEMİNE ( YENİ YENİ OLUŞTURMA İŞLEMİ YAPACAK
            Document document = new Document(PageSize.A4); // A4 FORMATINDA BİR PDF OLUŞTUR
            PdfWriter.GetInstance(document, stream); // pdf 'i yazdırma işlemine hangi dökümanın gideceği

            document.Open(); // Dökümanı açtık

            PdfPTable pdfPTable = new PdfPTable(3); // sutun sayısı 3 olan bir pdf tablosu olusturduk

            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir SoyAdı");
            pdfPTable.AddCell("Misafir Tc");

            pdfPTable.AddCell("Samet");
            pdfPTable.AddCell("Bayraktar");
            pdfPTable.AddCell("11111111112");

            pdfPTable.AddCell("Merve");
            pdfPTable.AddCell("Bayraktar");
            pdfPTable.AddCell("22222222223");

            pdfPTable.AddCell("Sefa");
            pdfPTable.AddCell("Bayraktar");
            pdfPTable.AddCell("33333333334");

            document.Add(pdfPTable);
            document.Close(); // En sonunda Sonlandırıyor

            return File("/PdfReport/dosya1.pdf", "application/pdf", "dosya2.pdf"); // Burada da indirme işlemi yapıyor 3. parametrede

        }
    }
}
