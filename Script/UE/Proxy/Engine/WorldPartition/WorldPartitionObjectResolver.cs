using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionObjectResolver")]
	public partial class UWorldPartitionObjectResolver : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionObjectResolver");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.WorldPartitionObjectResolver")]
	public interface IWorldPartitionObjectResolver : IInterface
	{
	}
}