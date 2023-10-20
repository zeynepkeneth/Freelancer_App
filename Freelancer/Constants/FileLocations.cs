using System;
namespace Freelancer.Constants
{
	internal static class FileLocations
	{
		public static string ProjectFolder => Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

    }
}

