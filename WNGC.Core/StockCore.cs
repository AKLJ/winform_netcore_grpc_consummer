using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using WNGC.Stocks.Models;

namespace WNGC.Core
{
    public static class StockCore
    {
        public static ConcurrentBag<StockMovement> StockMovements { get; set; }
    }
}
