using System.Windows.Forms;
using System.IO;
using System;

namespace SamplePrograms.ResourcesData.Source.Data
{
	public class SavedData
	{
		public string String_Language { get; set; } = "English";


		public string String_SaveDirectory { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\{Application.ProductName}");
		public string String_SaveName { get; set; } = "SavedData.json";

		public string String_OldSaveDirectory { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\{Application.ProductName}");
		public string String_OldSaveName { get; set; } = "SavedData.json";


		public int Int_AutoProgramUpdates { get; set; } = 1;
	}
}