using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.HotPatcherProxyBase")]
	public partial class UHotPatcherProxyBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherCore.HotPatcherProxyBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}