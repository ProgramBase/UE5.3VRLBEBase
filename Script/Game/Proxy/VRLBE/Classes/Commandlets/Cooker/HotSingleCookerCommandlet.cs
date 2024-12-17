using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.HotSingleCookerCommandlet")]
	public partial class UHotSingleCookerCommandlet : UHotPatcherCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherCore.HotSingleCookerCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}