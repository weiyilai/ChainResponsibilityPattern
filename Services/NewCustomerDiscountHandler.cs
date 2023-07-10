namespace ChainResponsibilityPattern.Services;

public class NewCustomerDiscountHandler : DiscountHandler
{
    public override decimal CalculateDiscount(Customer customer, decimal orderTotal)
    {
        if (customer.IsNew)
        {
            return orderTotal * 0.95m;
        }

        return _nextHandler?.CalculateDiscount(customer, orderTotal) ?? orderTotal;
    }
}