using KinopoiskTests.Browser;
using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KinopoiskTests.Entities
{
    public class CsvDataReader
    {
        //universal method for read csv(?use patterns)
        public static IEnumerable<ExtentedSearchInfo> ReadCsvForExtendedSearch()
        {
            string path = Configuration.ExtentedSearchInfoCsvPath;
            using (CsvReader csv = new CsvReader(new StreamReader(path, Encoding.Default), true))
            {
                while (csv.ReadNextRecord())
                {
                    yield return new ExtentedSearchInfo
                    {
                        NameOfFilm = csv[0],
                        YearFilm = csv[1]
                    };
                }
            }
        }

        public static IEnumerable<UserInfo> ReadCsvForLogInUser()
        {
            string path = Configuration.UserInfoCsvPath;
            using (CsvReader csv = new CsvReader(new StreamReader(path, Encoding.Default), true))
            {
                while (csv.ReadNextRecord())
                {
                    yield return new UserInfo
                    {
                        Login= csv[0],
                        Password=csv[1]
                    };
                }
            }
        }

    }
}
