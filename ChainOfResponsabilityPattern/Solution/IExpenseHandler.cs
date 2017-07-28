using ChainOfResponsabilityPattern.Common;

namespace ChainOfResponsabilityPattern.Solution
{
    public interface IExpenseHandler
    {
        ApprovalResponse HandleExpense(IExpenseReport expenseReport);

        void SetSuccessor(IExpenseHandler successor);
    }
}