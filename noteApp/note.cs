using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
namespace NoteAppConsole
{
    public class note
    {
        public static int numberOfNotes;
        public note(int id0, string text0, string title0, string tag0, DateTime dateCreated0)
        {
            id = id0;
            text = text0;
            title = title0;
            tag = tag0;
            dateCreated = dateCreated0;
        }


        private int id { get; }
        private string text { get; set; }
        private string title { get; set; }
        private string tag { get; set; }
        private DateTime dateCreated { get; }

        public static string[] getTitles()
        {

            List<string> data = new List<string>();
            string connectionString = "uri=file:database.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandString = "select title from notes";

                using (SQLiteCommand command = new SQLiteCommand(commandString, connection))
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    int length = 0;
                    while (reader.Read())
                    {
                        data.Add($"{reader["title"]}");
                    }
                }
                connection.Close();
            }
            numberOfNotes=data.Count;
            return data.ToArray();
        }
        public static void createTable()
        {
            string connectionString = "uri=file:database.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandString = "create table notes(id integer primary key AUTOINCREMENT,title string ,text0 TEXT,tag varchar,date0 DATETIME )";

                using (SQLiteCommand command = new SQLiteCommand(commandString, connection))
                {
                    command.ExecuteNonQuery();

                    
                }
                connection.Close();
            }
        }
        public static bool addnote(note noteObject)
        {
            string[] titles = note.getTitles();
            foreach (string item in titles)
            {
                if (noteObject.title==item)
                {
                    return false;
                }
            }
            string connectionString = "uri=file:database.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandString = $"INSERT INTO NOTES (TITLE,TEXT0,TAG,DATE0) VALUES ('{noteObject.title}','{noteObject.text}','{noteObject.tag}','{DateTime.Now}')";

                using (SQLiteCommand command = new SQLiteCommand(commandString, connection))
                {
                    command.ExecuteNonQuery();


                }
                connection.Close();
            }
            return true;
        }
    }
}
