using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.HotPatcherAssetManager")]
	public partial class UHotPatcherAssetManager : UAssetManager, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherRuntime.HotPatcherAssetManager");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}