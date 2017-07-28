using ChainOfResponsabilityPattern.Common;

namespace ChainOfResponsabilityPattern.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpenseHandler president = new ExpenseHandler(new Employee("Paula President", 20000));
            IExpenseHandler vicepresident = new ExpenseHandler(new Employee("Victor Vicepres", new decimal(5000)));
            IExpenseHandler manager = new ExpenseHandler(new Employee("Mary Manager", new decimal(1000)));
            IExpenseHandler worker = new ExpenseHandler(new Employee("William Worker", decimal.Zero));

            worker.SetSuccessor(manager);
            manager.SetSuccessor(vicepresident);
            vicepresident.SetSuccessor(president);

            decimal expenseReportAmount;
            while (ConsoleInput.TryReadDecimal("Expense report amount:", out expenseReportAmount))
            {
                IExpenseReport expense = new ExpenseReport(expenseReportAmount);

                worker.HandleExpense(expense);
            }
        }
    }
}
