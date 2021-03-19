using CustomTrading.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBApi;

namespace CustomTrading.Model
{
    /// <summary>
    /// Unsure what is needed in this class
    /// Some of the variables seem a bit pointless for what I am needing
    /// </summary>
    public class Contract
    {
        public int ContractID { get; }

        public string Symbol { get; }
        public SecurityType SecType { get; }

        /// <summary>
        /// The contract's last trading day or contract month (for Options and Futures).
        /// Strings with format YYYYMM will be interpreted as the Contract Month
        /// whereas YYYYMMDD will be interpreted as Last Trading Day.
        /// Maybe having what type of contract it is - Will this be easier to implement certain methods?
        /// </summary>
        public string LastTradeDateOrContractMonth { get; }

        /// <summary>
        /// Strike price of the contracts option
        /// </summary>
        public double StrikePrice { get; }
        
        /// <summary>
        /// If the option is a Put or a Call
        /// IB API - Says valid values are P, PUT, C, CALL - Unsure why? Also called Right in API 
        /// </summary>
        public string PutOrCall { get; }

        /// <summary>
        /// Contracts multiplier
        /// For options - this is used to calculate the total premium either paid or recieved
        /// For futures - The actual futures price is the quoted futures price times this multiplier
        /// </summary>
        public string Multiplier { get; }
        public string Exchange { get; }
        public string Currency { get; }

        /// <summary>
        /// Contracts symbol within its primary exchange
        /// Options it will be the OCC symbol
        /// </summary>
        public string LocalSymBol { get; }

        /// <summary>
        /// 
        /// </summary>
        public string PrimaryExch { get; }

        /// <summary>
        /// 
        /// </summary>
        public string TradingClass { get; }

        /// <summary>
        /// 
        /// </summary>
        public bool IncludedExpired { get; }

        public string SecIdType { get; }

        public string ComboLegDescription { get; }

        /// <summary>
        /// Use IObservable instead?
        /// </summary>
        public List<ComboLeg> ComboLegs { get; }

        public DeltaNeutralContract DeltaNeutralContract { get; }

        public override string ToString() => $"SecType: {SecType}, Symbol: {Symbol}, Currency: {Currency}, Exchange: {Exchange}";
    }
}
