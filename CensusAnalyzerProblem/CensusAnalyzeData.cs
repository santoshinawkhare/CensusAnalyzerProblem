using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace CensusAnalyzerProblem
{
     public class CensusAnalyzeData
    {
        public CensusAnalyzeData()
        {

        }

        public List<IndianSatateCensusData> loadIndianStateCensusData(string filepath)
        {
            try
            {
                if (!Path.GetExtension(filepath).Contains("csv"))
                {
                    throw new IndianStateCensusCoustomeExceptionData(IndianStateCensusCoustomeExceptionData.ExceptionType.FILE_TYPE_INVALID, "Invalid File Type");
                }
                StreamReader streamReader = File.OpenText(filepath);
                CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
                return csvReader.GetRecords<IndianSatateCensusData>().ToList();
            }
            catch (FileNotFoundException)
            {
                throw new IndianStateCensusCoustomeExceptionData(IndianStateCensusCoustomeExceptionData.ExceptionType.FILE_NOT_FOUND, "File Not Found");
            }
            catch (CsvHelper.MissingFieldException)
            {
                throw new IndianStateCensusCoustomeExceptionData(IndianStateCensusCoustomeExceptionData.ExceptionType.FILE_DELIMETER_WRONG, "Wrong File Delimeter");
            }
            catch (CsvHelper.HeaderValidationException)
            {
                throw new IndianStateCensusCoustomeExceptionData(IndianStateCensusCoustomeExceptionData.ExceptionType.HEADER_IS_INCORRECT, "Wrong File Header");
            }

        }
    }
}
