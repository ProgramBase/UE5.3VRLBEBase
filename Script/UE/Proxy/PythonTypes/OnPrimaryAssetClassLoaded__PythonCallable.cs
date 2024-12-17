using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnPrimaryAssetClassLoaded__PythonCallable.OnPrimaryAssetClassLoaded__PythonCallable")]
	public partial class OnPrimaryAssetClassLoaded__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnPrimaryAssetClassLoaded__PythonCallable.OnPrimaryAssetClassLoaded__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}