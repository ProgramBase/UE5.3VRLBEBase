using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ReplicationConnectionDriver")]
	public partial class UReplicationConnectionDriver : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ReplicationConnectionDriver");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}