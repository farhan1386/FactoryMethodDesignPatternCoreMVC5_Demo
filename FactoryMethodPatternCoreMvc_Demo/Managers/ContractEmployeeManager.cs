namespace FactoryMethodPatternCoreMvc_Demo.Managers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 8;
        }

        public decimal GetPay()
        {
            return 10;
        }

        public decimal GetMedicalAllowance()
        {
            return 100;
        }
    }
}
