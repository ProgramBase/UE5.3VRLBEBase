using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnPrimaryAssetClassListLoaded__PythonCallable.OnPrimaryAssetClassListLoaded__PythonCallable")]
	public partial class OnPrimaryAssetClassListLoaded__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnPrimaryAssetClassListLoaded__PythonCallable.OnPrimaryAssetClassListLoaded__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}