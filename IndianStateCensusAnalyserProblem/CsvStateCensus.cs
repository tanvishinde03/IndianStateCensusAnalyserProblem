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
    public class CsvStateCensus
    {
        public int ReadStateCensusData(String filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCensusModel>().ToList();
                    foreach (var record in records)
                    {
                        Console.WriteLine($"{record.State} {record.Population} {record.AreaInSqKm} {record.DensityPerSqKm}");
                    }
                    return records.Count() - 1;
                }
            }
        }
    }
}
