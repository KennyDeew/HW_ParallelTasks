namespace HW_ParallelTasks
{
    public interface IFileCollectionHandler
    {
        string[]? GetFiles();
        Task<int> ReadAllFilesAndCountSpaces();
    }
}
