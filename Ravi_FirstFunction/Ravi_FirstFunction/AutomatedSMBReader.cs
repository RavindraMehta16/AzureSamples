using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Ravi_FirstFunction
{
    public static class AutomatedSMBReader
    {
        [FunctionName("AutomatedSMBReader1")]
        public static void Run([ServiceBusTrigger("ravitestnotifications", "subscribetest1", Connection = "Connectionstring")] string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
