using System;
using System.Collections.Generic;
using System.Web.Http;
using WebApplication3.Models;
using System.Linq;
using System.Web.Http.Cors;

using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;‏

//using System.Data.SqlClient;‏

/**using System.Data.SqlClient;‏**/




namespace WebApplication3.Controllers
{
  [EnableCors(origins: "*", headers: "*", methods: "*")]
  [RoutePrefix("api/User")]
  public class UserController : ApiController
  {

    public static List<User> arrAllUsers = new List<User>();
    /**
[Route("select")]
[HttpGet]

public static List<User> select()
{
arrAllUsers = new List<User>();

SqlConnection sqlcon = new SqlConnection();

sqlcon.ConnectionString = "Data Source = (localdb)\\ProjectsV13; Initial Catalog = projectDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
SqlCommand command = new SqlCommand();
command.CommandText = "select * from UserTbl";
command.Connection = sqlcon;


try
{
   sqlcon.Open();
   SqlDataReader reader = command.ExecuteReader();
   while (reader.Read())
   {
       //Console.WriteLine("id: " + reader.GetInt32(0) + " name: " + reader.GetString(1)
       //    + " " + reader.GetString(2));
       arrAllUsers.Add(new User()
       {
           code = reader.GetInt32(0),
           name = reader.GetString(1),
           address = reader.GetString(2),
           mail = reader.GetString(3),
           password = reader.GetString(4)
       }
       );
   }


}
catch

{
   Console.WriteLine("שגיאה בפתיחת מסד הנתונים");
}

finally
{
   sqlcon.Close();
}

return arrAllUsers;
}‏

**/

    [Route("ifExist")]
    [HttpGet]
    public bool ifExist(string name)
    {
      foreach (User item in DB.userList)
      {
        if (item.name == name)
          return true;
      }
      return false;
    }
    [Route("ifExist")]
    [HttpGet]
    public User ifExist(string name, string password)
    {
      foreach (var item in DB.userList)
      {
        if (item.name == name && item.password == password)
          return item;
      }
      return null;
    }
    //פונקציה בSQL להוספה + רידר
    [Route("AddUser")]
    [HttpPost]
    public bool AddUser(User u)
    {
      DB.userList.Add(new User() { code = 0, name = u.name, address = u.address, mail = u.mail, password = u.password });

      return true;
    }

    [Route("getAllUsers")]
    [HttpGet]
    public List<User> getAllUsers()
    {
      return DB.userList;
    }
  }
}
