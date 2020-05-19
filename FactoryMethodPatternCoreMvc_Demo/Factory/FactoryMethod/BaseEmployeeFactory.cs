using FactoryMethodPatternCoreMvc_Demo.Managers;
using FactoryMethodPatternCoreMvc_Demo.Models;

namespace FactoryMethodPatternCoreMvc_Demo.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory(Employee emp)
        {
            _emp = emp;
        }

        public Employee ApplySalary()
        {
            IEmployeeManager employeeManager = this.Create();
            _emp.HourlyPay = employeeManager.GetPay();
            _emp.Bonus = employeeManager.GetBonus();
            return _emp;
        }
        public abstract IEmployeeManager Create();
    }
}
