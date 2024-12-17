using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionHLODProvider")]
	public partial class UWorldPartitionHLODProvider : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionHLODProvider");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.WorldPartitionHLODProvider")]
	public interface IWorldPartitionHLODProvider : IInterface
	{
	}
}