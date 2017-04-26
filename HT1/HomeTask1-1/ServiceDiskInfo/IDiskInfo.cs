using System.ServiceModel;

namespace ServiceDiskInfo
{
    [ServiceContract]
    interface IDiskInfo
    {
        [OperationContract]
        string[] GetDiskInfo(string path);
    }
}
