using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ParallelTasks
{
    public interface IFileReader
    {
        void ReadFile();
        Task<int> CountSpaces();
    }
}
