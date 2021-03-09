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


            //����� ������ MailMessage
            MailMessage mail = new MailMessage();

            //��� ����� (�� ������ ������ ��� ������) 
            mail.To.Add("8667572@gmail.com");

            //����� ���� ����� ����
            mail.From = new MailAddress("contact.from.recipe.project@gmail.com");

            // ���� ������
            mail.Subject = sub;

            //���� ������ �- HTML
            mail.Body = body;

            //����� ���� ������ � - HTML 
            mail.IsBodyHtml = true;

            // Smtp ����� ������ 
            SmtpClient smtp = new SmtpClient();

            //����� ���� �� ����
            smtp.Host = "smtp.gmail.com";


            //����� ���� ������ ������ ������
            smtp.Credentials = new NetworkCredential(
                "contact.from.recipe.project@gmail.com", "recipe123456");
            //����� SSL (����(
            smtp.EnableSsl = true;
            try
            {
                //����� ������
                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                //����� ������ ������� 

                return false;

            }

        }

    }
}
