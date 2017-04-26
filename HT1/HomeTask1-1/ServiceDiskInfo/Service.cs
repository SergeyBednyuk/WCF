using System.IO;

namespace ServiceDiskInfo
{
    class Service:IDiskInfo
    {
        public string[] GetDiskInfo(string path)
        {
            return Directory.GetFileSystemEntries(@path);
        }
    }
}
