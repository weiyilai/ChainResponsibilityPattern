namespace ChainResponsibilityPattern.Services;

public class RegularDiscountHandler : DiscountHandler
{
    public override decimal CalculateDiscount(Customer customer, decimal orderTotal)
    {
        if (customer.IsRegular)
        {
            return orderTotal * 0.9m;
        }

        return _nextHandler?.CalculateDiscount(customer, orderTotal) ?? orderTotal;
    }
}