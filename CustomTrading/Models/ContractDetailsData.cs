using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBApi;

namespace CustomTrading.Model
{
    // Need a int requestID?
    public class ContractDetailsData
    {
        public ContractDetails ContractDetails { get; }
        public bool IsBond { get; }
        public ContractDetailsData(ContractDetails ContractDetails, bool IsBond)
        {
            this.ContractDetails = ContractDetails;
            this.IsBond = IsBond;
        }
    }
}
