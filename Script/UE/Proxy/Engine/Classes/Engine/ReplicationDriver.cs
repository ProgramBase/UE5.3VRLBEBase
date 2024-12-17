using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ReplicationDriver")]
	public partial class UReplicationDriver : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ReplicationDriver");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}