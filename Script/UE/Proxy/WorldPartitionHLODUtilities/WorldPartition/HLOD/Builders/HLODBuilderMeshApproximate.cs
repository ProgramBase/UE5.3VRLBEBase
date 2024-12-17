using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.WorldPartitionHLODUtilities
{
	[PathName("/Script/WorldPartitionHLODUtilities.HLODBuilderMeshApproximate")]
	public partial class UHLODBuilderMeshApproximate : UHLODBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/WorldPartitionHLODUtilities.HLODBuilderMeshApproximate");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}