using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using SOOSI.Entities;

namespace SOOSI
{
    public class DatabaseHandler
    {
        // https://stackoverflow.com/questions/8829102/mysql-check-if-table-exists-without-using-select-from
        public static void CreateTables()
        {
            using (MySqlConnection Connection = new MySqlConnection(SOOSI.Instance.Connection))
            {
                using (MySqlCommand Command = new MySqlCommand())
                {
                    bool Bans, Kicks, Reports, Warnings;
                    
                    Command.CommandText = "SHOW TABLES LIKE 'Bans'";
                    Bans = Command.ExecuteScalar() != null;

                    Command.CommandText = "SHOW TABLES LIKE 'Kicks'";
                    Kicks = Command.ExecuteScalar() != null;

                    Command.CommandText = "SHOW TABLES LIKE 'Reports'";
                    Reports = Command.ExecuteScalar() != null;

                    Command.CommandText = "SHOW TABLES LIKE 'Warnings'";
                    Warnings = Command.ExecuteScalar() != null;

                    if (!Bans)
                    {
                        Command.CommandText = "CREATE TABLE 'Bans' ()";
                    }
                }
            }
        }

        public static void Ban(Ban ban)
        {
            using (MySqlConnection Connection = new MySqlConnection(SOOSI.Instance.Connection))
            {
                using (MySqlCommand c = new MySqlCommand("INSERT INTO `Bans` VALUES (@victim, @judge, @reason, @issued, @length)"))
                {
                    c.Parameters.AddWithValue("victim", ban.VictimId);
                    c.Parameters.AddWithValue("judge", ban.IssuerId);
                    c.Parameters.AddWithValue("reason", ban.Reason);
                    c.Parameters.AddWithValue("issued", ban.TimeIssued);
                    c.Parameters.AddWithValue("length", ban.BanLength);

                    c.ExecuteNonQuery();
                }
            }
        }
    }
}
