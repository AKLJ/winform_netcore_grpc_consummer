using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;

namespace WNGC.Grpc.Services
{
    public class StockService : StockMovementService.StockMovementServiceBase
    {
        public override async Task GetMovements(Empty request, IServerStreamWriter<StockMovement> responseStream, ServerCallContext context)
        {
            var movements = CreateStockMovements();
            foreach (var movement in movements)
            {
                await responseStream.WriteAsync(movement);
                await Task.Delay(200);
            }
        }

        private static IEnumerable<StockMovement> CreateStockMovements()
        {
            ConcurrentBag<StockMovement> stockMovements = new ConcurrentBag<StockMovement>();
            var random = new Random();

            Company Nike = new Company()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Nike"
            };

            Company Adidas = new Company()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Adidas"
            };

            Company Puma = new Company()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Puma"
            };

            List<Article> articles = new List<Article>();

            for (int i = 0; i < 10; i++)
            {
                articles.Add(new Article()
                {

                    Id = Guid.NewGuid().ToString(),
                    Company = i % 3 == 0 ? Nike :
                        i % 4 == 0 ? Adidas :
                        i % 7 == 0 ? Puma : Nike,
                    Description = "Shoes n°" + i,
                    Name = "SHOES-" + i,
                    Price = random.Next(10, 450) * random.NextDouble()
                });
            }

            stockMovements = new ConcurrentBag<StockMovement>();
            Parallel.For(0, 10000000, new ParallelOptions() { MaxDegreeOfParallelism = 8 }, (x) =>
            {
                random = new Random();
                stockMovements.Add(new StockMovement()
                {
                    Count = random.Next(1, 500),
                    Article = articles[random.Next(0, 9)],
                    MovementPurpose = (StockMovement.Types.Purpose)random.Next(0, 3)
                });
            });

            return stockMovements;
        }
    }
}
