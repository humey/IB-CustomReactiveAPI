using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTrading.Model
{
    /// <summary>
    /// Class to implement with the RWrapperImpl and request the bar data from the TWS application
    /// Might need a reqID
    /// </summary>
    public class BarData
    {
        public string Time { get; }
        public double Open { get; }
        public double High { get; }
        public double Low { get; }
        public long Volume { get; }
        public double WeightedAvgPrice { get; }
        public int NumberOfTradesInBar { get; }

        public BarData(string Time, double Open, double High, double Low, long Volume,
                        double WeightedAveragePrice, int NumberOfTradesInBar)
        {
            this.Time = Time;
            this.Open = Open;
            this.High = High;
            this.Low = Low;
            this.Volume = Volume;
            this.WeightedAvgPrice = WeightedAvgPrice;
            this.NumberOfTradesInBar = NumberOfTradesInBar;

        }

        public override string ToString()
        {
            return ($"Bar Data - Time: {Time}, Open: {Open}, High: {High}, Low: {Low}, Volume: {Volume}," +
                    $" WAP: {WeightedAvgPrice} Total Trades: {NumberOfTradesInBar}");
        }
    }
}
