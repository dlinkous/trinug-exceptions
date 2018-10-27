using System;

namespace ThirdCode
{
	public class FakeController
	{
		private readonly IEmployeeService employeeService;

		public void CreateEmployee(Employee employee)
		{
			employeeService.Create(employee);
		}
		//catch (Exception ex)
		//{
		//	// Log message and handle error
		//}

		public void DeleteEmployee(int id)
		{
			employeeService.Delete(id);
		}
		//catch (Exception ex)
		//{
		//	// Log message and handle error
		//}
	}
}
