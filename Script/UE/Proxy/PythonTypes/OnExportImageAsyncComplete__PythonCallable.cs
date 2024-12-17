using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnExportImageAsyncComplete__PythonCallable.OnExportImageAsyncComplete__PythonCallable")]
	public partial class OnExportImageAsyncComplete__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnExportImageAsyncComplete__PythonCallable.OnExportImageAsyncComplete__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}