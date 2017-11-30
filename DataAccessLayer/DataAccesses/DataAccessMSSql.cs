﻿using System;
using System.Data;
using DataAccess.Enums;
using DataAccess.Interfaces;

namespace DataAccess.DataAccesses
{
    internal class DataAccessMSSql : BaseDataAccess, IDataAccess
    {
        internal DataAccessMSSql(string connectionString)
            : base(DataBaseType.SQLite, connectionString)
        {

        }

        public bool CreateDatabase()
        {
            throw new NotImplementedException();
        }

        public void CreateTable(string tableName, object[,] columnsParameter)
        {
            throw new NotImplementedException();
        }

        public IDataReader GetDBTablesStructure()
        {
            throw new NotImplementedException();
        }

        public bool IsDatabaseExist()
        {
            throw new NotImplementedException();
        }
    }
}
