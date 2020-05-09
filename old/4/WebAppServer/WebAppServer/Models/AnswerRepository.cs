using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace WebAppServer.Models
{
   
    public interface IAnswerRepository
    {      
       
        //Answers
        List<Answer> GetAnswers();
        List<Answer> GetAnswersIdQuestion(int id);
        void CreateAnswer(Answer Answer);
        void DeleteAnswer(int id);      
        
    }
    public class AnswerRepository : IAnswerRepository
    {
        string connectionString = null;

        public AnswerRepository(string conn)
        {
            connectionString = conn;
        }

        //Answer
        public List<Answer> GetAnswers()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Answer>("SELECT * FROM Answers").ToList();
            }
        }
        public List<Answer> GetAnswersIdQuestion(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Answer>("SELECT * FROM Answers WHERE QuestionId = @id", new { id }).ToList();
            }
        }        
        public void CreateAnswer(Answer answer)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {               
                    var sqlQuery = "INSERT INTO Answers (AnswerText, QuestionId) VALUES(@AnswerText, @QuestionId)";                    
                db.Execute(sqlQuery, answer);  
            }
        }      
        public void DeleteAnswer(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM Answers WHERE Id = @id";
                db.Execute(sqlQuery, new { id });
            }
        }
    }
}
