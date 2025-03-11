using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.Xml.Linq;
using OfficeOpenXml;
using System.Configuration;
using ConfigBuilder = Microsoft.Extensions.Configuration.ConfigurationBuilder;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;


/*
    NOTES

    2 seperate fields for name and surname, and initials	
    gender - drop down box
    phone(international), age - indicate format
    job title - drop down; list of job titles + other
    error message - include format + specify format
    specify required fields
    when fields are not selected, highlight red ones that aren't filled in and put cursor there
    select -> select an option
    for both -> indicate to the user which test is being taken 
    give score of first test, then take the next test
    thank you -> not red
    background not red
    build into exe

    convert excel -> database
    database app to 

    NOTES AFTER ver 3

    - add org info for personal info
    add for stats in excel

    introper
    font bigger

    turn greeen down
    syncronize colours accross all forms


    frmlogin to identify user taking test
    create db interface
    create report for all companies and related info

    bring raw data from excel into dashboard
    excel acts as db

    find specific person or group of people
    group within company(department) either both, per or org

    how many companies, person or partners have done a test

    administrator can take test - hr in org
    normal users can't see db    


after ver 4

after creating new user, force the user to login

 */

namespace TitanicSyndrome
{
    internal static class Program
    {
        public static Person person = new Person("", "",  "", "", 0, "", "", "", "Personal Test", "");
        public static Person organization = new Person("", "", "", "", 0, "", "", "", "Organization test", "");
        public static int percount = 0;
        public static bool percomplete = false;
        public static bool orgcomplete = false;
        public static int orgcount = 0;
        public static bool per = false;
        public static bool org = false;
        public static string fileorg = "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver4\\TitanicSyndrome\\TitanicSyndrome\\org_users.xlsx";
        public static string fileper = "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver4\\TitanicSyndrome\\TitanicSyndrome\\per_users.xlsx";
        public static string filepath = "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver4\\TitanicSyndrome\\TitanicSyndrome\\users.xlsx";
        public static bool isAdmin = false;
        public static bool exists = false;

