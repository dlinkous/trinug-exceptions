using System;
using System.IO;

namespace FourthCode
{
	public class Controller1
	{
		private readonly IDatabase database;

		public void DoStuff(int id)
		{
			try
			{
				var content = database.Read(id);
			}
			catch (FileNotFoundException ex)
			{
				var message = $"Unable to do stuff with file {ex.FileName}.";
				// Log the message
			}
		}
	}
}
