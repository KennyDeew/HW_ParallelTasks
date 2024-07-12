using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ParallelTasks
{
    public class FileReader// : IFileReader
    {
        private string[] RowsArr {  get; set; }

        private string FilePath { get; set; }

        public async Task<int> CountSpaces(string path)
        {
            RowsArr = File.ReadAllLines(path);
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

        public void ReadFile()
        {
            RowsArr = File.ReadAllLines(FilePath);
        }
    }
}
