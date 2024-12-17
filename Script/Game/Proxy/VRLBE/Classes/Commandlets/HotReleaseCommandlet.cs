using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.HotReleaseCommandlet")]
	public partial class UHotReleaseCommandlet : UHotPatcherCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherCore.HotReleaseCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}