using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.HotCookerCommandlet")]
	public partial class UHotCookerCommandlet : UHotPatcherCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherCore.HotCookerCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}