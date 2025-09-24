using NLog;
using System.Diagnostics;

Logger logger = LogManager.GetCurrentClassLogger();
Trace.CorrelationManager.ActivityId = Guid.NewGuid();

Task1();

void Task1()
{
    Console.WriteLine("Task1 triggered");
    logger.Debug("Task1 triggered");
    Task2();
}

void Task2()
{
    Console.WriteLine("Task2 triggered");
    logger.Debug("Task2 triggered");
    Task3();
}

void Task3()
{
    Console.WriteLine("Task3 triggered");
    logger.Debug("Task3 triggered");
}
