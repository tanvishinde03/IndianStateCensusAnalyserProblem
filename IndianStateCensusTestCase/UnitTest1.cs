using IndianStateCensusAnalyserProblem;
using static IndianStateCensusAnalyserProblemE.IndianStateCensusAnalyser;

namespace IndianStateCensusTestCase
{
    public class Tests
    {
        public static string path = @"F:\RFP-256\IndianStateCensusAnalyserProblem\IndianStateCensusAnalyserProblem\IndianState\StateCensusData.csv";
        public static string incorrectStatePath = @"F:\RFP-256\IndianStateCensusAnalyserProblem\IndianStateCensusAnalyserProblem\IndianState\StateCensusData.csv";
        StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
        CsvStateCensus csvState = new CsvStateCensus();
        [Test]
        public void GivenStateCensusData_ShouldMatchNumbersOfRetrunMatches()
        {
            Assert.AreEqual(stateCensusAnalyser.ReadStateCensusData(path), csvState.ReadStateCensusData(path));
        }
        [Test]
        public void GivenIncorrectCSVFilePath_ShouldReturnCustomException()
        {
            try
            {
                int record = stateCensusAnalyser.ReadStateCensusData(incorrectStatePath);
            }
            catch (IndianStateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect file path");
            }
        }
    }
}
    
    
