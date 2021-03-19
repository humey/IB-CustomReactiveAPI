using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using IBApi;
using CustomTrading.Models;
using System.Reactive.Subjects;

namespace CustomTrading.Model
{
    public class RWrapperImpl 
    {

        // Makes MessageData a subject and attaches it to an Observable
        // When the Message gets updated via the TWS it will notify all the Observables and update
        private readonly ISubject<MessageData> _Message = new Subject<MessageData>();
        public IObservable<MessageData> Message =>_Message;




        /// <summary>
        /// Used for connection to the TWS 
        /// </summary>
        public EReaderSignal signal { get; } = new EReaderMonitorSignal();
        public EClientSocket Socket { get; }



        

        //public RWrapperImpl()
        //{
        //    Socket = new EClientSocket(this, signal);
        //}

    }
}
