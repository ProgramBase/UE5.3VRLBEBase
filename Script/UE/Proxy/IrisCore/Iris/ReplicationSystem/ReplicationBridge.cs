using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.ReplicationBridge")]
	public partial class UReplicationBridge : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.ReplicationBridge");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}