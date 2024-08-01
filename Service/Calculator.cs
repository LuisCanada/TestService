using Contracts;

namespace Service;

public class Calculator
{
    private ILogger _logger;
    public int Add(int a, int b)
    {
        _logger.Log($"Adding {a} and {b}");
        return a + b;
    }
    public Calculator(ILogger logger)
    {
        _logger = logger;
    }
}

