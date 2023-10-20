using System;
using Freelancer.Constants;
using Freelancer.Common;
using Freelancer.Abstract;

namespace Freelancer
{
	internal class NotepadServices
	{
		public void SaveToNotepad(ICsvConvertible data)
		{
			string path = $"{FileLocations.ProjectFolder}\\Database";
			string type = data.GetType().ToString().Split(".").LastOrDefault();
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);
			
			string filePath = $"{path}\\{type}s.txt";

			File.AppendAllText(filePath, $"{data.GetValuesCSV()}\n" );
        }
		public string GetOnNotepad(string path)
		{
			if (File.Exists(path))
				return File.ReadAllText(path);
			throw new Exception("File Doesn't Exist");
		}

	}
}

