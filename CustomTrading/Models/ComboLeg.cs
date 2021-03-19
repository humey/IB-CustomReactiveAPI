using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTrading.Model
{
    /// <summary>
    /// Class probably isnt needed for my client - API wrapper
    /// Most features seem to be for institutionals
    /// IB API has shitty documentation and doesnt explain anything :)
    /// </summary>
    public class ComboLeg
    {
        /// <summary>
        /// The contracts ID from IB
        /// </summary>
        public int ContractID { get; }

        /// <summary>
        /// Relative number of contracts for the leg thats being made
        /// More info at IB Interactive analytics user guide
        /// </summary>
        public int Ratio { get; }
        public string Action { get; }
        public string Exchange { get; }
        public int OpenClose { get; }
        public int ShortSaleSlot { get; }
        
        public ComboLeg(int ContractID, int Ratio, string Action, string Exchange, int OpenClose, int ShortSaleSlot)
        {
            this.ContractID = ContractID;
            this.Ratio = Ratio;
            this.Action = Action;
            this.Exchange = Exchange;
            this.OpenClose = OpenClose;
            this.ShortSaleSlot = ShortSaleSlot;
        }

        override public string ToString() => ("blabla");

    }
}
