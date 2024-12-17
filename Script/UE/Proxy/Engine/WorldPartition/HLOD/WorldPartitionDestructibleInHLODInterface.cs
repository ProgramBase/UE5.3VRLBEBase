using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionDestructibleInHLODInterface")]
	public partial class UWorldPartitionDestructibleInHLODInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionDestructibleInHLODInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.WorldPartitionDestructibleInHLODInterface")]
	public interface IWorldPartitionDestructibleInHLODInterface : IInterface
	{
		 void SetHLODDestructionTag(FWorldPartitionHLODDestructionTag InDestructionTag);

		 FWorldPartitionHLODDestructionTag GetHLODDestructionTag();
	}
}