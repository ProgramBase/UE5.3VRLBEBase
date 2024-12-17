using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.PatcherProxy")]
	public partial class UPatcherProxy : UHotPatcherProxyBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherCore.PatcherProxy");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}