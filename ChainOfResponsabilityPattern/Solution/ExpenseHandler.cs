using System;
using ChainOfResponsabilityPattern.Common;

namespace ChainOfResponsabilityPattern.Solution
{
    public class ExpenseHandler : IExpenseHandler
    {
        private IExpenseHandler _successor;

        private readonly IExpenseApprover _expenseApprover;

        public ExpenseHandler(IExpenseApprover expenseApprover)
        {
            _expenseApprover = expenseApprover;
        }

        public ApprovalResponse HandleExpense(IExpenseReport expenseReport)
        {
            var response = _expenseApprover.ApproveExpense(expenseReport);

            if (response != ApprovalResponse.BeyondApprovalLimit)
            {
                Console.WriteLine($"The request was {response} by {_expenseApprover.Name}");
            }
            else
            {
                if (_successor == null)
                {
                    Console.WriteLine("No one was able to approve your expense.");
                }
                else
                {
                    _successor.HandleExpense(expenseReport);
                }
            }

            return response;
        }

        public void SetSuccessor(IExpenseHandler successor)
        {
            _successor = successor;
        }
    }
}
