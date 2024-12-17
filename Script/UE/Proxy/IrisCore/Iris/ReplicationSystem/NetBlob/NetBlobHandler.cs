using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NetBlobHandler")]
	public partial class UNetBlobHandler : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.NetBlobHandler");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}