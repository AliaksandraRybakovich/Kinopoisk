using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KinopoiskTests.Entities
{
    public class CsvDataReader
    {        
        public static IEnumerable<ExtentedSearchInfo> ReadCsvForExtendedSearch()
        {
            string path = ;
            using (CsvReader csv = new CsvReader(new StreamReader(path, Encoding.Default), true))
            {
                while (csv.ReadNextRecord())
                {
                    yield return new ExtentedSearchInfo(csv[0], csv[1]);
                }
            }
        }

        public static IEnumerable<UserInfo> ReadCsvForLogInUser()
        {
            string path = $"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\Resources\\TestDataForUser.csv";
            using (CsvReader csv = new CsvReader(new StreamReader(path, Encoding.Default), true))
            {
                while (csv.ReadNextRecord())
                {
                    yield return new UserInfo(csv[0], csv[1]);
                }
            }
        }
        
    }
}
