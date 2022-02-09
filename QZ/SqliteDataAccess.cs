using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QZ
{
    class SqliteDataAccess
    {
        public static List<QuestionModel> LoadGeneralKnowledgeQuestions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<QuestionModel>("select * from GeneralKnowledge ORDER BY RANDOM() LIMIT 10", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<QuestionModel> LoadFilmQuestions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<QuestionModel>("select * from Film ORDER BY RANDOM() LIMIT 10", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<QuestionModel> LoadMusicQuestions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<QuestionModel>("select * from Music ORDER BY RANDOM() LIMIT 10", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<QuestionModel> LoadVideoGamesQuestions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<QuestionModel>("select * from VideoGames ORDER BY RANDOM() LIMIT 10", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<QuestionModel> LoadScienceComputersQuestions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<QuestionModel>("select * from ScienceComputers ORDER BY RANDOM() LIMIT 10", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<QuestionModel> LoadScienceMathematicsQuestions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<QuestionModel>("select * from ScienceMathematics ORDER BY RANDOM() LIMIT 10", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<QuestionModel> LoadSportsQuestions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<QuestionModel>("select * from SportsQuestions ORDER BY RANDOM() LIMIT 10", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<QuestionModel> LoadHistoryQuestions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<QuestionModel>("select * from History ORDER BY RANDOM() LIMIT 10", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<QuestionModel> LoadPoliticsQuestions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<QuestionModel>("select * from Politics ORDER BY RANDOM() LIMIT 10", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveGeneralKnowledgeQuestion(QuestionModel question)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into GeneralKnowledge (Question, RightAnswer, WrongAnswer1, WrongAnswer2, WrongAnswer3) values (@Question, @RightAnswer, @WrongAnswer1, @WrongAnswer2, @WrongAnswer3)", question);
            }
        }

        public static void SaveFilmQuestion(QuestionModel question)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Film (Question, RightAnswer, WrongAnswer1, WrongAnswer2, WrongAnswer3) values (@Question, @RightAnswer, @WrongAnswer1, @WrongAnswer2, @WrongAnswer3)", question);
            }
        }

        public static void SaveMusicQuestion(QuestionModel question)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Music (Question, RightAnswer, WrongAnswer1, WrongAnswer2, WrongAnswer3) values (@Question, @RightAnswer, @WrongAnswer1, @WrongAnswer2, @WrongAnswer3)", question);
            }
        }

        public static void SaveVideoGamesQuestion(QuestionModel question)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into VideoGames (Question, RightAnswer, WrongAnswer1, WrongAnswer2, WrongAnswer3) values (@Question, @RightAnswer, @WrongAnswer1, @WrongAnswer2, @WrongAnswer3)", question);
            }
        }

        public static void SaveScienceComputersQuestion(QuestionModel question)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into ScienceComputers (Question, RightAnswer, WrongAnswer1, WrongAnswer2, WrongAnswer3) values (@Question, @RightAnswer, @WrongAnswer1, @WrongAnswer2, @WrongAnswer3)", question);
            }
        }

        public static void SaveScienceMathematicsQuestion(QuestionModel question)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into ScienceMathematics (Question, RightAnswer, WrongAnswer1, WrongAnswer2, WrongAnswer3) values (@Question, @RightAnswer, @WrongAnswer1, @WrongAnswer2, @WrongAnswer3)", question);
            }
        }

        public static void SaveSportsQuestion(QuestionModel question)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into SportsQuestions (Question, RightAnswer, WrongAnswer1, WrongAnswer2, WrongAnswer3) values (@Question, @RightAnswer, @WrongAnswer1, @WrongAnswer2, @WrongAnswer3)", question);
            }
        }

        public static void SaveHistoryQuestion(QuestionModel question)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into History (Question, RightAnswer, WrongAnswer1, WrongAnswer2, WrongAnswer3) values (@Question, @RightAnswer, @WrongAnswer1, @WrongAnswer2, @WrongAnswer3)", question);
            }
        }

        public static void SavePoliticsQuestion(QuestionModel question)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Politics (Question, RightAnswer, WrongAnswer1, WrongAnswer2, WrongAnswer3) values (@Question, @RightAnswer, @WrongAnswer1, @WrongAnswer2, @WrongAnswer3)", question);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
