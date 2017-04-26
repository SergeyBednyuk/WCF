using System.IO;
using HT1_2;

namespace ServiceHost
{
    class Service : IDiskInfo
    {
        public string[] GetDiskInfo(string path)
        {
            return Directory.GetFileSystemEntries(@path);
        }
    }
}
