using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.WorldPartitionHLODUtilities
{
	[PathName("/Script/WorldPartitionHLODUtilities.WorldPartitionHLODModifierMeshDestruction")]
	public partial class UWorldPartitionHLODModifierMeshDestruction : UWorldPartitionHLODModifier, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/WorldPartitionHLODUtilities.WorldPartitionHLODModifierMeshDestruction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}