
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;

namespace HelloMVCapllication.Models
{
    public interface IUserRepository
    {
        void Create(User user);
        void Delete(int id);
        User Get(int id);
        List<User> GetUsers();
        void Update(User user);
        User Logging(User user);
    }
    public class UserRepository : IUserRepository
    {
        string connectionString = null;
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

        public User Get(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<User>("SELECT * FROM Users WHERE Id = @id", new { id }).FirstOrDefault();
            }
        }

        public void Create(User user)
        {
            
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                if(db.Query<User>("SELECT * FROM Users WHERE UserName = @UserName", new { UserName=user.UserName }).FirstOrDefault() == null)
                {
                    var sqlQuery = "INSERT INTO Users (UserName, Password) VALUES(@UserName, @Password)";
                    db.Execute(sqlQuery, user);
                }
                                

            }
        }

        public User Logging(User user)
        {

            using (IDbConnection db = new SqlConnection(connectionString))
            {
               return db.Query<User>("SELECT * FROM Users WHERE UserName = @UserName", new { UserName = user.UserName }).FirstOrDefault();
            }
        }

        public void Update(User user)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "UPDATE Users SET UserName = @UserName, Password = @Password WHERE Id = @Id";
                db.Execute(sqlQuery, user);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM Users WHERE Id = @id";
                db.Execute(sqlQuery, new { id });
            }
        }
    }
}
