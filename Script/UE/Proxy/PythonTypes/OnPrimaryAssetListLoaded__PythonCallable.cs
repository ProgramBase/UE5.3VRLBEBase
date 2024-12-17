using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnPrimaryAssetListLoaded__PythonCallable.OnPrimaryAssetListLoaded__PythonCallable")]
	public partial class OnPrimaryAssetListLoaded__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnPrimaryAssetListLoaded__PythonCallable.OnPrimaryAssetListLoaded__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}