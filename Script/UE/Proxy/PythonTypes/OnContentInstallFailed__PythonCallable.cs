using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnContentInstallFailed__PythonCallable.OnContentInstallFailed__PythonCallable")]
	public partial class OnContentInstallFailed__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnContentInstallFailed__PythonCallable.OnContentInstallFailed__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}