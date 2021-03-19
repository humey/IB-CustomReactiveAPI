using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBApi;
using System.Reactive;
using CustomTrading.Models;

namespace CustomTrading.Model
{
    /// <summary>
    /// Class used to represent my trading platform & connect to the TWS through the RWrapperImpl
    /// </summary>
    public class IBClientAPI
    {
        private RWrapperImpl IBClient { get; } = new RWrapperImpl();
        private ConnectionData ConnectionInfo;

        public IObservable<MessageData> MessageData { get; }



      public IBClientAPI(ConnectionData data)
        {
            this.ConnectionInfo = data ?? new ConnectionData();


        }
        



    }
}
