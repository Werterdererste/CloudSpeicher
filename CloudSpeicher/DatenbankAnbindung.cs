﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public bool Anmelden(string benutzername, string passwort)
        {
            bool angemeldet = false; 

            string query = "SELECT passwort FROM benutzer WHERE '"+ benutzername+"' = benutzername;";
            

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
                        if (reader.GetString(0) == passwort)
                        {
                            Console.WriteLine("richtig");
                            angemeldet = true;
                        }            
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write("error: " + e.Message);
            }
            databaseConaction.Close();
            return angemeldet;
        }


        public void Acountersellen(string benutzer, string passwort, string Vorname, string Nachname)
        {

            string query = "INSERT INTO benutzer Values " +
                "(NULL,'" + benutzer + "','" + passwort + "','" + Vorname + "','" +Nachname +"');";

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConaction);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConaction.Open();

                MySqlDataReader reader = commandDatabase.ExecuteReader();
                databaseConaction.Close();  
              
            }
            catch (Exception e)
            {
                Console.Write("error: " + e.Message);
            }
        }
    }
}