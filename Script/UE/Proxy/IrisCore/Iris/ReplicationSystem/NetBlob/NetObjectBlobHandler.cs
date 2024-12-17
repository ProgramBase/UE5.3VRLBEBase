using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NetObjectBlobHandler")]
	public partial class UNetObjectBlobHandler : UNetBlobHandler, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.NetObjectBlobHandler");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}