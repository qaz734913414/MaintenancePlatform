﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ZNC.DataEntiry;

namespace ZNC.DataAccess.DA.Equipment
{
    /// <summary>
    /// AndrewChien 2017/10/22 9:37:11
    /// AutomaticCoder代码生成器生成
    /// </summary>
    public class ErrorDictionaryDAL
    {
        public ErrorDictionaryDAL()
        {

        }

        public ObservableCollection<ErrorDictionary> Select(string _sqlwhere)
        {
            return CommonAccess.ComSQLiteSelect<ErrorDictionary>(_sqlwhere);
        }

        public int Insert(ErrorDictionary model)
        {
            return CommonAccess.ComSQLiteInsert(model);
        }

        public int Update(ErrorDictionary model, string _identity)
        {
            return CommonAccess.ComSQLiteUpdate(model, _identity);
        }

        public int Delete(ErrorDictionary model)
        {
            return CommonAccess.ComSQLiteDelete(model, "ID");
        }
    }
}
