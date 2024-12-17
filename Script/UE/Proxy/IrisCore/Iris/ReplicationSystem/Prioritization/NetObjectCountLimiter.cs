using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NetObjectCountLimiter")]
	public partial class UNetObjectCountLimiter : UNetObjectPrioritizer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.NetObjectCountLimiter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}