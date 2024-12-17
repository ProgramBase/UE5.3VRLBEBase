using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.HotPatcherCommandlet")]
	public partial class UHotPatcherCommandlet : UHotPatcherCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherCore.HotPatcherCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}