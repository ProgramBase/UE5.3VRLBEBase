using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/DownloadImageDelegate__PythonCallable.DownloadImageDelegate__PythonCallable")]
	public partial class DownloadImageDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/DownloadImageDelegate__PythonCallable.DownloadImageDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}