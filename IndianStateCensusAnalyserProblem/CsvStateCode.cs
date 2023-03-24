using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserProblem
{
    public class CsvStateCode
    {
        public void ReadStateCodeData(String filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCodeModel>().ToList();
                    foreach (var record in records)
                    {
                        Console.WriteLine($"{record.SrNo} {record.StateName} {record.TIN} {record.StateCode}"); 
           
                    }
                }
            }
        }
    }
}