        public static void createExcelFile()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(filepath)))
            {
                var worksheet = package.Workbook.Worksheets.FirstOrDefault(ws => ws.Name == "Users")
                                ?? package.Workbook.Worksheets.Add("Users");

                bool isNewFile = worksheet.Dimension == null;

                // Create headers if the file is new
                if (isNewFile)
                {
                    worksheet.Cells[1, 1].Value = "ID";
                    worksheet.Cells[1, 2].Value = "Name";
                    worksheet.Cells[1, 3].Value = "Surname";
                    worksheet.Cells[1, 4].Value = "Password";
                    worksheet.Cells[1, 5].Value = "Age";
                    worksheet.Cells[1, 6].Value = "Email";
                    worksheet.Cells[1, 7].Value = "Gender";
                    worksheet.Cells[1, 8].Value = "Cell_Number";
                    worksheet.Cells[1, 9].Value = "Job_Title";
                    worksheet.Cells[1, 10].Value = "Company";
                    worksheet.Cells[1, 11].Value = "aChange_Score";
                    worksheet.Cells[1, 12].Value = "dChange_Score";
                    worksheet.Cells[1, 13].Value = "iChange_Score";
                    worksheet.Cells[1, 14].Value = "Total_Score";
                    worksheet.Cells[1, 15].Value = "Test_Type";
                    worksheet.Cells[1, 16].Value = "Is_Admin";
                    worksheet.Cells[1, 17].Value = "Took_both_tests";
                }

                int nextRow = worksheet.Dimension?.End.Row + 1 ?? 2;
                //int lastID = worksheet.Dimension == null ? 0 : worksheet.Dimension.End.Row;

                //adding entry for per user scores
                if (per)
                {
                    worksheet.Cells[nextRow, 1].Value = nextRow  - 1;
                    worksheet.Cells[nextRow, 2].Value = person.name;
                    worksheet.Cells[nextRow, 3].Value = person.surname;
                    worksheet.Cells[nextRow, 4].Value = person.password;
                    worksheet.Cells[nextRow, 5].Value = person.age;
                    worksheet.Cells[nextRow, 6].Value = person.email;
                    worksheet.Cells[nextRow, 7].Value = person.gender;
                    worksheet.Cells[nextRow, 8].Value = person.phone;
                    worksheet.Cells[nextRow, 9].Value = person.job;
                    worksheet.Cells[nextRow, 10].Value = person.company;
                    worksheet.Cells[nextRow, 11].Value = person.aChange.Sum();
                    worksheet.Cells[nextRow, 12].Value = person.dChange.Sum();
                    worksheet.Cells[nextRow, 13].Value = person.iChange.Sum();
                    worksheet.Cells[nextRow, 14].Value = person.totalScore();
                    worksheet.Cells[nextRow, 15].Value = per ? "Personal" : "Organization";
                    worksheet.Cells[nextRow, 16].Value = isAdmin ? "Yes" : "No";
                    worksheet.Cells[nextRow, 17].Value = per && org ? "Yes" : "No";
                }               
                nextRow++;
                //adding entry for org user scores
                if (org)
                {
                    worksheet.Cells[nextRow, 1].Value = nextRow - 1;
                    worksheet.Cells[nextRow, 2].Value = organization.name;
                    worksheet.Cells[nextRow, 3].Value = organization.surname;
                    worksheet.Cells[nextRow, 4].Value = organization.password;
                    worksheet.Cells[nextRow, 5].Value = organization.age;
                    worksheet.Cells[nextRow, 6].Value = organization.email;
                    worksheet.Cells[nextRow, 7].Value = organization.gender;
                    worksheet.Cells[nextRow, 8].Value = organization.phone;
                    worksheet.Cells[nextRow, 9].Value = organization.job;
                    worksheet.Cells[nextRow, 10].Value = organization.company;
                    worksheet.Cells[nextRow, 11].Value = organization.aChange.Sum();
                    worksheet.Cells[nextRow, 12].Value = organization.dChange.Sum();
                    worksheet.Cells[nextRow, 13].Value = organization.iChange.Sum();
                    worksheet.Cells[nextRow, 14].Value = organization.totalScore();
                    worksheet.Cells[nextRow, 15].Value = org ? "Organization" : "Personal";
                    worksheet.Cells[nextRow, 16].Value = isAdmin ? "Yes" : "No";
                    worksheet.Cells[nextRow, 17].Value = per && org ? "Yes" : "No";
                }
                package.Save();
            }
        }

        public static void sendEmail()
        {
            /*
            using (var smtpClient = new SmtpClient("smtp.your-email-provider.com"))
            {
                string from = "bludennis17@gmail.com";
                string password = "bxca mrmr dzpc ehlp";
                string attachmentPath = "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\TitanicSyndrome\\TitanicSyndrome\\Users.xlsx";

                MailMessage msg = new MailMessage();

                msg.Subject = "Titanic Syndrome Test";
                msg.To.Add(from);
                msg.From = new MailAddress(from);
                msg.Body = "Please find the users' information below";
                msg.Attachments.Add(new Attachment(attachmentPath));

                SmtpClient smpt = new SmtpClient();

                smpt.Host = "smtp.gmail.com";
                smpt.Port = 587;
                smpt.UseDefaultCredentials = false;

                smpt.EnableSsl = true;
                NetworkCredential nc = new NetworkCredential(from, password);
                smpt.Credentials = nc;
                smpt.Send(msg);
            }  
            */

        }         
    
        static void Main()
        {
            var builder = new ConfigBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            // Access the EPPlus LicenseContext setting
            string licenseContext = configuration["EPPlus:ExcelPackage:LicenseContext"];
            Console.WriteLine($"EPPlus License Context: {licenseContext}");

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new frmLogin());

        }
    }
}

