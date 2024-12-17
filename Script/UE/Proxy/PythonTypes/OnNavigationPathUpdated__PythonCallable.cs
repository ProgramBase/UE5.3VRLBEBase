using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnNavigationPathUpdated__PythonCallable.OnNavigationPathUpdated__PythonCallable")]
	public partial class OnNavigationPathUpdated__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnNavigationPathUpdated__PythonCallable.OnNavigationPathUpdated__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}