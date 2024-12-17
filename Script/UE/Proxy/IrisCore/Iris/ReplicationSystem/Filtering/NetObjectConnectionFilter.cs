using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NetObjectConnectionFilter")]
	public partial class UNetObjectConnectionFilter : UNetObjectFilter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.NetObjectConnectionFilter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}