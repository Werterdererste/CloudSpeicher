using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Forms;
using CloudSpeicher.Scripts;
using MySql.Data.MySqlClient;

namespace CloudSpeicher
{
    public class DatenbankAnbindung
    {
        private string conection ="datasource=127.0.0.1;port=3306;username=root;password=;database=cloudspeicher;";
        MySqlConnection databaseConaction;

        public DatenbankAnbindung()
        {
            databaseConaction = new MySqlConnection(conection);
        }

        public int Anmelden(string benutzername, string passwort)
        {
            int id = 0;
            /////////////passwort Hashen
            //////////// salt abfragen
            ///////////Bestimmte zeichen unterbinnden
            string query = "SELECT IDBenutzer FROM benutzer WHERE benutzername = '" + benutzername + "'  " +
               "AND passwort = '" + passwort + "' ;";


            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConaction);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConaction.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);                          
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write("error: " + e.Message);
            }
            databaseConaction.Close();
            return id;
        }

        public void Acountersellen(string benutzer, string passwort, string Vorname, string Nachname)
        {
            /////////////passwort erneut Hashen + Salt

            string query = "INSERT INTO benutzer Values " +
                "(NULL,'" + benutzer + "','" + passwort + "','" + Vorname + "','" +Nachname +"');";

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConaction);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConaction.Open();

                commandDatabase.ExecuteNonQuery();
                databaseConaction.Close();  
              
            }
            catch (Exception e)
            {
                Console.Write("error: " + e.Message);
            }
        }

        public string[] AcoutInformationen(string benutzername)
        {
            string query = "SELECT Vorname, Nachname, Benutzername FROM benutzer " +
                           "WHERE benutzername = '" + benutzername + "';";

            string[] user = null;
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConaction);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConaction.Open();

                MySqlDataReader reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user = new string[] { reader.GetString(0), reader.GetString(1) } ;
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write("error: " + e.Message);
            }
            databaseConaction.Close();
            return user;
        }

        public bool UsernameFree(string benutzername)
        {
            bool free = true;

            string query = "SELECT passwort, benutzername FROM benutzer WHERE benutzername = '" + benutzername + "';";


            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConaction);
            commandDatabase.CommandTimeout = 60;

            try
            {

                databaseConaction.Open();

                MySqlDataReader reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("belegt");
                        free = false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write("error: " + e.Message);
            }
            databaseConaction.Close();
            return free;
        }

        public void UplodeFile(int user, Stream filestream)
        {
            var filebyte = StreamToByte.streamtoByte(filestream);

            string query = "INSERT INTO datein Values " +
                "(NULL,'" + user + " ', @File);";

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConaction);

            MySqlParameter parameter = new MySqlParameter("@File", MySqlDbType.LongBlob, filebyte.Length);
            parameter.Value = filebyte;
            commandDatabase.Parameters.Add(parameter); 
            
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConaction.Open();

                commandDatabase.ExecuteNonQuery();
                databaseConaction.Close();
            }
            catch (Exception e)
            {
                Console.Write("error: " + e.Message);
            }
        }
        public List<Stream> DownlodeFile(int user)
        {
            List<Stream> filestream = new List<Stream>();
            string query = "Select Datei FROM datein WHERE " +
                "IDBenutzer = '"+ user+"';";

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConaction);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConaction.Open();

                MySqlDataReader reader = commandDatabase.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        filestream.Add(reader.GetStream(0));
                    }
                }

                databaseConaction.Close();

            }
            catch (Exception e)
            {
                Console.Write("error: " + e.Message);
            }
            return filestream;
        }
    }
}