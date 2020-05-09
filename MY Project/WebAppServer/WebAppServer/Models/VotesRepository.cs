using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace WebAppServer.Models
{
    public interface IVotesRepository
    {  
        List<Voice> GetVotes();
        List<string> GetUserVotesAnswerId(int id);
        int GetNumberUserVotesAnswerId(int id);
        void CreateVoice(Voice voice);
    }
    public class VotesRepository : IVotesRepository
    {
        string connectionString = null;

        public VotesRepository(string conn)
        {
            connectionString = conn;
        }

       
        public List<Voice> GetVotes()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Voice>("SELECT * FROM Votes").ToList();
            }
        }
        public List<string> GetUserVotesAnswerId(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<string>("SELECT UserName FROM Votes WHERE AnswerId = @id", new { id }).ToList();
            }
        }
        public int GetNumberUserVotesAnswerId(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<int>("SELECT count(UserName) FROM Votes WHERE AnswerId = @id", new { id }).FirstOrDefault();

            }//count(UserName)

        }
        public void CreateVoice(Voice voice)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                if (db.Query<Voice>("SELECT * FROM Votes WHERE AnswerId = @AnswerId and UserName = @UserName", new { AnswerId = voice.AnswerId, UserName = voice.UserName }).FirstOrDefault() == null)
                {
                    var sqlQuery = "INSERT INTO Votes (AnswerId, UserName) VALUES(@AnswerId, @UserName)";
                    db.Execute(sqlQuery, voice);
                }
                                     
                  
            }
        }      
        
    }
}
