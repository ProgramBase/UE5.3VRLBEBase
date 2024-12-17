using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnPrimaryAssetLoaded__PythonCallable.OnPrimaryAssetLoaded__PythonCallable")]
	public partial class OnPrimaryAssetLoaded__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnPrimaryAssetLoaded__PythonCallable.OnPrimaryAssetLoaded__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}