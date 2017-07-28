namespace ChainOfResponsabilityPattern.Common
{
    public interface IExpenseApprover
    {
        string Name { get; }

        ApprovalResponse ApproveExpense(IExpenseReport expenseReport);
    }
}
