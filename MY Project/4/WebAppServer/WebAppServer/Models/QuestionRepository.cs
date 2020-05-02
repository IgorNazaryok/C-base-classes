using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace WebAppServer.Models
{
   
    public interface IQuestionRepository
    {      
       
        //Questions
        List<Question> GetQuestions();
        Question GetQuestionId(int id);
        Question CreateQuestion(Question question);
        void DeleteQuestion(int id);      
        
    }
    public class QuestionRepository : IQuestionRepository
    {
        string connectionString = null;

        public QuestionRepository(string conn)
        {
            connectionString = conn;
        }

        //Question
        public List<Question> GetQuestions()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Question>("SELECT * FROM Questions").ToList();
            }
        }
        public Question GetQuestionId(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Question>("SELECT * FROM Questions WHERE Id = @id", new { id }).FirstOrDefault();
            }
        }
        public Question CreateQuestion(Question question)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {               
                    var sqlQuery = "INSERT INTO Questions (QuestionText) VALUES(@QuestionText)";
                    db.Execute(sqlQuery, question);
                return db.Query<Question>("SELECT * FROM Questions WHERE QuestionText = @QuestionText", new { question.QuestionText }).FirstOrDefault();
            }
        }      
        public void DeleteQuestion(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM Questions WHERE Id = @id";
                db.Execute(sqlQuery, new { id });
            }
        }
    }
}
