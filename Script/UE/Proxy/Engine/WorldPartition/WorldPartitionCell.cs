using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionCell")]
	public partial class UWorldPartitionCell : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionCell");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.WorldPartitionCell")]
	public interface IWorldPartitionCell : IInterface
	{
	}
}