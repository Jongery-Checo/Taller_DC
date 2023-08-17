using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MigrarEmpleadoService
{
    public sealed class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
               
                await Task.Delay(TimeSpan.FromMinutes(10), stoppingToken);
            }
        }

       
    }
}
