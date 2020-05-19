using FactoryMethodPatternCoreMvc_Demo.Managers;
using FactoryMethodPatternCoreMvc_Demo.Models;

namespace FactoryMethodPatternCoreMvc_Demo.Factory.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager contractEmployeeManager = new ContractEmployeeManager();
            _emp.MedicalAllowance=contractEmployeeManager.GetMedicalAllowance();
            return contractEmployeeManager;
        }
    }
}
