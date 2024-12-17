using Script.CoreUObject;
using Script.IrisCore;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActorReplicationBridge")]
	public partial class UActorReplicationBridge : UObjectReplicationBridge, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ActorReplicationBridge");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}