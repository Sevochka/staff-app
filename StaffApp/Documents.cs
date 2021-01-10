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

        static public void CreatedataToLogin(
           string fullName, string personalNumb, string password
            )
        {
            
            var valuesToFill1 = new TemplateEngine.Docx.Content(
                new FieldContent("FIO", fullName),
                new FieldContent("tab", personalNumb),
                new FieldContent("pass", password)
             );

            string destinationFolderPath = @"D:\Documents\Сотрудники\" + fullName;
            string templatePath = @"D:\Documents Templates\Данные для входа.docx";
            string newFilePath = @"D:\Documents\Сотрудники\" + fullName + "\\Данные для входа.docx";

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


        static public void CreateLeave(
           string fullName, string position, string department, DateTime date_when, string reason, 
           DateTime currentDate
            )
        {

            string formattedWhen = date_when.Date.ToString("dd.MM.yyyy");
            string formattedCurrent = currentDate.Date.ToString("dd.MM.yyyy");

            var valuesToFill = new TemplateEngine.Docx.Content(
                new FieldContent("POS", position),
                new FieldContent("de", department),
                new FieldContent("FIO", fullName),
                new FieldContent("DATE_WHEN", formattedWhen),
                new FieldContent("re", reason),
                new FieldContent("CURR_DATE", formattedCurrent)
             );

            string destinationFolderPath = @"D:\Documents\Сотрудники\" + fullName;
            string templatePath = @"D:\Documents Templates\Заявление об увольнении.docx";
            string newFilePath = @"D:\Documents\Сотрудники\" + fullName + "\\Заявление об увольнении.docx";

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
                outputDocument.FillContent(valuesToFill);
                outputDocument.SaveChanges();
            }

            Process.Start(newFilePath);
        }

        static public void CreateLeaveOrder(
           DateTime creationDate, DateTime dateLaborContract, DateTime whenKick, 
           int personal_number, string fullName, string department, string position, string reason,
           string osn
            )
        {

            string formattedCreationDate = creationDate.Date.ToString("dd.MM.yyyy");
            //Labor
            string dLabor = dateLaborContract.Date.ToString("dd");
            string mLabor = dateLaborContract.Date.ToString("MMMM");
            string yLabor = dateLaborContract.Date.ToString("yy");

            //whenKick
            string dKick = dateLaborContract.Date.ToString("dd");
            string mKick = dateLaborContract.Date.ToString("MMMM");
            string yKick = dateLaborContract.Date.ToString("yy");

            var valuesToFill = new TemplateEngine.Docx.Content(
                new FieldContent("crdate", formattedCreationDate),
                new FieldContent("day1", dLabor),
                new FieldContent("m1", mLabor),
                new FieldContent("year1", yLabor),
                new FieldContent("day2", dKick),
                new FieldContent("m2", mKick),
                new FieldContent("year2", yKick),
                new FieldContent("tab", personal_number.ToString()),
                new FieldContent("FIO_S", fullName),
                new FieldContent("de", department),
                new FieldContent("po", position),
                new FieldContent("res", reason),
                new FieldContent("osn", osn)
             );

            string destinationFolderPath = @"D:\Documents\Сотрудники\" + fullName;
            string templatePath = @"D:\Documents Templates\Приказ об увольнении.docx";
            string newFilePath = @"D:\Documents\Сотрудники\" + fullName + "\\Приказ об увольнении.docx";

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
                outputDocument.FillContent(valuesToFill);
                outputDocument.SaveChanges();
            }

            Process.Start(newFilePath);
        }

    }


}
