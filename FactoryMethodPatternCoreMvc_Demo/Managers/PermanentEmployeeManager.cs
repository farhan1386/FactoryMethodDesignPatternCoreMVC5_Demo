namespace FactoryMethodPatternCoreMvc_Demo.Managers
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public decimal GetPay()
        {
            return 12;
        }

        public decimal GetHouseAllowance()
        {
            return 150;
        }
    }
}
