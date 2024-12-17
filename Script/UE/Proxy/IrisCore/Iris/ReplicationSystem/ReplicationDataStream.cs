using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.ReplicationDataStream")]
	public partial class UReplicationDataStream : UDataStream, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.ReplicationDataStream");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}