using System;

namespace FourthCode
{
	public interface IDatabase
	{
		void Create(int id, string content);
		string Read(int id);
		bool Exists(int id);
	}
}
