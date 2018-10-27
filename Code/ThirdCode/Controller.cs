using System;

namespace ThirdCode
{
	public class Controller
	{
		private readonly IEmployeeService employeeService;

		public void CreateEmployee(Employee employee)
		{
			try
			{
				employeeService.Create(employee);
			}
			catch (Exception ex)
			{
				// Log message and handle error
			}
		}

		public void DeleteEmployee(int id)
		{
			try
			{
				employeeService.Delete(id);
			}
			catch (Exception ex)
			{
				// Log message and handle error
			}
		}
	}
}
