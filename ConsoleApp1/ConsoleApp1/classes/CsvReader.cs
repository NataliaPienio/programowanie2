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

        public City[] ReadFirstNCities(uint nCities) {
            return null;
        }
    }
}
