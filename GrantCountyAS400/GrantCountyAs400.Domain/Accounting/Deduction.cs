namespace GrantCountyAs400.Domain.Accounting
{
    public class Deduction
    {
        public int Id { get; }
        public int MiscYear { get; }
        public decimal EmployeeNumber { get; }
        public string MiscCode { get; }
        public decimal MiscDeduction { get; }
        public decimal MiscBenefit { get; }

        public Deduction(int id, int miscYear, decimal employeeNumber, string miscCode, decimal miscDeduction, decimal miscBenefit)
        {
            Id = id;
            MiscYear = miscYear;
            EmployeeNumber = employeeNumber;
            MiscCode = miscCode;
            MiscDeduction = miscDeduction;
            MiscBenefit = miscBenefit;
        }
    }
}