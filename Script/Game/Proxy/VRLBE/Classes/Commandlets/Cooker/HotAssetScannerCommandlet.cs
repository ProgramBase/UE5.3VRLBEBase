using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.HotAssetScannerCommandlet")]
	public partial class UHotAssetScannerCommandlet : UHotPatcherCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherCore.HotAssetScannerCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}