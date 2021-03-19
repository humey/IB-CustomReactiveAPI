using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTrading.Models
{
    /// <summary>
    /// Class used to hold any messages recieved from the TWS 
    /// </summary>
    public class MessageData
    {
        public string Message { get; }
        public int MessageId { get; }
        public int MessageCode { get; }


        public MessageData(string Message, int MessageId, int MessageCode)
        {
            this.Message = Message;
            this.MessageId = MessageId;
            this.MessageCode = MessageCode;
        }
        public override string ToString() => $"MessageID: {MessageId}, Message Code: {MessageCode}, Message: {Message}";
    }
}
