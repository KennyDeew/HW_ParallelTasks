namespace HW_ParallelTasks
{
    public interface IFileReader
    {
        Task<int> ReadFileAndCountSpaces(string filePath);
    }
}
