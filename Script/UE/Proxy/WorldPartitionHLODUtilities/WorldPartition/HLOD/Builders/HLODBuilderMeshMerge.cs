using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.WorldPartitionHLODUtilities
{
	[PathName("/Script/WorldPartitionHLODUtilities.HLODBuilderMeshMerge")]
	public partial class UHLODBuilderMeshMerge : UHLODBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/WorldPartitionHLODUtilities.HLODBuilderMeshMerge");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}