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

           

            string destinationFolderPath = @"D:\Documents\Сотрудники\"+fullName;
            string templatePath = @"D:\Documents Templates\Cогласие на обработку персональных данных.docx";
            string newFilePath = @"D:\Documents\Сотрудники\" + fullName+"\\Cогласие на обработку персональных данных.docx";

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

        static public void createLaborContract(
            string empFullName,
            string newFullName,
            string department,
            string position,
            string type, 
            string type2,
            DateTime start,
            DateTime finish,
            string duty,
            string mode, 
            string days,
            string series, 
            string number,
            string body,
            string register,
            DateTime passDate
            )
        {
            string formattedStart = start.Date.ToString("dd.MM.yyyy");
            string formattedFinish = finish.Date.ToString("dd.MM.yyyy");
            string formattedPassDate = passDate.Date.ToString("dd.MM.yyyy");

            var valuesToFill1 = new TemplateEngine.Docx.Content(
                new FieldContent("EMP_FIO", empFullName),
                new FieldContent("NEW_FIO", newFullName),
                new FieldContent("NEW_FIO2", newFullName),
                new FieldContent("NEW_DEP", department),
                new FieldContent("NEW_POSITION", position),
                new FieldContent("TYPE", type),
                new FieldContent("TYPE2", type2),
                new FieldContent("START", formattedStart),
                new FieldContent("FINISH", formattedFinish),
                new FieldContent("DUTY", duty),
                new FieldContent("MODE", mode),
                new FieldContent("DAYS", days),
                new FieldContent("EMP2", empFullName),
                new FieldContent("NEW2", newFullName),
                new FieldContent("SERIES", series),
                new FieldContent("NUM", number),
                new FieldContent("BODY", body),
                new FieldContent("REG", register)
             );



            string destinationFolderPath = @"D:\Documents\Сотрудники\" + newFullName;
            string templatePath = @"D:\Documents Templates\Трудовой договор.docx";
            string newFilePath = @"D:\Documents\Сотрудники\" + newFullName + "\\Трудовой договор.docx";

            if (!Directory.Exists(destinationFolderPath))
            {
                Directory.CreateDirectory(destinationFolderPath);
            }

            if (File.Exists(newFilePath))
            {
                File.Delete(newFilePath);
            }
           
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
