﻿// MvxWpfSqLiteConnectionFactory.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System.IO;
using Community.SQLite;
using System;

namespace Cirrious.MvvmCross.Community.Plugins.Sqlite.Mac
{
    public class MvxMacSqLiteConnectionFactory
        : MvxBaseSQLiteConnectionFactory, ISQLiteConnectionFactory
    {
        protected override string GetDefaultBasePath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        }

        protected override string LocalPathCombine(string path1, string path2)
        {
            return Path.Combine(path1, path2);
        }

        protected override ISQLiteConnection CreateSQLiteConnection(string databasePath, bool storeDateTimeAsTicks)
        {
            return new SQLiteConnection(databasePath, storeDateTimeAsTicks);
        }
    }
}
