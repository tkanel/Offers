using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Text;

namespace Offers
{
    public class CreateAWordDocument
    {


        public static void CreateWordDocument(string filepath, string logopictureName, string tuvpicture, string htmlFileName)
        {
            using (WordprocessingDocument wordDocument =
               WordprocessingDocument.Create(filepath, WordprocessingDocumentType.Document))
            {
                // Add a main document part. 
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                // Create the document structure 
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

            }

            //Insert logo
            ImageToWord.InsertAPicture(filepath, logopictureName, 500, 120);

            // Open a document by supplying the filepath. 
            using (WordprocessingDocument wordDocument =
                WordprocessingDocument.Open(filepath, true))
            {
                //Create HTML Text
                string htmlText = "<html><p style = 'font-size:14px;font-family: 'Times New Roman', Times, serif;'><b><u>Ασπρόπυργος  ," + DateTime.Now.ToString("dd/MM/yyyy") + "</u></b></p><br><br>"

                    + "<p style = 'font-size:12px;font-family:'Times New Roman', Times, serif;'>Κύριοι,<br>"
                    + "Σε συνέχεια της τηλεφωνικής επικοινωνίας μας και του ενδιαφέροντος σας για την ανάθεση μεταφοράς εμπορευμάτων σας, σας παραθέτουμε τις προτάσεις μας και τους βασικούς όρους υπό τους οποίους θα εκτελείται κάθε μεταφορά. Eπίσης να σας ενημερώσουμε ότι πραγματοποιούμε καθημερινά δρομολόγια κοινού φόρτου και ψυγείου για τις παρακάτω πόλεις :<br>"
                    + "<ul><li>Θεσσαλονίκη,</li><li>Πάτρα,</li><li>Πύργο,</li><li>Καλαμάτα,</li><li>Σπάρτη,</li><li>Κόρινθο,</li><li>Άργος,</li><li>Χανιά,</li><li>Ηράκλειο,</li><li>Ρέθυμνο,</li><li>Ρόδο,</li><li>Κω,</li><li>Κάλυμνο,</li><li>Μυτιλήνη, </li><li>Χίο και</li><li>Κέρκυρα.</li><br>"
                    + "<span style='color:red'><b>ΤΩΡΑ ΛΕΙΤΟΥΡΓΕΙ ΚΑΙ ΥΠΟΚΑΤΑΣΤΗΜΑ ΣΤΟ ΡΕΝΤΗ ΦΛΩΡΙΝΗΣ 17-19 ,<br>ΤΗΛΕΦΩΝΟ ΚΑΙ ΦΑΞ 210-5596913 και ΚΙΝΗΤΟ 6948-300536.</b></span><br>Παραμένουμε στη διάθεση σας για οποιαδήποτε περαιτέρω πληροφορία ή διευκρίνιση.<br><br><b>Με εκτίμηση<br>Για την εταιρία ΑΦΟΙ ΚΑΣΣΟΥΔΑΚΗ Α.Ε.</b></br>"



                    + "</p></html>";



                //Add Html
                MemoryStream ms = new MemoryStream(Encoding.GetEncoding(1253).GetBytes(htmlText));

                //Create an alternative format import part on the MainDocumentPart
                AlternativeFormatImportPart altformatImportPart = wordDocument.MainDocumentPart.AddAlternativeFormatImportPart(AlternativeFormatImportPartType.Html);

                //Add the HTML data into the alternative format import part
                altformatImportPart.FeedData(ms);

                //create a new altChunk and link it to the id of the AlternativeFormatImportPart
                AltChunk altChunk = new AltChunk();
                altChunk.Id = wordDocument.MainDocumentPart.GetIdOfPart(altformatImportPart);

                // add the altChunk to the document
                wordDocument.MainDocumentPart.Document.Body.Append(altChunk);

                wordDocument.Save();

                //Add text
                //Body body = wordDocument.MainDocumentPart.Document.Body;
                //Paragraph para = body.AppendChild(new Paragraph());
                //Run run = para.AppendChild(new Run());

                // run.AppendChild(new Text(DateTime.Now.ToString("dd/MM/yyyy")));
                //run.AppendChild(new Text("______________________________________________"));
                //run.AppendChild(new Break());
                //run.AppendChild(new Break());
                //run.AppendChild(new Text("Κύριοι,"));
                //run.AppendChild(new Break());
                //run.AppendChild(new Text("Σε συνέχεια της τηλεφωνικής επικοινωνίας μας και του ενδιαφέροντος σας για την ανάθεση μεταφοράς εμπορευμάτων σας, σας παραθέτουμε τις προτάσεις μας και τους βασικούς όρους υπό  τους οποίους θα εκτελείται κάθε μεταφορά.Eπίσης να σας ενημερώσουμε ότι πραγματοποιούμε καθημερινά δρομολόγια κοινού φόρτου και ψυγείου για τις παρακάτω πόλεις:"));
                //run.AppendChild(new Break());
                //run.AppendChild(new Text("Θεσσαλονίκη, Πάτρα , Πύργο , Καλαμάτα ,  Σπάρτη ,  Κόρινθο , Άργος ,  Χανιά , Ηράκλειο , Ρέθυμνο ,  Ρόδο ,  Κω ,  Κάλυμνο ,  Μυτιλήνη ,  Χίο και Κέρκυρα."));
                //run.AppendChild(new Break());
                //run.AppendChild(new Text("ΤΩΡΑ ΛΕΙΤΟΥΡΓΕΙ ΚΑΙ ΥΠΟΚΑΤΑΣΤΗΜΑ ΣΤΟ ΡΕΝΤΗ ΦΛΩΡΙΝΗΣ 17 - 19 ΤΗΛ ΚΑΙ ΦΑΞ 210 - 5596 - 913 ΚΙΝ 6948 - 300 - 536.Παραμένουμε στη διάθεση σας για οποιαδήποτε περαιτέρω πληροφορία ή διευκρίνιση."));



            }



            //Insert TUV picture
            ImageToWord.InsertAPicture(filepath, tuvpicture, 636, 816);


        }




    }
}
