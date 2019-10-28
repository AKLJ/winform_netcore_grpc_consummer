using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using WNGC.Stocks.Models;

namespace WNGC.Core
{
    public static class StockCore
    {
        public static async Task CreateStockMovements()
        {
            var random = new Random();

            Company Nike = new Company()
            {
                Id = Guid.NewGuid(),
                Name = "Nike"
            };

            Company Adidas = new Company()
            {
                Id = Guid.NewGuid(),
                Name = "Adidas"
            };

            Company Puma = new Company()
            {
                Id = Guid.NewGuid(),
                Name = "Puma"
            };

            List<Article> articles = new List<Article>();

            for (int i = 0; i < 10; i++)
            {
                articles.Add(new Article()
                {

                    Id = Guid.NewGuid(),
                    Company = i % 3 == 0 ? Nike :
                        i % 4 == 0 ? Adidas :
                        i % 7 == 0 ? Puma : Nike,
                    Description = "Shoes n°" + i,
                    Name = "SHOES-" + i,
                    Price = random.Next(1, 450) * random.NextDouble()
                });
            }

            StockMovements = new ConcurrentBag<StockMovement>();

            Parallel.For(0, 10000000, new ParallelOptions() { MaxDegreeOfParallelism = 8 }, (x) =>
            {
                StockMovements.Add(new StockMovement()
                {
                    Count = random.Next(1,500),
                    Article = articles[random.Next(0,9)],
                    StockMovementPurpose = (StockMovementPurpose)random.Next(0,3)
                });
            });
        }
        public static ConcurrentBag<StockMovement> StockMovements { get; set; }
    }
}
