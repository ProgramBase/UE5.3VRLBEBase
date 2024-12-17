using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NetRPCHandler")]
	public partial class UNetRPCHandler : UNetBlobHandler, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.NetRPCHandler");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}