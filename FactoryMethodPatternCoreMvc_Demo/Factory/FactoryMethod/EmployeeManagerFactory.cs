using FactoryMethodPatternCoreMvc_Demo.Models;

namespace FactoryMethodPatternCoreMvc_Demo.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee emp)
        {
            BaseEmployeeFactory returnValue = null;

            if (emp.EmployeeTypeId == 1)
            {
                returnValue = new PermanentEmployeeFactory(emp);
            }
            else if (emp.EmployeeTypeId == 2)
            {
                returnValue = new ContractEmployeeFactory(emp);
            }
            return returnValue;
        }
    }
}
