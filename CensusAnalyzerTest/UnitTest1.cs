using CensusAnalyzerProblem;
using NUnit.Framework;

namespace CensusAnalyzerTest
{
    public class IndianStateCensusDataTest
    {
        string INDIAN_STATE_CENSUS_DATA_PATH = @"C:\Users\MY PC\Desktop\BridgeLabz\CensusAnalyzerProblem\CensusAnalyzerTest\Assest\IndiaStateCensusData";
        string INDIAN_STATE_CODE_CENSUS_DATA_INCORRECT = @"C:\Users\MY PC\Desktop\BridgeLabz\CensusAnalyzerProblem\CensusAnalyzerTest\Assest\IndiaCensusData.csv";
        string WRONG_INDIAN_STATE_CODE_CENSUS_DATA_FORMAT = @"C:\Users\MY PC\Desktop\BridgeLabz\CensusAnalyzerProblem\CensusAnalyzerTest\Assest\IndiaCensusData.txt";
        string WRONG_DELIMETER_INDIAN_STATE_CODE_CENSUS_DATA = @"C:\Users\MY PC\Desktop\BridgeLabz\CensusAnalyzerProblem\CensusAnalyzerTest\Assest\IndiaStateCodeIncorrectDelimeter";
        string WRONG_HEADER_INDIAN_STATE_CODE_CENSUS_DATA = @"C:\Users\MY PC\Desktop\BridgeLabz\CensusAnalyzerProblem\CensusAnalyzerTest\Assest\IndiaStateCodeIncorrectHeader";
        CensusAnalyzeData analyzeCensus;

   

        [SetUp]
        public void Setup()
        {
 
        }

        // 2.1 Given the StateCode Census CSV file, Check to ensure the Number of Record matches
        [Test]
        public void LoadingIndianCensusData_WithValidPath_ShoudReturnCount()
        {
            int expectedCount = 36;
            var censusDataList = analyzeCensus.loadIndianStateCodeCensusData(INDIAN_STATE_CENSUS_DATA_PATH);
            Assert.AreEqual(expectedCount, censusDataList.Count);
        }

        // 2.2 Given the StateCode Census CSV file if incorrect return a custom exception
        [Test]
        public void LoadingIndianCensusData_WithIncorrectFile_ShoudReturnCustomException()
        {
            try
            {
                var censusDataList = analyzeCensus.loadIndianStateCodeCensusData(INDIAN_STATE_CODE_CENSUS_DATA_INCORRECT);
            }
            catch (IndianStateCensusCoustomeExceptionData ex)
            {
                string expected = "File Not Found";
                Assert.AreEqual(expected, ex.Message);
            }
        }

        // 2.3 Given the StateCode Census CSV file when correct but type incorrect return a custom exception
        [Test]
        public void LoadingIndianCensusData_WithInvalidFormat_ShoudReturnCustomException()
        {
            try
            {
                var censusDataList = analyzeCensus.loadIndianStateCodeCensusData(WRONG_INDIAN_STATE_CODE_CENSUS_DATA_FORMAT);
            }
            catch (IndianStateCensusCoustomeExceptionData ex)
            {
                string expected = "Invalid File Type";
                Assert.AreEqual(expected, ex.Message);
            }
        }

        // 2.4 Given the StateCode Census CSV file when correct but delimeter incorrect return a custom exception
        [Test]
        public void LoadingIndianCensusData_WithDelimeterIncorrect_ShoudReturnCustomException()
        {
            try
            {
                var censusDataList = analyzeCensus.loadIndianStateCodeCensusData(WRONG_DELIMETER_INDIAN_STATE_CODE_CENSUS_DATA);
            }
            catch (IndianStateCensusCoustomeExceptionData ex)
            {
                string expected = "Wrong File Delimeter";
                Assert.AreEqual(expected, ex.Message);
            }
        }

        // 2.5 Given the StateCode Census CSV file when correct but delimeter incorrect return a custom exception
        [Test]
        public void LoadingIndianCensusData_WithWrongHeader_ShoudReturnCustomException()
        {
            try
            {
                var censusDataList = analyzeCensus.loadIndianStateCodeCensusData(WRONG_HEADER_INDIAN_STATE_CODE_CENSUS_DATA);
            }
            catch (IndianStateCensusCoustomeExceptionData ex)
            {
                string expected = "Wrong File Header";
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
