using System;
using System.IO;

namespace FourthCode
{
	public class FileSystemDatabase : IDatabase
	{
		public void Create(int id, string content) =>
			File.WriteAllText(GetPath(id), content);

		public string Read(int id) =>
			File.ReadAllText(GetPath(id));

		public bool Exists(int id) =>
			File.Exists(GetPath(id));

		private string GetPath(int id) =>
			$@"C:\Data\{id}.txt";
	}
}
