using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace WebAppServer.Models
{
   
    public interface IUserRepository
    {
        //Users
        List<User> GetUsers();
        User GetUserId(int id);
        int GetUser(string login, string password);
        int CreateUsers(User user);   
                 
        
    }
    public class UserRepository : IUserRepository
    {
        string connectionString = null;

        //User
        public UserRepository(string conn)
        {
            connectionString = conn;
        }
        public List<User> GetUsers()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<User>("SELECT * FROM Users").ToList();
            }
        }

        public User GetUserId(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<User>("SELECT * FROM Users WHERE Id = @id", new { id }).FirstOrDefault();
            }
        }
        
        public int GetUser(string login, string password)
        {
             using (IDbConnection db = new SqlConnection(connectionString))
             {
                return db.Query<int>("SELECT id FROM Users WHERE UserName = @UserName and Password = @Password", new { UserName = login, Password = password }).FirstOrDefault();

            }
        }

        public int CreateUsers(User user)
        {

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                if (db.Query<User>("SELECT * FROM Users WHERE UserName = @UserName", new { UserName = user.UserName }).FirstOrDefault() == null)
                {
                    var sqlQuery = "INSERT INTO Users (UserName, Password) VALUES(@UserName, @Password)";
                    db.Execute(sqlQuery, user);
                }
                return db.Query<int>("SELECT id FROM Users WHERE UserName = @UserName and Password = @Password", new { UserName = user.UserName, Password = user.Password}).FirstOrDefault();

            }
        }       

        
    }
}
