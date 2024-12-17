using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/SystemLibrary_OnAssetLoaded__PythonCallable.SystemLibrary_OnAssetLoaded__PythonCallable")]
	public partial class SystemLibrary_OnAssetLoaded__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/SystemLibrary_OnAssetLoaded__PythonCallable.SystemLibrary_OnAssetLoaded__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}