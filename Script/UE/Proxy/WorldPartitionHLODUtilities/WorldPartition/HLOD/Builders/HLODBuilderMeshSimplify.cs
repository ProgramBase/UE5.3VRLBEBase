using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.WorldPartitionHLODUtilities
{
	[PathName("/Script/WorldPartitionHLODUtilities.HLODBuilderMeshSimplify")]
	public partial class UHLODBuilderMeshSimplify : UHLODBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/WorldPartitionHLODUtilities.HLODBuilderMeshSimplify");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}