namespace ChainResponsibilityPattern.Services;

public abstract class DiscountHandler
{
    protected DiscountHandler _nextHandler;

    public DiscountHandler SetNextHandler(DiscountHandler nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public abstract decimal CalculateDiscount(Customer customer, decimal orderTotal);
}