﻿namespace HW_ParallelTasks
{
    public class FileReader : IFileReader
    {
        private string[] RowsArr {  get; set; }

        public async Task<int> ReadFileAndCountSpaces(string filePath)
        {
            RowsArr = await File.ReadAllLinesAsync(filePath);
            int count = 0;
            foreach (var Row in RowsArr)
            {
                count += Row.Count(s => s == ' ');
            }
            return count;
        }
    }
}
