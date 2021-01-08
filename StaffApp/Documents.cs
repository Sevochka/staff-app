using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateEngine.Docx;

namespace StaffApp
{
    class Documents
    {
        static public void createСonsentProcessingOfPersonalData(
            DateTime date,
            string fullName,
            string registerAddress,
            string passSeries,
            string passNumber, 
            DateTime passDate,
            string passExtradition
            )
        {
            string formattedDate = date.Date.ToString("dd MMMM yyyy");
            string formattedPassDate = passDate.Date.ToString("dd.MM.yyyy");

            var valuesToFill1 = new TemplateEngine.Docx.Content(
                new FieldContent("Date", date.ToString(formattedDate)),
                new FieldContent("Full Name", date.ToString(fullName)),
                new FieldContent("Passport Number", date.ToString(passNumber)),
                new FieldContent("Passport Date", date.ToString(formattedPassDate)),
                new FieldContent("Passport Extradition", date.ToString(passExtradition)),
                new FieldContent("Reg", date.ToString(registerAddress)),
                new FieldContent("Pass", date.ToString(passSeries))
             );

           

            string destinationFolderPath = @"D:\Documents\"+fullName;
            string templatePath = @"D:\Documents Templates\Cогласие на обработку персональных данных.docx";
            string newFilePath = @"D:\Documents\"+fullName+"\\Cогласие на обработку персональных данных.docx";

            if (!Directory.Exists(destinationFolderPath))
            {
                Directory.CreateDirectory(destinationFolderPath);
            }

            File.Delete(newFilePath);
            File.Copy(templatePath, newFilePath);

            using (var outputDocument = new TemplateProcessor(newFilePath)
                .SetRemoveContentControls(true))
            {
                outputDocument.FillContent(valuesToFill1);
                outputDocument.SaveChanges();
            }

            Process.Start(newFilePath);
        }
    }
}
