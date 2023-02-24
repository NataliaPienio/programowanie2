using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class CsvReader
    {
        private string csvFilePath = "";

        public CsvReader(string _csvFilePath) {
            csvFilePath= _csvFilePath;
        }

        public City[] ReadFirstNCities(uint nCities) 
        {
            //return null;
            City[] cities = new City[nCities];
            return cities;
        }
        public City ReadCityFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(', ');
            string CityName = parts[0];
            return new City(CityName);
        }
    }
}
