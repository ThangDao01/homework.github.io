using System;
using System.Collections.Generic;
using System.Data.Common;
using DTMN.VLeague.entity;
using MySql.Data.MySqlClient;
using VLeague.helper;
using VLeague.service;

namespace VLeague.model
{
    public class VLeagueModel
    {
        public void CreateTeam(FootballTeam team)
        {
            MySqlConnection cnn = DbConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = cnn.CreateCommand(); // createStatement
            string name = "Thang";
            mySqlCommand.CommandText = $"insert into team (name) values ('{name}')";
            Console.WriteLine(mySqlCommand.CommandText);
            mySqlCommand.ExecuteNonQuery();
        }

        public void UpdateTeam(FootballTeam team)
        {
            MySqlConnection cnn = DbConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = cnn.CreateCommand(); // createStatement
            mySqlCommand.CommandText =
                $"UPDATE accounts SET Balance = (SELECT Balance FROM accounts WHERE AccountNumber = ',UpdatedAt ='{DateTime.Now.ToString()}' WHERE AccountNumber = ''";
            Console.WriteLine(mySqlCommand.CommandText);
            mySqlCommand.ExecuteNonQuery();
            DbConnectionHelper.CloseConnection();
        }

        public List<FootballTeam> ListTeam()
        {
            List<FootballTeam> listTeam = new List<FootballTeam>();
            MySqlConnection cnn = DbConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = cnn.CreateCommand();
            mySqlCommand.CommandText = $"select * from users";
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string name = reader.GetString("name");
                Console.WriteLine($"Id: {id}, name: {name}");
            }
            return listTeam;
        }

        public void CreateSchedule(Schedule schedule)
        {
        }
    }
}

// MySqlConnection cnn = DbConnectionHelper.GetConnection();
// MySqlCommand mySqlCommand = cnn.CreateCommand();// createStatement
// string name = "Thang";
// mySqlCommand.CommandText = $"insert into users (name) values ('{name}')";
// Console.WriteLine(mySqlCommand.CommandText);
// mySqlCommand.ExecuteNonQuery();
// // Connection -> Statement (Command) -> Execute -> Reader
// MySqlConnection cnn = DbConnectionHelper.GetConnection();
// MySqlCommand mySqlCommand = cnn.CreateCommand();
// mySqlCommand.CommandText = $"select * from users";
// MySqlDataReader reader = mySqlCommand.ExecuteReader();
// while (reader.Read())
// {
//     int id = reader.GetInt32("id");
//     string name = reader.GetString("name");
//     Console.WriteLine($"Id: {id}, name: {name}");
// }


// tạo db
// CREATE TABLE accounts (
//     id int NOT NULL AUTO_INCREMENT,
//     UserName varchar(255) NOT NULL,
//     PasswordHash varchar(255),
//     AccountNumber varchar(255),
//     Salt varchar(255),
//     Balance int,
//     CreaterAt varchar(255),
//     UpdatedAt varchar(255),
//     Status int
// );
// update
// MySqlConnection cnn = DbConnectionHelper.GetConnection();
// MySqlCommand mySqlCommand = cnn.CreateCommand(); // createStatement
// mySqlCommand.CommandText =
//     $"UPDATE accounts SET Balance = (SELECT Balance FROM accounts WHERE AccountNumber = '{accountNumber}')+{amount},UpdatedAt ='{DateTime.Now.ToString()}' WHERE AccountNumber = '{accountNumber}'";
// Console.WriteLine(mySqlCommand.CommandText);
// mySqlCommand.ExecuteNonQuery();
// DbConnectionHelper.CloseConnection();