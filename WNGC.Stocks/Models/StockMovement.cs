using System;
using System.Collections.Generic;
using System.Text;

namespace WNGC.Stocks.Models
{
    public class StockMovement
    {
        public Article Article { get; set; }
        public int Count { get; set; }
        public StockMovementPurpose StockMovementPurpose { get; set; }

        public override string ToString()
        {
            return $"{StockMovementPurpose.ToString()} on {Count} {Article.Name}";
        }
    }

    public enum StockMovementPurpose
    {
        PurchaseOrder = 0,
        Sales,
        B2BReturn,
        B2CReturn
    }
}
