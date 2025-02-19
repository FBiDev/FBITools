﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using App.Core;
using DbConnection = App.Data.SQLite;

namespace FBITools.WiiU
{
    public static class BancoWiiU
    {
        public static ListSynced<SqlLog> Log
        {
            get { return Database.Log; }
        }

        private static DatabaseManager Database { get; set; }

        private static bool IsLoaded { get; set; }

        public static void Load()
        {
            IsLoaded = false;
            Database = new DatabaseManager { };
            Reload();
            IsLoaded = true;
        }

        public static void Reload()
        {
            Database.DatabaseName = string.Empty;
            Database.DatabaseType = DatabaseType.SQLite;
            Database.Connection = new DbConnection.SQLite().Connection();
            Database.ServerAddress = string.Empty;

            Database.Username = string.Empty;
            Database.Password = string.Empty;
            Database.DatabaseFile = Session.Options.WiiUDatabaseFile;
            Database.ConnectionString = string.Empty;
        }

        public static async Task<DataTable> ExecutarSelect(string sql, List<SqlParameter> parameters = null, string storedProcedure = default(string))
        {
            if (IsLoaded)
            {
                try
                {
                    return await Database.ExecuteSelect(sql, parameters, storedProcedure);
                }
                catch (Exception ex)
                {
                    ExceptionManager.Resolve(ex, Database.LastCall);
                }
            }

            return new DataTable();
        }

        public static async Task<string> ExecutarSelectString(string sql, List<SqlParameter> parameters = null)
        {
            if (IsLoaded)
            {
                try
                {
                    return await Database.ExecuteSelectString(sql, parameters);
                }
                catch (Exception ex)
                {
                    ExceptionManager.Resolve(ex, Database.LastCall);
                }
            }

            return string.Empty;
        }

        public static async Task<SqlResult> Executar(string sql, DatabaseAction action, List<SqlParameter> parameters)
        {
            if (IsLoaded)
            {
                try
                {
                    return await Database.Execute(sql, action, parameters);
                }
                catch (Exception ex)
                {
                    ExceptionManager.Resolve(ex, Database.LastCall);
                }
            }

            return new SqlResult();
        }

        public static async Task<DateTime> DataServidor()
        {
            if (IsLoaded)
            {
                try
                {
                    return await Database.DateTimeServer();
                }
                catch (Exception ex)
                {
                    ExceptionManager.Resolve(ex, Database.LastCall);
                }
            }

            return DateTime.MinValue;
        }
    }
}