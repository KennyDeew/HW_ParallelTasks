using System.Diagnostics;

namespace HW_ParallelTasks
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            string fileSelection = "C:\\Users\\Машина\\Documents\\FileColection\\";
            var fileReaderTest = new FileReader();
            var stopwatch = new Stopwatch();
            //stopwatch.Start();
            //string FilePath1 = fileSelection + "1.txt",
            //    FilePath2 = fileSelection + "2.txt",
            //    FilePath3 = fileSelection + "3.txt";
            //var var1 = fileReaderTest.ReadFileAndCountSpaces(FilePath1);
            ////await var1;//Последовательное выполнение Task'a
            //var var2 = fileReaderTest.ReadFileAndCountSpaces(FilePath2);
            ////await var2;//Последовательное выполнение Task'a
            //var var3 = fileReaderTest.ReadFileAndCountSpaces(FilePath3);
            //await var1;
            //await var2;
            //await var3;
            //stopwatch.Stop();
            //Console.WriteLine($"time - {stopwatch.ElapsedMilliseconds} File1 - {var1.Result}, File2 - {var2.Result}, File3 - {var3.Result}");
            //stopwatch.Reset();
            stopwatch.Start();
            var fileCollection = new FileCollectionHandler(fileSelection, fileReaderTest);
            var countSpaceTask = fileCollection.ReadAllFilesAndCountSpaces();
            stopwatch.Stop();
            Console.WriteLine($"time - {stopwatch.ElapsedMilliseconds}. Count of spaces - {countSpaceTask.Result}");
        }
    }
}
