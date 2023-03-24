using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string censusfilePath = "F:\\RFP-256\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\IndianState\\StateCensusData.csv";
            string filePath = "F:\\RFP-256\\IndianStateCensusAnalyserProblem\\IndianStateCensusAnalyserProblem\\IndianState\\StateCode.csv";
            CsvStateCensus csv = new CsvStateCensus();
            CsvStateCode statecode = new CsvStateCode();
            csv.ReadStateCensusData(censusfilePath);
            statecode.ReadStateCodeData(filePath);
            Console.ReadLine();
        }
    }
}
