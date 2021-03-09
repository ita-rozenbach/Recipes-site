using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication3.Models;


namespace WebApplication3.Controllers
{
  [EnableCors(origins: "*", headers: "*", methods: "*")]
  [RoutePrefix("api/Category")]
  public class CategoryController : ApiController
  {
    [Route("getRecipeByCode")]
    [HttpGet]

    public Category getRecipeByCode(int code)
    {
      foreach (var item in DB.categoryList)
      {
        if (item.code == code)
          return item;
      }
      return null;
      
    }
    [Route("getAllCategories")]
    [HttpGet]
    public List<Category> getAllCategories()
    {
      return DB.categoryList;
    }

        [Route("myTry")]
        [HttpGet]
        public bool myTry(string sub, string body)
        {


            //יצירת אוביקט MailMessage
            MailMessage mail = new MailMessage();

            //למי לשלוח (יש אפשרות להוסיף כמה נמענים) 
            mail.To.Add("8667572@gmail.com");

            //כתובת מייל לשלוח ממנה
            mail.From = new MailAddress("contact.from.recipe.project@gmail.com");

            // נושא ההודעה
            mail.Subject = sub;

            //תוכן ההודעה ב- HTML
            mail.Body = body;

            //הגדרת תוכן ההודעה ל - HTML 
            mail.IsBodyHtml = true;

            // Smtp יצירת אוביקט 
            SmtpClient smtp = new SmtpClient();

            //הגדרת השרת של גוגל
            smtp.Host = "smtp.gmail.com";


            //הגדרת פרטי הכניסה לחשבון גימייל
            smtp.Credentials = new NetworkCredential(
                "contact.from.recipe.project@gmail.com", "recipe123456");
            //אפשור SSL (חובה(
            smtp.EnableSsl = true;
            try
            {
                //שליחת ההודעה
                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                //תפיסה וטיפול בשגיאות 

                return false;

            }

        }

    }
}
