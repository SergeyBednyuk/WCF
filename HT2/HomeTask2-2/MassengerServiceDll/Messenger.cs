using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MassengerServiceDll
{
    public class Messenger : IMessenger
    {
        public void Login(string name)
        {
            
        }

        public void SendMessage(string text)
        {
            OperationContext.Current.GetCallbackChannel<IMessengerCollback>().TextForUsers(text);
        }

        public void Logout(string name)
        {
            
        }
    }
}
