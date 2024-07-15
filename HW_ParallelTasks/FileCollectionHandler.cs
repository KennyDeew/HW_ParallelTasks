namespace HW_ParallelTasks
{
    public class FileCollectionHandler : IFileCollectionHandler
    {
        public string FilesDirectory { get; set; }

        public string[] FilePathArr { get; set; }

        public string[]? GetFiles()
        {
            return Directory.GetFiles(FilesDirectory);
        }

        public void Start()
        {
            foreach (var FilePath in FilePathArr)
            {

            }
        }
    }
}
