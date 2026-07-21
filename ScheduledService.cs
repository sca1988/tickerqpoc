using TickerQ.Utilities.Base;
using TickerQ.Utilities.Enums;
using TickerQ.Utilities.Interfaces;

namespace WebApplication1;

public class ScheduledService: ITickerFunction
{
    [TickerFunction("job-execution-scheduler", TickerTaskPriority.High, maxConcurrency: 1)]
    public Task ExecuteAsync(TickerFunctionContext context, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}