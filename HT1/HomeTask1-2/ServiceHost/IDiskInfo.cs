using System.ServiceModel;

namespace HT1_2
{
    [ServiceContract]
    public interface IDiskInfo
    {
        [OperationContract]
        string[] GetDiskInfo(string path);
    }
}
