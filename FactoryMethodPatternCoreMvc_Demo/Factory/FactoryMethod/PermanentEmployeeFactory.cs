using FactoryMethodPatternCoreMvc_Demo.Managers;
using FactoryMethodPatternCoreMvc_Demo.Models;

namespace FactoryMethodPatternCoreMvc_Demo.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager permanentEmployeeManager = new PermanentEmployeeManager();
            _emp.HouseAllowance= permanentEmployeeManager.GetHouseAllowance();
            return permanentEmployeeManager;
        }
    }
}
