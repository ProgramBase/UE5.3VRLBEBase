using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnContentInstallSucceeded__PythonCallable.OnContentInstallSucceeded__PythonCallable")]
	public partial class OnContentInstallSucceeded__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnContentInstallSucceeded__PythonCallable.OnContentInstallSucceeded__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}