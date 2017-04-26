using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MassengerServiceDll
{
    [ServiceContract(CallbackContract = typeof(IMessengerCollback))]
    public interface IMessenger
    {
        [OperationContract]
        void Login(string name);
        [OperationContract]
        void SendMessage(string text);
        [OperationContract]
        void Logout(string name);
    }

    public interface IMessengerCollback
    {
        [OperationContract(IsOneWay = true)]
        void TextForUsers(string text);
    }
}
