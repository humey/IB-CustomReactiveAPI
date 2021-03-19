using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTrading.Enums
{
    public enum ComboLeg
    {
        [Description("Same")]
        SAME = 0,
        [Description("Open")]
        OPEN = 1,
        [Description("Close")]
        CLOSE = 2,
        [Description("Unknown")]
        UKNOWN = 3
    }

    public enum Constants
    {
        ClientVersion = 66, // This will change with updates
        EOL = 0, // Used as a byte - Unsure what this even is
    }

    public enum SecurityType
    {
        [Description("Stock")]
        STK,
        [Description("Option")]
        OPT,
        [Description("Future")]
        FUT,
        [Description("Index")]
        IND,
        [Description("Future Options")]
        FOP,
        [Description("Forex Pair")]
        CASH,
        [Description("Combo")]
        BAG,
        [Description("Warrant")]
        WAR,
        [Description("Bond")]
        BOND,
        [Description("Commodity")]
        CMDTY,
        [Description("News")]
        NEWS,
        [Description("Mutual Fund")]
        FUND
    }


}
