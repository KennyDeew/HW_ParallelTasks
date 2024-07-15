using System.Diagnostics;

namespace HW_ParallelTasks
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            string fileSelection = "C:\\Users\\Машина\\Documents\\FileColection\\";
            string FilePath1 = fileSelection + "1.txt",
                FilePath2 = fileSelection + "2.txt",
                FilePath3 = fileSelection + "3.txt";
            var fileReaderTest = new FileReader();
            var var1 = fileReaderTest.ReadFileAndCountSpaces(FilePath1);
            await var1;
            var var2 = fileReaderTest.ReadFileAndCountSpaces(FilePath2);
            await var2;
            var var3 = fileReaderTest.ReadFileAndCountSpaces(FilePath3);
            //await var1;
            //await var2;
            await var3;
            stopwatch.Stop();
            Console.WriteLine($"time - {stopwatch.ElapsedMilliseconds} File1 - {var1.Result}, File2 - {var2.Result}, File3 - {var3.Result}");
            stopwatch.Reset();
        }
    }
}
