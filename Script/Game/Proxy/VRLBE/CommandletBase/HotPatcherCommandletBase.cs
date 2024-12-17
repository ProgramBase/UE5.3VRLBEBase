using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.HotPatcherCommandletBase")]
	public partial class UHotPatcherCommandletBase : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherCore.HotPatcherCommandletBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}