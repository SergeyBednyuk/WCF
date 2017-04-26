using System.ServiceModel;

namespace ClientDiskInfo
{
    [ServiceContract]
    interface IDiskInfo
    {
        [OperationContract]
        string[] GetDiskInfo(string path);
    }
}
