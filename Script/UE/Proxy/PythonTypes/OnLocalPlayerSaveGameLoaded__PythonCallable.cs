using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnLocalPlayerSaveGameLoaded__PythonCallable.OnLocalPlayerSaveGameLoaded__PythonCallable")]
	public partial class OnLocalPlayerSaveGameLoaded__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnLocalPlayerSaveGameLoaded__PythonCallable.OnLocalPlayerSaveGameLoaded__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}