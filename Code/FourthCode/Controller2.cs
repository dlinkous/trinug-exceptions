using System;
using System.IO;

namespace FourthCode
{
	public class Controller2
	{
		private readonly FileSystemDatabase database;

		public void DoStuff(int id)
		{
			string content;
			try
			{
				content = database.Read(id);
			}
			catch (FileNotFoundException)
			{
				content = "Default Content";
				database.Create(id, content);
			}
			// Do stuff with content
		}
	}
}
