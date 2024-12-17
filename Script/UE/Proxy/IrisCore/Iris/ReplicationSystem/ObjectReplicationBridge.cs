using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.ObjectReplicationBridge")]
	public partial class UObjectReplicationBridge : UReplicationBridge, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.ObjectReplicationBridge");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}