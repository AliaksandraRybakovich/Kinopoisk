using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KinopoiskTests.Entities
{
    public class GetDataFromCsv
    {        
        public static IEnumerable<ExtentedSearchInfo> ReadCsvForExtendedSearch()
        {
            string path = $"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\Resources\\TestDataForExtendedSearch.csv";
            using (CsvReader csv = new CsvReader(new StreamReader(path, Encoding.Default), true))
            {
                while (csv.ReadNextRecord())
                {
                    yield return new ExtentedSearchInfo(csv[0], csv[1]);
                }
            }
        }        
    }
}
