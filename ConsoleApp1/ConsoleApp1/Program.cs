namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string csvFilePath = @"C:\Users\Unknow\Desktop\ConsoleApp1\csv\populacja.csv";

            CsvReader csvReader = new CsvReader(csvFilePath);
            City[] citiesAll = csvReader.ReadFirstNCities(3);

            /*
            foreach (var city in cities)
            {
                Console.WriteLine("Miasto");
            }*/
            StreamReader sr = new StreamReader(csvFilePath);
            string line = sr.ReadLine();
            City c = csvReader.ReadCityFromCsvLine(line);
            Console.WriteLine(c.CityName);
        }
    }
}