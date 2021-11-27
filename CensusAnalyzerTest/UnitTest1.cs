using CensusAnalyzerProblem;
using NUnit.Framework;

namespace CensusAnalyzerTest
{
    public class IndianStateCensusDataTest
    {
        string INDIAN_STATE_CENSUS_DATA_PATH = @"C:\Users\MY PC\Desktop\BridgeLabz\CensusAnalyzerProblem\CensusAnalyzerTest\Assest\IndiaStateCensusData";
         string INDIAN_STATE_CENSUS_DATA_INCORRECT = @"C:\Users\MY PC\Desktop\BridgeLabz\CensusAnalyzerProblem\CensusAnalyzerTest\Assest\IndiaCensusData.csv";
        string WRONG_INDIAN_STATE_CENSUS_DATA_FORMAT = @"C:\Users\MY PC\Desktop\BridgeLabz\CensusAnalyzerProblem\CensusAnalyzerTest\Assest\IndiaCensusData.txt";
        string WRONG_DELIMETER_INDIAN_STATE_CENSUS_DATA = @"C:\Users\MY PC\Desktop\BridgeLabz\CensusAnalyzerProblem\CensusAnalyzerTest\Assest\IndiaStateCensusDataWrongDelimeter.csv";
        string WRONG_HEADER_INDIAN_STATE_CENSUS_DATA = @"C:\Users\MY PC\Desktop\BridgeLabz\CensusAnalyzerProblem\CensusAnalyzerTest\Assest\IndiaStateCensusDataWrongHeader.csv";

        CensusAnalyzeData analyzeCensus;

        [SetUp]
        public void Setup()
        {
            analyzeCensus = new CensusAnalyzeData();
        }

        // 1.1 Given the States Census CSV file, Check to ensure the Number of Record matches
        [Test]
        public void LoadingIndianCensusData_WithValidPath_ShoudReturnCount()
        {
            int expectedCount = 29;
            var censusDataList = analyzeCensus.loadIndianStateCensusData(INDIAN_STATE_CENSUS_DATA_PATH);
            Assert.AreEqual(expectedCount, censusDataList.Count);
        }

        // 1.2 Given the States Census CSV file if incorrect return a custom exception
        [Test]
        public void LoadingIndianCensusData_WithIncorrectFile_ShoudReturnCustomException()
        {
            try
            {
                var censusDataList = analyzeCensus.loadIndianStateCensusData(INDIAN_STATE_CENSUS_DATA_INCORRECT);
            }
            catch (IndianStateCensusCoustomeExceptionData ex)
            {
                string expected = "File Not Found";
                Assert.AreEqual(expected, ex.Message);
            }
        }


        // 1.3 Given the States Census CSV file when correct but type incorrect return a custom exception
        [Test]
        public void LoadingIndianCensusData_WithInvalidFormat_ShoudReturnCustomException()
        {
            try
            {
                var censusDataList = analyzeCensus.loadIndianStateCensusData(WRONG_INDIAN_STATE_CENSUS_DATA_FORMAT);
            }
            catch (IndianStateCensusCoustomeExceptionData ex)
            {
                string expected = "Invalid File Type";
                Assert.AreEqual(expected, ex.Message);
            }
        }

        // 1.4 Given the States Census CSV file when correct but delimeter incorrect return a custom exception
        [Test]
        public void LoadingIndianCensusData_WithDelimeterIncorrect_ShoudReturnCustomException()
        {
            try
            {
                var censusDataList = analyzeCensus.loadIndianStateCensusData(WRONG_DELIMETER_INDIAN_STATE_CENSUS_DATA);
            }
            catch (IndianStateCensusCoustomeExceptionData ex)
            {
                string expected = "Wrong File Delimeter";
                Assert.AreEqual(expected, ex.Message);
            }
        }

        // 1.5 Given the States Census CSV file when correct but delimeter incorrect return a custom exception
        [Test]
        public void LoadingIndianCensusData_WithWrongHeader_ShoudReturnCustomException()
        {
            try
            {
                var censusDataList = analyzeCensus.loadIndianStateCensusData(WRONG_HEADER_INDIAN_STATE_CENSUS_DATA);
            }
            catch (IndianStateCensusCoustomeExceptionData ex)
            {
                string expected = "Wrong File Header";
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
