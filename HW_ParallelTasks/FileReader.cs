namespace HW_ParallelTasks
{
    public class FileReader : IFileReader
    {
        private string[] RowsArr {  get; set; }

        public Task<int> ReadFileAndCountSpaces(string filePath)
        {
            RowsArr = File.ReadAllLines(filePath);
            int count = 0;
            foreach (var Row in RowsArr)
            {
                count += Row.Count(s => s == ' ');
            }
            return Task.FromResult(count);
        }
    }
}
