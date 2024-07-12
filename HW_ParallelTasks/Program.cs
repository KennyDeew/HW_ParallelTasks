namespace HW_ParallelTasks
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            string fileSelection = "C:\\Users\\a\\Documents\\FileColection\\";
            string FilePath1 = fileSelection + "1.txt", 
                FilePath2 = fileSelection + "2.txt", 
                FilePath3 = fileSelection + "3.txt";
            var fileReaderTest = new FileReader();
            var var1 = fileReaderTest.CountSpaces(FilePath1);
            var var2 = fileReaderTest.CountSpaces(FilePath2);
            var var3 = fileReaderTest.CountSpaces(FilePath3);
            await var1;
            await var2;
            await var3;
        }
        internal async Task<int> ReadFileAndCountSpaceAsync(string filePath)
        {
            string[] RowsArr = File.ReadAllLines(filePath);
            int count = 0;
            await Task.Run(() =>
            {
                foreach (var Row in RowsArr)
                {
                    count += Row.Count(s => s == ' ');
                }
            });
            return count;
        }
    }
}
