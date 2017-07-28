namespace ChainOfResponsabilityPattern.Common
{
    public class Employee : IExpenseApprover
    {
        public Employee(string name, decimal approvalLimit)
        {
            Name = name;
            _approvalLimit = approvalLimit;
        }

        public string Name { get; }

        public ApprovalResponse ApproveExpense(IExpenseReport expenseReport)
        {
            return expenseReport.Total > _approvalLimit
                    ? ApprovalResponse.BeyondApprovalLimit
                    : ApprovalResponse.Approved;
        }

        private readonly decimal _approvalLimit;
    }
}
