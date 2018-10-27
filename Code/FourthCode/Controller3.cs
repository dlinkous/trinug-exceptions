using System;
using System.IO;

namespace FourthCode
{
	public class Controller3
	{
		private readonly IDatabase database;

		public void DoStuff(int id)
		{
			string content;
			if (database.Exists(id))
			{
				content = database.Read(id);
			}
			else
			{
				content = "Default Content";
				database.Create(id, content);
			}
			// Do stuff with content
		}
	}
}
