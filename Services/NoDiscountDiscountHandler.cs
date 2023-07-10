namespace ChainResponsibilityPattern.Services;

public class NoDiscountDiscountHandler : DiscountHandler
{
    public override decimal CalculateDiscount(Customer customer, decimal orderTotal)
    {
        return orderTotal;
    }
}