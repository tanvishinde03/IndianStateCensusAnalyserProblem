using IndianStateCensusAnalyserProblem;

namespace IndianStateCensusTestCase
{
    public class Tests
    {
        public static string path = @"F:\RFP-256\IndianStateCensusAnalyserProblem\IndianStateCensusAnalyserProblem\IndianState\StateCensusData.csv";
        StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
        CsvStateCensus csvState = new CsvStateCensus();
        [Test]
        public void GivenStateCensusData_ShouldMatchNumbersOfRetrunMatches()
        {
            Assert.AreEqual(stateCensusAnalyser.ReadStateCensusData(path), csvState.ReadStateCensusData(path));
        }
    }
    
    }
