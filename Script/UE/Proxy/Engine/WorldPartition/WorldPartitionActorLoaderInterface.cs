using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionActorLoaderInterface")]
	public partial class UWorldPartitionActorLoaderInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionActorLoaderInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.WorldPartitionActorLoaderInterface")]
	public interface IWorldPartitionActorLoaderInterface : IInterface
	{
	}
}