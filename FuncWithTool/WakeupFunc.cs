using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FuncWithTool
{
    public static class WakeupFunc
    {
        [FunctionName("WakeupFunc")]
        public static void Run([TimerTrigger("*/5 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"Wake up sharmila and Taniya at: {DateTime.Now}");
        }
    }
}
