using System;

namespace ThirdCode
{
	public interface IEmployeeService
	{
		void Create(Employee employee);
		Employee Read(int id);
		void Update(Employee employee);
		void Delete(int id);
	}
}
